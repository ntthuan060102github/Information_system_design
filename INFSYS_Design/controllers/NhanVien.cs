using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class NhanVien
    {
        public int maNv;
        public string hoTen;
        public string chucVu;
        public string ngaySinh;
        public int gioiTinh;
        public string email;
        public string sdt;
        public string diaChi;
        public int trangThaiLamViec;
        public string maSoDinhDanh;
        public string loaiMaSoDinhDanh;

        public NhanVien(Dictionary<string, object> kwargs)
        {
            object data;

            if(kwargs.TryGetValue("MANV", out data))
            {
                this.maNv = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("HOTEN", out data))
            {
                this.hoTen = data.ToString();
            }
            if (kwargs.TryGetValue("CHUCVU", out data))
            {
                this.chucVu = data.ToString();
            }
            if (kwargs.TryGetValue("NGAYSINH", out data))
            {
                this.ngaySinh = data.ToString();
            }
            if (kwargs.TryGetValue("GIOITINH", out data))
            {
                this.gioiTinh = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("EMAIL", out data))
            {
                this.email = data.ToString();
            }
            if (kwargs.TryGetValue("SDT", out data))
            {
                this.sdt = data.ToString();
            }
            if (kwargs.TryGetValue("DIACHI", out data))
            {
                this.diaChi = data.ToString();
            }
            if (kwargs.TryGetValue("TRANGTHAILAMVIEC", out data))
            {
                this.trangThaiLamViec = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MASODINHDANH", out data))
            {
                this.maSoDinhDanh = data.ToString();
            }
            if (kwargs.TryGetValue("LOAIMASODINHDANH", out data))
            {
                this.loaiMaSoDinhDanh = data.ToString();
            }
        }

        public static NhanVien layThongTinNhanVien(int maNv)
        {
            return DB_NhanVien.layThongTinNhanVien(maNv);
        }
        public static NhanVien layThongTinNhanVien()
        {
            return DB_NhanVien.layThongTinNhanVien(Program.currentUserId);
        }
    }
}
