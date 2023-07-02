﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INFSYS_Design.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

namespace INFSYS_Design.models
{
    class DB_YeuCauDatPhong
    {
        public static YeuCauDatPhong layThongtinYeuCau(int maKH)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM YEUCAUDATPHONG WHERE MAKHACHHANG={maKH}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "soDemLuuTru", "ngayDen", "ngayYeuCau", "yeuCauDacBiet", "maKH", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();


            while (res.Read())
            {
                Dictionary<string, object> requestInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    requestInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                YeuCauDatPhong request = new YeuCauDatPhong(requestInfo);
                return request;
            }

            return null;
        }

        public static int themYeuCauDatPhong(YeuCauDatPhong yc)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO YeuCauDatPhong (SODEMLUUTRU, NGAYDEN, NGAYYEUCAU, YEUCAUDACBIET, MAKH, LOAIPHONG) VALUES (@soDemLuuTru, @ngayDen, @ngayYeuCau, @yeuCauDacBiet, @maKH, @loaiPhong)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@soDemLuuTru", yc.soDemLuuTru);
            sqlCmd.Parameters.AddWithValue("@ngayDen", yc.ngayDen);
            sqlCmd.Parameters.AddWithValue("@ngayYeuCau", yc.ngayYeuCau);
            sqlCmd.Parameters.AddWithValue("@yeuCauDacBiet", yc.yeuCauDacBiet);
            sqlCmd.Parameters.AddWithValue("@maKH", yc.maKH);
            sqlCmd.Parameters.AddWithValue("@loaiPhong", yc.loaiPhong);

            return sqlCmd.ExecuteNonQuery();
        }

    }
}
