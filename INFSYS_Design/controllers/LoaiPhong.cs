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

        public LoaiPhong(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MALOAIPHONG", out data))
            {
                this.maLoaiPhong = data.ToString();
            }
            if (kwargs.TryGetValue("HANGPHONG", out data))
            {
                this.hangPhong = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("SOGIUONG", out data))
            {
                this.soGiuong = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("LOAIGIUONG", out data))
            {
                this.loaiGiuong = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("GIA", out data))
            {
                this.gia = int.Parse(data.ToString());
            }
        }

        public static LoaiPhong layThongTinLoaiPhong(string maLoaiPhong)
        {
            return DB_LoaiPhong.layThongTinLoaiPhong(maLoaiPhong);
        }
        public static List<LoaiPhong> layDanhSachLoaiPhong()
        {
            return DB_LoaiPhong.layDanhSachLoaiPhong();
        }
    }
}
