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

        public HoaDon(string thoiGianTao, int VAT, int chiPhiChuaThue, int soTienNhan, int maCheckout)
        {
            this.thoiGianTao = thoiGianTao;
            this.VAT = VAT;
            this.chiPhiChuaThue = chiPhiChuaThue;
            this.soTienNhan = soTienNhan;
            this.maCheckout = maCheckout;
        }

        public static HoaDon layThongTinHoaDon(int maHoaDon)
        {
            return DB_HoaDon.layThongTinHoaDon(maHoaDon);
        }

        public static List<HoaDon> layDanhSachHoaDon()
        {
            return DB_HoaDon.layDanhSachHoaDon();
        }

        public static List<HoaDon> layDanhSachHoaDonTheoNgay(string ngayBD, string ngayKT)
        {
            return DB_HoaDon.layDanhSachHoaDonTheoNgay(ngayBD, ngayKT);
        }
    }
}
