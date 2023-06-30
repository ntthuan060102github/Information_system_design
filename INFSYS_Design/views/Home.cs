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
using INFSYS_Design.views;

namespace INFSYS_Design.views
{
    public partial class GUI_Home : Form
    {
        public GUI_Home()
        {
            InitializeComponent();
            NhanVien currentUser = NhanVien.layThongTinNhanVien();
            this.hello_label.Text = $"Xin chào {currentUser.hoTen}";
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void hello_label_Click(object sender, EventArgs e)
        {

        }

        private void btn_customer_list_Click(object sender, EventArgs e)
        {
            GUI_ListOfCustomers customersPage = new GUI_ListOfCustomers();
            Program.previousForm = new GUI_Home();
            customersPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ListOfRooms customersPage = new GUI_ListOfRooms();
            Program.previousForm = new GUI_Home();
            customersPage.Show();
            this.Hide();
        }
    }
}
