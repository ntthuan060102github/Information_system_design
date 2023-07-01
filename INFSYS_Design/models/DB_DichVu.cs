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
    }
}
