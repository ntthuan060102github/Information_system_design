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

namespace INFSYS_Design.views
{
    public partial class GUI_ListOfCustomers : Form
    {
        public GUI_ListOfCustomers()
        {
            InitializeComponent();
            List<ThongTinKhachHang> dataset = ThongTinKhachHang.layDanhSachKhachHang();
            foreach(ThongTinKhachHang customer in dataset)
            {
                this.dataGridView1.Rows.Add(
                    customer.hoTen,
                    customer.maSoDinhDanh,
                    customer.namSinh,
                    customer.email,
                    customer.sdt,
                    customer.diaChiThuongTru,
                    customer.gioiTinh == 1 ? "Nam" : "Nữ"
                );
            }
        }

        private void list_of_customers_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }
    }
}
