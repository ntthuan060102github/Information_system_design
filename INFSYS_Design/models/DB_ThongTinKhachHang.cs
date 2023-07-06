using System;
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
        public static ThongTinKhachHang layThongtinKhachHang(int ma)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM THONGTINKHACHHANG WHERE MA={ma}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            SqlDataReader res = sqlCmd.ExecuteReader();


            while (res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                ThongTinKhachHang customer = new ThongTinKhachHang(customerInfo);
                return customer;
            }

            return null;
        }

        public static ThongTinKhachHang layThongtinKhachHangTheoTen(string hoTen)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM THONGTINKHACHHANG WHERE HOTEN={hoTen}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            SqlDataReader res = sqlCmd.ExecuteReader();


            while (res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                ThongTinKhachHang customer = new ThongTinKhachHang(customerInfo);
                return customer;
            }

            return null;
        }

        public static int themKhachHang(string customerId, string email, int yearOfBirth, string fullName, string phone, string address, int gender)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO THONGTINKHACHHANG ( MASODINHDANH, LOAIMASODINHDANH, EMAIL, NAMSINH, HOTEN, SDT, DIACHITHUONGTRU, GIOITINH) output INSERTED.MA VALUES (@maSoDinhDanh, @loaiMaSoDinhDanh, @email, @namSinh, @hoTen, @sdt, @diaChiThuongTru, @gioiTinh)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@maSoDinhDanh", customerId);
            sqlCmd.Parameters.AddWithValue("@loaiMaSoDinhDanh", "CCCD");
            sqlCmd.Parameters.AddWithValue("@email", email);
            sqlCmd.Parameters.AddWithValue("@namSinh", yearOfBirth);
            sqlCmd.Parameters.AddWithValue("@hoTen", fullName);
            sqlCmd.Parameters.AddWithValue("@sdt", phone);
            sqlCmd.Parameters.AddWithValue("@diaChiThuongTru", address);
            sqlCmd.Parameters.AddWithValue("@gioiTinh", gender);

            return sqlCmd.ExecuteScalar();
        }

        public static ThongTinKhachHang layTTKhachHang(ThongTinKhachHang kh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM THONGTINKHACHHANG WHERE MASODINHDANH = @maSoDinhDanh AND LOAIMASODINHDANH = @loaiMaSoDinhDanh AND EMAIL = @email AND NAMSINH = @namSinh AND HOTEN=@hoTen AND SDT = @sdt AND DIACHITHUONGTRU = @diaChiThuongTru AND GIOITINH = @gioiTinh";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            sqlCmd.Parameters.AddWithValue("@maSoDinhDanh", kh.maSoDinhDanh);
            sqlCmd.Parameters.AddWithValue("@loaiMaSoDinhDanh", kh.loaiMaSoDinhDanh);
            sqlCmd.Parameters.AddWithValue("@email", kh.email);
            sqlCmd.Parameters.AddWithValue("@namSinh", kh.namSinh);
            sqlCmd.Parameters.AddWithValue("@hoTen", kh.hoTen);
            sqlCmd.Parameters.AddWithValue("@sdt", kh.sdt);
            sqlCmd.Parameters.AddWithValue("@diaChiThuongTru", kh.diaChiThuongTru);
            sqlCmd.Parameters.AddWithValue("@gioiTinh", kh.gioiTinh);


            SqlDataReader res = sqlCmd.ExecuteReader();


            while (res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                ThongTinKhachHang customer = new ThongTinKhachHang(customerInfo);
                return customer;
            }

            return null;
        }
    }
}
