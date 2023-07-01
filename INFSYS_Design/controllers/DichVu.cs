using INFSYS_Design.models;
using System;
using System.Collections.Generic;
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
    }
}
