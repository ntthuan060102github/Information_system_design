using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class Phong
    {
        public int soPhong;
        public string trangThai;
        public string loaiPhong;

        public Phong(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("SOPHONG", out data))
            {
                this.soPhong = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("TRANGTHAI", out data))
            {
                this.trangThai = data.ToString();
            }
            if (kwargs.TryGetValue("LOAIPHONG", out data))
            {
                this.loaiPhong = data.ToString();
            }
        }

        public static List<Phong> layDanhSachPhong()
        {
            return DB_Phong.layDanhSachPhong();
        }
    }
}
