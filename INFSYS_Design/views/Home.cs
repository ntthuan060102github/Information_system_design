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
    }
}
