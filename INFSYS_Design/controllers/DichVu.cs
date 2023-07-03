using INFSYS_Design.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFSYS_Design.controllers
{
    class DichVu
    {
        public int ma;
        public string tenDichVu;
        public string moTa;
        public string loaiDichVu;
        public int gia;
        
        public DichVu(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("TENDICHVU", out data))
            {
                this.tenDichVu = data.ToString();
            }
            if (kwargs.TryGetValue("MOTA", out data))
            {
                this.moTa = data.ToString();
            }
            if(kwargs.TryGetValue("LOAIDICHVU", out data))
            {
                this.loaiDichVu = data.ToString();
            }
            if (kwargs.TryGetValue("GIA", out data))
            {
                this.gia = int.Parse(data.ToString());
            }
        }
        public static List<DichVu> layDanhSachDichVu()
        {
            return DB_DichVu.layDanhSachDichVu();
        }

        public static DichVu layThongTinDichVu(int ma)
        {
            return DB_DichVu.layThongTinDichVu(ma);
        }
        public static bool themDichVu(string tenDichVu, string moTa, string loaiDichVu, int gia)
        {
            return DB_DichVu.themDichVu(tenDichVu, moTa, loaiDichVu, gia) == 1;
        }

        public static bool xoaDichVu(int ma)
        {
            return 0 != DB_DichVu.xoaDichVu(ma);
        }

        public static bool suaDichVu(int ma, string tenDichVu, string moTa, string loaiDichVu, int gia)
        {
            return DB_DichVu.suaDichVu(ma, tenDichVu, moTa, loaiDichVu, gia) == 1;
        }

        
    }
}
