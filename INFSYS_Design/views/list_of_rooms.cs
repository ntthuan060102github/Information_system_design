using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.views.components;
using INFSYS_Design.controllers;

namespace INFSYS_Design.views
{
    public partial class GUI_ListOfRooms : Form
    {
        public GUI_ListOfRooms()
        {
            InitializeComponent();
            if(Program.currentUserRole == "NHANVIEN")
            {
                this.btn_delete_room.Hide();
                this.add_room_btn.Hide();
            }
            List<Phong> list_of_rooms = Phong.layDanhSachPhong();
            foreach(Phong room in list_of_rooms)
            {
                LoaiPhong room_type = LoaiPhong.layThongTinLoaiPhong(room.loaiPhong);

                this.dataGridView1.Rows.Add(
                    room.soPhong,
                    chuyenDoiTrangThai(room.trangThai),
                    room_type.hangPhong == 1 ? "Thường" : "Cao cấp",
                    room_type.soGiuong,
                    room_type.loaiGiuong == 1 ? "Giường đơn" : "Giường đôi",
                    room_type.gia
                );
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void list_of_rooms_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_detail_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần xem thông tin!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;
            int soPhong = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            GUI_RoomExtension roomExtensionPage = new GUI_RoomExtension(soPhong);
            Program.previousForm.Add(this);
            roomExtensionPage.Show();
            this.Hide();
        }

        private void add_room_btn_Click(object sender, EventArgs e)
        {
            GUI_AddRoomModal modal = new GUI_AddRoomModal();
            modal.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string chuyenDoiTrangThai(string trangThai)
        {
            switch (trangThai)
            {
                case "KHONG_SU_DUNG":
                    return "Không sử dụng";
                case "TRONG":
                    return "Trống";
                case "DANG_SU_DUNG":
                    return "Đang sử dụng";
                default:
                    return "Không xác định";
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int soPhong = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            if (Phong.xoaPhong(soPhong))
            {
                MessageBox.Show(
                    "Thành công!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dataGridView1.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show(
                    "Thất bại!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần checkin!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int soPhong = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            Phong room = Phong.layThongTinPhong(soPhong);
            if (room.trangThai != "DANG_SU_DUNG")
            {
                MessageBox.Show(
                    "Phòng không được sử dụng nên không thể checkin!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            ThongTinKhachHang customer = Phong.layThongTinHangDangThuePhong(soPhong);
            LichSuDatPhong history = LichSuDatPhong.layLichSuDatPhongTheoMaKH(customer.ma);

            if(history.thoiGianCheckin.Length != 0)
            {
                MessageBox.Show(
                    "Phòng đã được checkin!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            GUI_Checkin checkinPage = new GUI_Checkin(history.ma);
            Program.previousForm.Add(this);
            checkinPage.Show();
            this.Hide();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần checkout!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int idx = this.dataGridView1.SelectedRows[0].Index;

            int soPhong = int.Parse(this.dataGridView1.Rows[idx].Cells[0].Value.ToString());
            Phong room = Phong.layThongTinPhong(soPhong);
            if (room.trangThai != "DANG_SU_DUNG")
            {
                MessageBox.Show(
                    "Phòng không được sử dụng nên không thể checkout!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            ThongTinKhachHang customer = Phong.layThongTinHangDangThuePhong(soPhong);
            LichSuDatPhong history = LichSuDatPhong.layLichSuDatPhongTheoMaKH(customer.ma);

            if (history == null || history.thoiGianCheckin == null || history.thoiGianCheckin.Length == 0)
            {
                MessageBox.Show(
                    "Phòng chưa checkin nên không thể checkout!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (LichSuCheckout.themLichSuCheckout(history.ma, soPhong))
            {
                LichSuCheckout checkoutHistory = LichSuCheckout.layLichSuCheckout(history.ma);
                GUI_RoomStatus roomStatusPage = new GUI_RoomStatus(checkoutHistory.ma);
                Program.previousForm.Add(this);
                roomStatusPage.Show();
                this.Hide();
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
