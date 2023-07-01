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
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
            List<LoaiPhong> dataset = LoaiPhong.layDanhSachLoaiPhong();
            foreach (LoaiPhong typeroom in dataset)
            {
                this.dtgLoaiPhong.Rows.Add(
                    typeroom.hangPhong,
                    typeroom.soGiuong,
                    typeroom.loaiGiuong
                );
            }
        }

        private void booking_intermediary_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg_list_empty_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_customer_info_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tbLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            //List<LoaiPhong> dsLoaiPhong = DB_LoaiPhong.layDanhSachLoaiPhong();

            //// Duyệt qua danh sách loại phòng
            //foreach (LoaiPhong lp in dsLoaiPhong)
            //{
            //    // Lấy ra các giá trị của các trường bạn muốn hiển thị
            //    string ma = lp.getMa();
            //    string ten = lp.getTen();
            //    decimal gia = lp.getGia();
            //    // Tiếp tục với các trường khác nếu có

            //    // Nối các giá trị của các trường thành một chuỗi
            //    string loaiPhong = ma + " - " + ten + " - " + gia.ToString() + "\n";
            //    // Gán cho textBox
            //    tbLoaiPhong.AppendText(loaiPhong);
            //}
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_time_checkout_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_time_checkin_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void dtgLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
