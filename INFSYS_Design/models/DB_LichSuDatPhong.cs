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
    class DB_LichSuDatPhong
    {
        public static List<LichSuDatPhong> layLichSuDatPhong(int soPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM LICHSUDATPHONG WHERE SOPHONG = {soPhong}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin"};

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<LichSuDatPhong> ds = new List<LichSuDatPhong>();
            while (res.Read())
            {
                Dictionary<string, object> lichSu = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    lichSu.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong lsdp = new LichSuDatPhong(lichSu);
                ds.Add(lsdp);
            }

            return ds;
        }

        public static int themLichSuDatPhong(LichSuDatPhong lsdp)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO LICHSUDATPHONG (THOIGIANTRAPHONGDUKIEN, THOIGIANDAT, HINHTHUCTHANHTOAN, SOTIENDATCOC, MAYEUCAU, SOPHONG) VALUES (@thoiGianTraPhongDuKien, @thoiGianDat, @hinhThucThanhToan, @soTienDatCoc, @maYeuCau, @soPhong)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@thoiGianTraPhongDuKien", lsdp.thoiGianTraPhongDuKien);
            sqlCmd.Parameters.AddWithValue("@thoiGianDat", lsdp.thoiGianDat);
            sqlCmd.Parameters.AddWithValue("@hinhThucThanhToan", lsdp.hinhThucThanhToan);
            sqlCmd.Parameters.AddWithValue("@soTienDatCoc", lsdp.soTienDatCoc);
            sqlCmd.Parameters.AddWithValue("@maYeuCau", lsdp.maYeuCau);
            sqlCmd.Parameters.AddWithValue("@soPhong", lsdp.soPhong);

            return sqlCmd.ExecuteNonQuery();
        }

        public static int capNhatLichSuDatPhong(string soPhong, int maYeuCau)
        {
            DateTime date = DateTime.Today;
            string ngayCheckin = date.ToString("dd/MM/yyyy");
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"UPDATE LICHSUDATPHONG SET THOIGIANCHECKIN = {ngayCheckin} WHERE MAYEUCAU={maYeuCau} AND SOPHONG = {soPhong}";
            sqlCmd.Connection = conn.conn;

            return sqlCmd.ExecuteNonQuery();
        }

    }
}
