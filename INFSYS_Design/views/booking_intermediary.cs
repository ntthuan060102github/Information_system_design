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
using static System.Net.Mime.MediaTypeNames;

namespace INFSYS_Design.views
{
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
            List<LoaiPhong> dsLoaiPhong = LoaiPhong.layDanhSachLoaiPhong();

            foreach (LoaiPhong typeroom in dsLoaiPhong)
            {
                this.dtgLoaiPhong.Rows.Add(
                    typeroom.maLoaiPhong,
                    typeroom.hangPhong,
                    typeroom.soGiuong,
                    typeroom.loaiGiuong
                );
            }

            int loaiPhongColumnIndex = dtgLoaiPhong.Columns["MALOAIPHONG"].Index;
            DataGridViewRow currentRow = dtgLoaiPhong.CurrentRow;
            if(currentRow != null)
            {
                object value = currentRow.Cells[loaiPhongColumnIndex].Value;
                string type = value.ToString();

                List<Phong> p = Phong.layDanhSachPhongTrongTheoLoaiPhong(type);
                foreach (Phong room in p)
                {
                    this.dtgDSPhongTrong.Rows.Add(
                        room.soPhong,
                        room.loaiPhong
                    );
                }
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
            try
            {
                string text_tenKH = this.tbTenKH.Text;
                string text_SDT = this.tbSDT.Text;
                string text_email = this.tbEmail.Text;
                string text_ID = this.tbDinhDanh.Text;
                string text_loaiDinhDanh = this.tbLoaiDinhDanh.Text;
                string text_diaChi = this.tbDiaChi.Text;
                string text_gioiTinh = this.tbGioiTinh.Text;
                string text_yeuCauDacBiet = this.tbYeuCauDacBiet.Text;
                string text_hinhThucThanhToan = this.tbhinhThucThanhToan.Text;
                int soTienDatCoc = int.Parse(this.tbSoTienDatCoc.Text);

                string text_ngSinh = this.dtpNgaySinh.Value.ToString();
                int namSinh = int.Parse(text_ngSinh.Substring(text_ngSinh.Length, -4));
                string text_ngDen = this.dtpNgayDen.Value.ToString();
                string text_tgCheckin = this.dtpCheckin.Value.ToString();
                string text_tgCheckout = this.dtpCheckout.Value.ToString();
                bool checkDSCho = this.checkDSCho.Checked;

                DateTime date = DateTime.Today;
                string ngayYeuCau = date.ToString("dd/MM/yyyy");
                // Tăng thêm 7 ngày cho DateTime
                DateTime newDate = date.AddDays(7);
                string ngHetHan = newDate.ToString("dd/MM/yyyy");

                var typeRoom = this.dtgLoaiPhong.SelectedRows;
                string type = typeRoom[0].ToString();

                ThongTinKhachHang kh = new ThongTinKhachHang(text_ID, text_loaiDinhDanh, text_email, namSinh,text_tenKH, text_diaChi, text_gioiTinh);

                bool checkKHtontai = ThongTinKhachHang.kiemTraKhachHang(kh);

                if (checkKHtontai == false)
                {
                    if (ThongTinKhachHang.themKhachHang(kh))
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


                int nguoiThucHien = Program.currentUserId;

                ThongTinKhachHang kh_get = ThongTinKhachHang.layThongTinKhachHangTheoTen(text_tenKH);

                YeuCauDatPhong yc = new YeuCauDatPhong(1, text_ngDen, ngayYeuCau, text_yeuCauDacBiet, kh_get.ma, type);

                YeuCauDatPhong yc_get = YeuCauDatPhong.layThongtinYeuCau(kh_get.ma);

                int maYeuCau = yc_get.ma;

                DanhSachCho kh_dsCho = new DanhSachCho("", ngayYeuCau, ngHetHan, nguoiThucHien, maYeuCau);

                string soPhong = "1";
                
                int soPhongColumnIndex = dtgDSPhongTrong.Columns["SOPHONG"].Index;
                DataGridViewRow currentRow = dtgDSPhongTrong.CurrentRow;
                if (currentRow != null)
                {
                    object value = currentRow.Cells[soPhongColumnIndex].Value;
                    soPhong = value.ToString();
                }

                if (checkDSCho || dtgDSPhongTrong == null)
                {
                    if (DanhSachCho.themKHVaoDSCho(kh_dsCho))
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
                else if(dtgDSPhongTrong != null && currentRow !=null)
                {

                    LichSuDatPhong ls = new LichSuDatPhong(text_tgCheckout,ngayYeuCau, text_hinhThucThanhToan, soTienDatCoc, maYeuCau, soPhong);
                    if (LichSuDatPhong.themLichSuDatPhong(ls))
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
            catch
            {
                MessageBox.Show(
                    "Yêu cầu không hợp lệ!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
    }

        private void dtgLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_list_empty_room_Click(object sender, EventArgs e)
        {

        }
    }
}
