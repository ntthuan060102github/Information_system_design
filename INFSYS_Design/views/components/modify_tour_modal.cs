using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.controllers;

namespace INFSYS_Design.views.components
{
    public partial class GUI_ModifyTourModal : Form
    {
        private int maTour;
        public GUI_ModifyTourModal(int maTour)
        {
            InitializeComponent();
            this.maTour = maTour;
        }

        private void modify_tour_modal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTour = this.textBox1.Text;
            string moTa = this.textBox2.Text;
            DateTime ngayBatDau = this.dateTimePicker1.Value;
            DateTime ngayKetThuc = this.dateTimePicker2.Value;
            string loaiTour = this.textBox5.Text;
            string donViLuHanh = this.textBox3.Text;

            if (string.IsNullOrEmpty(tenTour) || string.IsNullOrEmpty(moTa) || string.IsNullOrEmpty(loaiTour) || string.IsNullOrEmpty(donViLuHanh))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (ngayBatDau.Date < DateTime.Now.Date || ngayKetThuc.Date < DateTime.Now.Date)
            {
                MessageBox.Show(
                    "Thời gian bắt đầu và kết thúc không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (ngayBatDau.Date >= ngayKetThuc.Date)
            {
                MessageBox.Show(
                    "Thời gian bắt đầu phải trước thời gian kết thúc không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (DanhSachTour.suaTour(this.maTour, tenTour, moTa, ngayBatDau, ngayKetThuc, loaiTour, donViLuHanh))
            {
                MessageBox.Show(
                    "Thành công!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thất bại!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
