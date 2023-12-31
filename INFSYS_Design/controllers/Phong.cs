﻿using System;
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
        public static bool xoaPhong(int soPhong)
        {
            return 0 != DB_Phong.xoaPhong(soPhong);
        }
        public static List<Phong> layDanhSachPhongDangSuDung()
        {
            return DB_Phong.layDanhSachPhongDangSuDung();
        }
        public static Phong layThongTinPhong(int soPhong)
        {
            return DB_Phong.layThongTinPhong(soPhong);
        }
        public static ThongTinKhachHang layThongTinHangDangThuePhong(int soPhong)
        {
            return DB_Phong.layThongTinKhachHangDangThuePhong(soPhong);
        }
        public static DateTime layThoiGianTraPhong(int soPhong)
        {
            return DB_Phong.layThoiGianTraPhong(soPhong);
        }
        public static bool kiemTraSoPhongDaTonTai(int soPhong)
        {
            return DB_Phong.layThongTinPhong(soPhong) != null;
        }
        public static bool themPhong(int soPhong, string maLoaiPhong)
        {
            return DB_Phong.themPhong(soPhong, maLoaiPhong) == 1;
        }
        public static List<Phong> layDanhSachPhongTrongTheoLoaiPhong(string loaiphong)
        {
            return DB_Phong.layDanhSachPhongTrongTheoLoaiPhong(loaiphong);
        }
        public static bool capNhatTrangThai(int soPhong, string status)
        {
            return DB_Phong.capNhatTrangThai(soPhong, status) == 1;
        }
    }
}
