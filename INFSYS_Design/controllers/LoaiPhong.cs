using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class LoaiPhong
    {
        public string maLoaiPhong;
        public int hangPhong;
        public int soGiuong;
        public int loaiGiuong;
        public int gia;

        public LoaiPhong(string maLoaiPhong, int hangPhong, int soGiuong, int loaiGiuong, int gia)
        {
            this.maLoaiPhong = maLoaiPhong;
            this.hangPhong = hangPhong;
            this.soGiuong = soGiuong;
            this.loaiGiuong = loaiGiuong;
            this.gia = gia;
        }

        public static LoaiPhong layThongTinLoaiPhong(string maLoaiPhong)
        {
            return DB_LoaiPhong.layThongTinLoaiPhong(maLoaiPhong);
        }
    }
}
