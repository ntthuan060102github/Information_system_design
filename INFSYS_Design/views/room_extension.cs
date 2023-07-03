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
    public partial class GUI_RoomExtension : Form
    {
        public int soPhong;
        public GUI_RoomExtension(int soPhong)
        {
            InitializeComponent();
            Phong room = Phong.layThongTinPhong(soPhong);
            this.soPhong = soPhong;
            LoaiPhong roomType = LoaiPhong.layThongTinLoaiPhong(room.loaiPhong);
            ThongTinKhachHang cusomterInfo = Phong.layThongTinHangDangThuePhong(soPhong);
            List<DanhSachCho> waitingList = DanhSachCho.layDanhlayDanhSachTheoTheoLoaiPhong(room.loaiPhong);
            if (cusomterInfo != null)
            {
                this.customer_name.Text = cusomterInfo.hoTen;
                this.email.Text = cusomterInfo.email;
                this.address.Text = cusomterInfo.diaChiThuongTru;
                this.phone_num.Text = cusomterInfo.sdt;
                this.id_num.Text = cusomterInfo.maSoDinhDanh;
                this.gender.Text = cusomterInfo.gioiTinh == 1 ? "Nam" : "Nữ";
                this.year_of_birth.Text = cusomterInfo.namSinh.ToString();
                if (Program.currentUserRole == "NHANVIEN")
                {
                    this.submit_btn.Enabled = true;
                }
            }
            this.room_number.Text = room.soPhong.ToString();
            this.room_level.Text = roomType.hangPhong == 1 ? "Thường" : "Cao cấp";
            this.num_bed.Text = roomType.soGiuong.ToString();
            this.bed_type.Text = roomType.loaiGiuong == 1 ? "Giường đơn" : "Giường đôi";

            foreach (DanhSachCho item in waitingList)
            {
                this.waiting_list.Rows.Add(
                    item.thoiGianTao,
                    item.hanChot,
                    item.trangThai == "DANH_CHO" ? "Đang chờ" : "Không xác định"
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bed_type_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void RoomExtension_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customer_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void phone_num_label_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang customerInfo = Phong.layThongTinHangDangThuePhong(this.soPhong);
            YeuCauDatPhong yeuCauDatPhong = YeuCauDatPhong.layThongtinYeuCau(customerInfo.ma, this.soPhong);
            LichSuDatPhong lichSuDatPhong = LichSuDatPhong.layLichSuDatPhong(yeuCauDatPhong.ma);
            DateTime thoiGianGiaHan = this.dateTimePicker1.Value;
            
            if(LichSuGiaHan.themLichSuGiaHan(lichSuDatPhong.ma, thoiGianGiaHan))
            {
                MessageBox.Show(
                    "Thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Thất bại!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return;

        }
    }
}
