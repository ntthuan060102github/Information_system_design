using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;

namespace INFSYS_Design.models
{
    class DB_DichVu
    {
        public static List<DichVu> layDanhSachDichVu()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM DICHVU";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "tenDichVu", "moTa", "loaiDichVu", "gia" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<DichVu> list_of_services = new List<DichVu>();

            while (res.Read())
            {
                Dictionary<string, object> raw_service = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_service.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                DichVu service = new DichVu(raw_service);
                list_of_services.Add(service);
            }
            return list_of_services;
        }

        public static DichVu layThongTinDichVu(int ma)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM DICHVU WHERE MA = {ma}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "tenDichVu", "moTa", "loaiDichVu", "gia" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> raw_service = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_service.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                DichVu service = new DichVu(raw_service);
                return service;
            }
            return null;
        }

        public static int themDichVu(string tenDichVu, string moTa, string loaiDichVu, int gia)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO DICHVU(TENDICHVU, MOTA, LOAIDICHVU, GIA)
                VALUES(N'{tenDichVu}', N'{moTa}', N'{loaiDichVu}',{gia})",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }

        public static int xoaDichVu(int ma)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $"DELETE FROM DICHVU WHERE MA = {ma}",
                Connection = conn.conn
            };

            int res = sqlCmd.ExecuteNonQuery();

            return res;
        }

        public static int suaDichVu(int ma,string tenDichVu, string moTa, string loaiDichVu, int gia)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                UPDATE DICHVU
                SET TENDICHVU = N'{tenDichVu}', MOTA = N'{moTa}', LOAIDICHVU = N'{loaiDichVu}', GIA = {gia}
                WHERE MA = {ma}",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
