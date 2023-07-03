using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class LichSuGiaHan
    {
        public int ma;
        public DateTime ngayGiaHan;
        public DateTime thoiGianThucHien;
        public int maDatPhong;
        public int maNhanVienThucHien;

        public LichSuGiaHan(Dictionary<string, object> kwargs)
        {

            object data;

            if(kwargs.TryGetValue("MA", out data)){
                this.ma = Convert.ToInt32(data.ToString());
            }
            if (kwargs.TryGetValue("NGAYGIAHAN", out data))
            {
                this.ngayGiaHan = Convert.ToDateTime(data.ToString());
            }
            if (kwargs.TryGetValue("THOIGIANTHUCHIEN", out data))
            {
                this.thoiGianThucHien = Convert.ToDateTime(data.ToString());
            }
            if (kwargs.TryGetValue("MADATPHONG", out data))
            {
                this.maDatPhong = Convert.ToInt32(data.ToString());
            }
            if (kwargs.TryGetValue("MANHANVIENTHUCHIEN", out data))
            {
                this.maNhanVienThucHien = Convert.ToInt32(data.ToString());
            }
        }

        static public bool themLichSuGiaHan(int maDatPhong, DateTime thoiGianGiaHan)
        {

        }
    }
}
