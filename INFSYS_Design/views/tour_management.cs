using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.views.components;
using INFSYS_Design.controllers;

namespace INFSYS_Design.views
{
    public partial class GUI_DanhSachTour : Form
    {
        public GUI_DanhSachTour()
        {
            InitializeComponent();
            List<DanhSachTour> list_of_tours = DanhSachTour.layDanhSachTour();
            foreach (DanhSachTour tour in list_of_tours)
            {
                this.dataGridView1.Rows.Add(
                    tour.ma,
                    tour.tenTour,
                    tour.moTa,
                    tour.thoiGianBatDau,
                    tour.thoiGianKetThuc,
                    tour.loaiDichVu,
                    tour.donViLuHanh
                );
            }
            if (Program.currentUserRole != "ADMIN")
            {
                this.add_tour_btn.Enabled = false;
                this.delete_tour_btn.Enabled = false;
                this.update_tour_btn.Enabled = false;
            }
        }

        private void tour_management_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void delete_tour_btn_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn Tour cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int ma = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            if (DanhSachTour.xoaTour(ma))
            {
                MessageBox.Show(
                    "Thành công!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dataGridView1.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show(
                    "Thất bại!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void add_tour_btn_Click(object sender, EventArgs e)
        {
            GUI_AddTourModal modal = new GUI_AddTourModal();
            modal.ShowDialog();
            GUI_DanhSachTour g = new GUI_DanhSachTour();
            this.Hide();
            g.Show();
        }

        private void update_tour_btn_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn Tour cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int ma = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());

            GUI_ModifyTourModal modal = new GUI_ModifyTourModal(ma);
            modal.ShowDialog();
            GUI_DanhSachTour g = new GUI_DanhSachTour();
            this.Hide();
            g.Show();
        }
    }
}
