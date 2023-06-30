using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INFSYS_Design.controllers;

namespace INFSYS_Design.models
{
    class DB_ThongTinKhachHang
    {
        public static List<ThongTinKhachHang> layDanhSachKhachHang()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM THONGTINKHACHHANG";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<ThongTinKhachHang> list_of_customers = new List<ThongTinKhachHang>();
            
            while(res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                ThongTinKhachHang customer = new ThongTinKhachHang(customerInfo);
                list_of_customers.Add(customer);
            }

            return list_of_customers;
        }
    }
}
