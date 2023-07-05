﻿using INFSYS_Design.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFSYS_Design.controllers
{
    internal class LichSuCheckout
    {
        public int ma;
        public string thoiGianThucHien;
        public int maDatPhong;
        public int nguoiThucHien;

        public LichSuCheckout(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("THOIGIANTHUCHIEN", out data))
            {
                this.thoiGianThucHien = data.ToString();
            }
            if (kwargs.TryGetValue("MADATPHONG", out data))
            {
                this.maDatPhong = int.Parse(data.ToString());
            }            
            if (kwargs.TryGetValue("NGUOITHUCHIEN", out data))
            {
                this.nguoiThucHien = int.Parse(data.ToString());
            }
        }

        public static bool themLichSuCheckout(int maDatPhong, int soPhong)
        {
            DateTime now = DateTime.Now;
            bool check = DB_LichSuCheckout.themLichSuCheckout(maDatPhong, now.ToString(), Program.currentUserId) == 1;
            if (check)
            {
                return Phong.capNhatTrangThai(soPhong, "TRONG");
            }
            return false;
        }
        public static LichSuCheckout layLichSuCheckout(int maDatPhong)
        {
            return DB_LichSuCheckout.layLichSuCheckout(maDatPhong);
        }
    }
}
