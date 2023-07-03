using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_HoaDon
    {
        public static HoaDon layThongTinHoaDon(int maHoaDon)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM HOADON WHERE MA = {maHoaDon}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maHoaDon", "thoiGianTao", "VAT", "chiPhiChuaThue", "soTienNhan", "maCheckout" };
            
            SqlDataReader res = sqlCmd.ExecuteReader();


            if (res.Read())
            {
                Dictionary<string, object> dtgRevenue = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    dtgRevenue.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                HoaDon HoaDon = new HoaDon(dtgRevenue);
                return HoaDon;
            }
            return null;
        }
        public static HoaDon layDanhSachHoaDon()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM HOADON";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maHoaDon", "thoiGianTao", "VAT", "chiPhiChuaThue", "soTienNhan", "maCheckout" };

            SqlDataReader res = sqlCmd.ExecuteReader();


            if (res.Read())
            {
                Dictionary<string, object> empDict = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    empDict.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                HoaDon HoaDon = new HoaDon(empDict);
                return HoaDon;
            }
            return null;
        }
        public static int themHoaDon(HoaDon hd)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO HOADON(THOIGIANTAO, VAT, CHIPHICHUATHUE, SOTIENNHAN, MACHECKOUT)
                VALUES('{hd.thoiGianTao}', {hd.VAT}, {hd.chiPhiChuaThue},{hd.soTienNhan}, {hd.maCheckout})",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
