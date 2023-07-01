using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class DanhSachCho
    {
        public int ma;
        public string trangThai;
        public DateTime thoiGianTao;
        public DateTime hanChot;
        public int nguoiThucHien;
        public int maYeuCau;

        public DanhSachCho(Dictionary<string, object> kwargs)
        {
            object data;

            if(kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("TRANGTHAI", out data))
            {
                this.trangThai = data.ToString();
            }
            if (kwargs.TryGetValue("THOIGIANTAO", out data))
            {
                this.thoiGianTao = DateTime.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("HANCHOT", out data))
            {
                this.hanChot = DateTime.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("NGUOITHUCHIEN", out data))
            {
                this.nguoiThucHien = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MAYEUCAU", out data))
            {
                this.maYeuCau = int.Parse(data.ToString());
            }
        }
        public static List<DanhSachCho> layDanhlayDanhSachTheoTheoLoaiPhong(string maLoaiPhong)
        {
            return DB_DanhSachCho.layDanhSachTheoTheoLoaiPhong(maLoaiPhong);
        }
    }
}
