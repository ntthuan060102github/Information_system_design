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
    public partial class GUI_Checkout : Form
    {
        public GUI_Checkout()
        {
            InitializeComponent();
            List<Phong> list_of_rooms = Phong.layDanhSachPhong();
            foreach (Phong room in list_of_rooms)
            {
                LoaiPhong room_type = LoaiPhong.layThongTinLoaiPhong(room.loaiPhong);

                this.dataGridView1.Rows.Add(
                    room.soPhong,
                    chuyenDoiTrangThai(room.trangThai),
                    room_type.hangPhong == 1 ? "Thường" : "Cao cấp",
                    room_type.soGiuong,
                    room_type.loaiGiuong == 1 ? "Giường đơn" : "Giường đôi"
                    //room_type.gia
                );
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            GUI_RoomStatus roomStatus = new GUI_RoomStatus();
            roomStatus.ShowDialog();
            this.Close();
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

        private void checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
