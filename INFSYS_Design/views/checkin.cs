﻿using INFSYS_Design.controllers;
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
        public GUI_Checkin()
        {
            InitializeComponent();
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
            int soPhong = int.Parse(this.tbSoPhong.Text);
            string tenKH = this.tbTenKH.Text;

            ThongTinKhachHang ttkh = ThongTinKhachHang.layThongTinKhachHangTheoTen(tenKH);

            int maKH = ttkh.ma;
            YeuCauDatPhong yc_get = YeuCauDatPhong.layThongtinYeuCau(ttkh.ma, soPhong);

            List<LichSuDatPhong> ls = LichSuDatPhong.layLichSuDatPhong(yc_get.ma);
            foreach (LichSuDatPhong lsdp in ls)
                {
                    this.dtgHistory.Rows.Add(
                        ttkh.hoTen,
                        lsdp.soPhong
                );
            }


            this.customer_name.Text = $"{ttkh.hoTen}";
            this.customer_id_num.Text = $"CCCD/CMND: {ttkh.maSoDinhDanh}";
            this.customer_year_of_birth.Text = $"Năm sinh: {ttkh.namSinh}";
            this.customer_email.Text = $"Email: {ttkh.email}";
            this.customer_phone_num.Text = $"SĐT: {ttkh.sdt}";
            this.customer_address.Text = $"Địa chỉ thường trú: {ttkh.diaChiThuongTru}";
            this.customer_gender.Text = $"Giới tính: {ttkh.gioiTinh}";

            int maYeuCau = yc_get.ma;

            int soPhongColumnIndex = dtgHistory.Columns["SOPHONG"].Index;
            DataGridViewRow currentRow = dtgHistory.CurrentRow;
            if (currentRow != null)
            {
                object value = currentRow.Cells[soPhongColumnIndex].Value;
                string sophong = value.ToString();

                    if (LichSuDatPhong.capNhatLichSuDatPhong(sophong,maYeuCau))
                {
                    MessageBox.Show(
                        "Thành công!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
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
}
