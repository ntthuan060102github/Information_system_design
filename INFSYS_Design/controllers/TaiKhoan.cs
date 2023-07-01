using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class TaiKhoan
    {
        private int id, manv;
        private string taikhoan;
        public string matkhau;
        public TaiKhoan(int id, int maNv, string taiKhoan, string matKhau)
        {
            this.taikhoan = taiKhoan;
            this.matkhau = matKhau;
            this.id = id;
            this.manv = maNv;
        }

        public static bool DangNhap(string taikhoan, string matkhau)
        {
            TaiKhoan taiKhoan = DB_TaiKhoan.layThongTinTaiKhoan(taikhoan);
            if (taiKhoan == null)
            {
                return false;
            }
            if (matkhau == taiKhoan.matkhau)
            {
                NhanVien userInfo = NhanVien.layThongTinNhanVien(taiKhoan.manv);
                Program.currentUserId = taiKhoan.manv;
                Program.currentUserRole = userInfo.chucVu;
                return true;
            }
            return false;
        }
    }
}
