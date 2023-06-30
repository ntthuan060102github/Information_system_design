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
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txtbox_username.Text;
            string password = txtbox_password.Text;

            if(!TaiKhoan.DangNhap(username, password))
            {
                MessageBox.Show(
                    "Thông tin đăng nhập không hợp lệ!",
                    "Đăng nhập thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            GUI_Home homePage = new GUI_Home();
            homePage.Show();
            this.Hide();
        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }
    }
}
