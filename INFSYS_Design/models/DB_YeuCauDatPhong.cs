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
        public static YeuCauDatPhong layThongtinYeuCau(int maKH, int soPhong)
        {
            string makh = maKH.ToString();
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                SELECT * 
                FROM YEUCAUDATPHONG
                WHERE MAKHACHHANG={makh}
                AND MA IN (
                    SELECT MAYEUCAU
                    FROM LICHSUDATPHONG
                    WHERE SOPHONG = {soPhong}
                )
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "soDemLuuTru", "ngayDen", "ngayYeuCau", "yeuCauDacBiet", "maKhachHang", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
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

        public static int themYeuCauDatPhong(int soDemLuuTru, string ngayDen, string ngayYeuCau, string yeuCauDacBiet, int maKH, string loaiPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO YEUCAUDATPHONG (SODEMLUUTRU, NGAYDEN, NGAYYEUCAU, YEUCAUDACBIET, MAKH, LOAIPHONG) VALUES (@soDemLuuTru, @ngayDen, @ngayYeuCau, @yeuCauDacBiet, @maKH, @loaiPhong)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@soDemLuuTru", soDemLuuTru);
            sqlCmd.Parameters.AddWithValue("@ngayDen", ngayDen);
            sqlCmd.Parameters.AddWithValue("@ngayYeuCau", ngayYeuCau);
            sqlCmd.Parameters.AddWithValue("@yeuCauDacBiet", yeuCauDacBiet);
            sqlCmd.Parameters.AddWithValue("@maKH", maKH);
            sqlCmd.Parameters.AddWithValue("@loaiPhong", loaiPhong);

            return sqlCmd.ExecuteNonQuery();
        }
        public static YeuCauDatPhong layThongtinYeuCauTheoMaDatPhong(int maDatPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                SELECT * 
                FROM YEUCAUDATPHONG
                WHERE MA IN (
                    SELECT MAYEUCAU
                    FROM LICHSUDATPHONG
                    WHERE MA={maDatPhong}
                )
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "soDemLuuTru", "ngayDen", "ngayYeuCau", "yeuCauDacBiet", "maKhachHang", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
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

    }
}
