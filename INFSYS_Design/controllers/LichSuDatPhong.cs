using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class LichSuDatPhong
    {
        public int ma;
        public string thoiGianTraPhongDuKien;
        public string thoiGianDat;
        public string hinhThucThanhToan;
        public int soTienDatCoc;
        public int maYeuCau;
        public string soPhong;
        public string thoiGianCheckin;
        
        public LichSuDatPhong(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("THOIGIANTRAPHONGDUKIEN", out data))
            {
                this.thoiGianTraPhongDuKien = data.ToString();
            }
            if (kwargs.TryGetValue("THOIGIANDAT", out data))
            {
                this.thoiGianDat = data.ToString();
            }
            if (kwargs.TryGetValue("HINHTHUCTHANHTOAN", out data))
            {
                this.hinhThucThanhToan = data.ToString();
            }
            if (kwargs.TryGetValue("SOTIENDATCOC", out data))
            {
                this.soTienDatCoc = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MAYEUCAU", out data))
            {
                this.maYeuCau = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("SOPHONG", out data))
            {
                this.soPhong = data.ToString();
            }
            if (kwargs.TryGetValue("THOIGIANCHECKIN", out data))
            {
                this.thoiGianCheckin = data.ToString();
            }
        }

        public LichSuDatPhong(string thoiGianTraPhongDuKien, string thoiGianDat ,string hinhThucThanhToan, int soTienDatCoc, int maYeuCau, string soPhong, string thoiGianCheckin)
        {
            this.thoiGianTraPhongDuKien = thoiGianTraPhongDuKien;
            this.thoiGianDat = thoiGianDat;
            this.hinhThucThanhToan = hinhThucThanhToan;
            this.soTienDatCoc = soTienDatCoc;
            this.maYeuCau = maYeuCau;
            this.soPhong = soPhong;
            this.thoiGianCheckin = thoiGianCheckin;
        }

        public static LichSuDatPhong layLichSuDatPhong(int soPhong, int maKH)
        {

            return DB_LichSuDatPhong.layLichSuDatPhong(soPhong,maKH);
        }

        public static bool themLichSuDatPhong(LichSuDatPhong lsdp)
        {

            return DB_LichSuDatPhong.themLichSuDatPhong(lsdp) == 1;
        }
    }
}
