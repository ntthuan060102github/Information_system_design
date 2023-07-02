﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.models;

namespace INFSYS_Design.controllers
{
    class YeuCauDatPhong
    {
        public int ma;
        public int soDemLuuTru;
        public string ngayDen;
        public string ngayYeuCau;
        public string yeuCauDacBiet;
        public int maKH;
        public string loaiPhong;

        public YeuCauDatPhong(Dictionary<string, object> kwargs)
        {
            object data;

            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("SODEMLUTRU", out data))
            {
                this.soDemLuuTru = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("NGAYDEN", out data))
            {
                this.ngayDen = data.ToString();
            }
            if (kwargs.TryGetValue("NGAYYEUCAU", out data))
            {
                this.ngayYeuCau = data.ToString();
            }
            if (kwargs.TryGetValue("YEUCAUDACBIET", out data))
            {
                this.yeuCauDacBiet = data.ToString();
            }
            if (kwargs.TryGetValue("MAKHACHHANG", out data))
            {
                this.maKH = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("LOAIPHONG", out data))
            {
                this.loaiPhong = data.ToString();
            }
        }

        public static bool themYeuCauDatPhong(YeuCauDatPhong yc)
        {

            return DB_YeuCauDatPhong.themYeuCauDatPhong(yc);
        }
    }
}
