using INFSYS_Design.controllers;
using INFSYS_Design.models;
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
    public partial class GUI_Checkin : Form
    {
        private int maKH;
        public GUI_Checkin(int maDatPhong)
        {
            InitializeComponent();
            YeuCauDatPhong request = YeuCauDatPhong.layThongtinYeuCauTheoMaDatPhong(maDatPhong);
            ThongTinKhachHang customer = ThongTinKhachHang.layThongTinKhachHang(request.maKH);
            this.maKH = customer.ma;
            this.customer_name.Text = customer.hoTen;
            this.customer_id_num.Text = "CCCD/CMND: " + customer.maSoDinhDanh;
            this.customer_year_of_birth.Text = "Năm sinh: " + customer.namSinh;
            this.customer_email.Text = "Email: " + customer.email;
            this.customer_phone_num.Text = "SĐT: " + customer.sdt;
        }

        private void label_date_start_Click(object sender, EventArgs e)
        {

        }

        private void label_date_end_Click(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {

        }

        private void checkin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void customer_name_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            LichSuDatPhong history = LichSuDatPhong.layLichSuDatPhongTheoMaKH(this.maKH);
            if(LichSuDatPhong.checkin(history.ma))
            {
                MessageBox.Show(
                    "Checkin thành công!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Checkin thất bại!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
