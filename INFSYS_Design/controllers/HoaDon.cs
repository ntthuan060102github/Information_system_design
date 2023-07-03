using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class HoaDon
    {
        public int maHoaDon;
        public string thoiGianTao;
        public int VAT;
        public int chiPhiChuaThue;
        public int soTienNhan;
        public int maCheckout;


        public HoaDon(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.maHoaDon = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("THOIGIANTAO", out data))
            {
                this.thoiGianTao = data.ToString();
            }
            if (kwargs.TryGetValue("VAT", out data))
            {
                this.VAT = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("CHIPHICHUATHUE", out data))
            {
                this.chiPhiChuaThue = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("SOTIENNHAN", out data))
            {
                this.soTienNhan = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MACHECKOUT", out data))
            {
                this.maCheckout = int.Parse(data.ToString());
            }
        }

        public static HoaDon layThongTinHoaDon(int maHoaDon)
        {
            return DB_HoaDon.layThongTinHoaDon(maHoaDon);
        }
        public static HoaDon layDanhSachHoaDon()
        {
            return DB_HoaDon.layDanhSachHoaDon();
        }

        public static bool themHoaDon(HoaDon hd)
        {
            return DB_HoaDon.themHoaDon(hd) == 1;
        }
    }
}
