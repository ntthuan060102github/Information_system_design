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

        public static bool themKhachHang(ThongTinKhachHang kh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO THONGTINKHACHHANG ( MASODINHDANH, LOAIMASODINHDANH, EMAIL, NAMSINH, HOTEN, SDT, DIACHITHUONGTRU, GIOITINH) VALUES (@maSoDinhDanh, @loaiMaSoDinhDanh, @email, @namSinh, @hoTen, @sdt, @diaChiThuongTru, @gioiTinh)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@maSoDinhDanh", kh.maSoDinhDanh);
            sqlCmd.Parameters.AddWithValue("@loaiMaSoDinhDanh", kh.loaiMaSoDinhDanh);
            sqlCmd.Parameters.AddWithValue("@email", kh.email);
            sqlCmd.Parameters.AddWithValue("@namSinh", kh.namSinh);
            sqlCmd.Parameters.AddWithValue("@hoTen", kh.hoTen);
            sqlCmd.Parameters.AddWithValue("@sdt", kh.sdt);
            sqlCmd.Parameters.AddWithValue("@diaChiThuongTru", kh.diaChiThuongTru);
            sqlCmd.Parameters.AddWithValue("@gioiTinh", kh.gioiTinh);

            try
            {
                // Thực thi câu lệnh SQL insert
                int rowsAffected = sqlCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    //chèn dữ liệu thành công
                    return true;
                }
                else
                {
                    //chèn dữ liệu thất bại
                    return false;
                }
            }
            catch    
            {
                //lỗi ngoại lệ
                return false;
            }
        }

    }
}
