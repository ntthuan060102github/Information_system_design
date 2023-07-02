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
    public partial class GUI_XemDoanhThu : Form
    {
        public GUI_XemDoanhThu()
        {
            InitializeComponent();
        }

        private void label_date_start_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revenue_Load(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            string text_ngBD = this.dtpStart.Value.ToString();
            string text_ngKT = this.dtpEnd.Value.ToString();

            List<HoaDon> dshd = HoaDon.layDanhSachHoaDonTheoNgay(text_ngBD, text_ngKT);

            foreach (HoaDon hd in dshd)
            {
                this.dtgDoanhThu.Rows.Add(
                    hd.maHoaDon,
                    hd.thoiGianTao,
                    hd.VAT,
                    hd.chiPhiChuaThue,
                    hd.soTienNhan,
                    hd.maCheckout
                );
            }
        }
    }
}
