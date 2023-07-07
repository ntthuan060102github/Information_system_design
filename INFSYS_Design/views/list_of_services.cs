using INFSYS_Design.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFSYS_Design.views
{
    public partial class GUI_ListOfServices : Form
    {
        public GUI_ListOfServices()
        {
            InitializeComponent();            
            List<DichVu> list_of_services = DichVu.layDanhSachDichVu();
            foreach (DichVu service in list_of_services)
            {
                this.dataGridView1.Rows.Add(
                    service.ma,
                    service.tenDichVu,
                    service.moTa,
                    service.loaiDichVu,
                    service.gia
                );
            }
            if(Program.currentUserRole != "ADMIN")
            {
                this.add_service_btn.Enabled = false;
                this.delete_service_btn.Enabled = false;
                this.update_service_btn.Enabled = false;
            }
        }

        private void add_service_btn_Click(object sender, EventArgs e)
        {
            GUI_AddService addService = new GUI_AddService();
            addService.ShowDialog();
            addService.Dispose();
        }

        private void update_service_btn_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn dịch vụ cần sửa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;
            int maDichVu = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            GUI_UpdateService updateService = new GUI_UpdateService(maDichVu);
            Program.previousForm.Add(this);
            updateService.Show();
            this.Hide();
        }

        private void delete_service_btn_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn dịch vụ cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int ma = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            if (DichVu.xoaDichVu(ma))
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void list_of_services_Load(object sender, EventArgs e)
        {

        }
    }
}
