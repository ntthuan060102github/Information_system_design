using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class DanhSachTour
    {
        public int ma;
        public string tenTour;
        public string moTa;
        public DateTime thoiGianBatDau;
        public DateTime thoiGianKetThuc;
        public string loaiDichVu;
        public string donViLuHanh;

        public DanhSachTour(Dictionary<string, object> kwargs)
        {
            object data;

            if(kwargs.TryGetValue("MA", out data))
            {
                this.ma = Convert.ToInt32(data.ToString());
            }
            if (kwargs.TryGetValue("TENTOUR", out data))
            {
                this.tenTour = data.ToString();
            }
            if (kwargs.TryGetValue("MOTA", out data))
            {
                this.moTa = data.ToString();
            }
            if (kwargs.TryGetValue("THOIGIANBATDAU", out data))
            {
                this.thoiGianBatDau = Convert.ToDateTime(data.ToString());
            }
            if (kwargs.TryGetValue("THOIGIANKETTHUC", out data))
            {
                this.thoiGianKetThuc = Convert.ToDateTime(data.ToString());
            }
            if (kwargs.TryGetValue("LOAIDICHVU", out data))
            {
                this.loaiDichVu = data.ToString();
            }
            if (kwargs.TryGetValue("DONVILUHANH", out data))
            {
                this.donViLuHanh = data.ToString();
            }
        }

        public static List<DanhSachTour> layDanhSachTour()
        {
            return DB_DanhSachTour.layDanhSachTour();
        }
        public static bool xoaTour(int maTour)
        {
            return DB_DanhSachTour.xoaTour(maTour) == 1;
        }
        public static bool themTour(string tenTour, string moTa, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string loaiTour, string donViLuHanh)
        {
            return DB_DanhSachTour.themTour(
                tenTour, 
                moTa,
                thoiGianBatDau.Date.ToString("MM/dd/yyyy"),
                thoiGianKetThuc.Date.ToString("MM/dd/yyyy"),
                loaiTour,
                donViLuHanh
            ) == 1;
        }
        public static bool suaTour(int maTour, string tenTour, string moTa, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string loaiTour, string donViLuHanh)
        {
            return DB_DanhSachTour.suaTour(
                maTour,
                tenTour,
                moTa,
                thoiGianBatDau.Date.ToString("MM/dd/yyyy"),
                thoiGianKetThuc.Date.ToString("MM/dd/yyyy"),
                loaiTour,
                donViLuHanh
            ) == 1;
        }
    }
}
