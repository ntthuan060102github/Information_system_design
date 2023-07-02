using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;
using System.Windows.Documents;

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
        public static List<HoaDon> layDanhSachHoaDon()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM HOADON";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maHoaDon", "thoiGianTao", "VAT", "chiPhiChuaThue", "soTienNhan", "maCheckout" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<HoaDon> ds = new List<HoaDon>();
            if (res.Read())
            {
                Dictionary<string, object> empDict = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    empDict.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                HoaDon HoaDon = new HoaDon(empDict);
                ds.Add(HoaDon);
            }
            return ds;
        }
        public static List<HoaDon> layDanhSachHoaDonTheoNgay(string ngayBD, string ngayKT)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM HOADON WHERE NGAYTAO BETWEEN {ngayBD} AND {ngayKT}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maHoaDon", "thoiGianTao", "VAT", "chiPhiChuaThue", "soTienNhan", "maCheckout" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<HoaDon> ds = new List<HoaDon>();
            if (res.Read())
            {
                Dictionary<string, object> empDict = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    empDict.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                HoaDon HoaDon = new HoaDon(empDict);
                ds.Add(HoaDon);
            }
            return ds;
        }
    }

    
}
