using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class ThongTinKhachHang
    {
        public int ma;
        public string maSoDinhDanh;
        public string loaiMaSoDinhDanh;
        public string email;
        public int namSinh;
        public string hoTen;
        public string sdt;
        public string diaChiThuongTru;
        public int gioiTinh;

        public ThongTinKhachHang(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MASODINHDANH", out data))
            {
                this.maSoDinhDanh = data.ToString();
            }
            if (kwargs.TryGetValue("LOAIMASODINHDANH", out data))
            {
                this.loaiMaSoDinhDanh = data.ToString();
            }
            if (kwargs.TryGetValue("EMAIL", out data))
            {
                this.email = data.ToString();
            }
            if (kwargs.TryGetValue("NAMSINH", out data))
            {
                this.namSinh = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("HOTEN", out data))
            {
                this.hoTen = data.ToString();
            }
            if (kwargs.TryGetValue("SDT", out data))
            {
                this.sdt = data.ToString();
            }
            if (kwargs.TryGetValue("DIACHITHUONGTRU", out data))
            {
                this.diaChiThuongTru = data.ToString();
            }
            if (kwargs.TryGetValue("GIOITINH", out data))
            {
                this.gioiTinh = int.Parse(data.ToString());
            }
        }

        public static List<ThongTinKhachHang> layDanhSachKhachHang()
        {
            List<ThongTinKhachHang> dataset = DB_ThongTinKhachHang.layDanhSachKhachHang();

            return dataset;
        }
        public static ThongTinKhachHang layThongTinKhachHang(int ma)
        {

            return DB_ThongTinKhachHang.layThongtinKhachHang(ma);
        }

        public static ThongTinKhachHang layThongTinKhachHangTheoTen(string hoTen)
        {

            return DB_ThongTinKhachHang.layThongtinKhachHangTheoTen(hoTen);
        }

        public static void themKhachHang(ThongTinKhachHang kh)
        {

            DB_ThongTinKhachHang.themKhachHang(kh);
        }
    }
}
