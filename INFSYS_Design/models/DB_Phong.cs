using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_Phong
    {
        public static List<Phong> layDanhSachPhong()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM PHONG";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "soPhong", "trangThai", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<Phong> list_of_rooms = new List<Phong>();

            while (res.Read())
            {
                Dictionary<string, object> raw_room = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_room.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                Phong room = new Phong(raw_room);
                list_of_rooms.Add(room);
            }
            return list_of_rooms;
        }
        public static int xoaPhong(int soPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"DELETE FROM PHONG WHERE SOPHONG = {soPhong}";
            sqlCmd.Connection = conn.conn;

            int res = sqlCmd.ExecuteNonQuery();

            return res;
        }
        public static Phong layThongTinPhong(int soPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM PHONG WHERE SOPHONG = {soPhong}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "soPhong", "trangThai", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> raw_room = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_room.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                Phong room = new Phong(raw_room);
                return room;
            }
            return null;
        }
        public static ThongTinKhachHang layThongTinKhachHangDangThuePhong(int soPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                SELECT TOP 1 *
                FROM THONGTINKHACHHANG
                WHERE MA in (
                    SELECT YC.MAKHACHHANG
                    FROM YEUCAUDATPHONG YC
                    JOIN LICHSUDATPHONG LS
                    ON YC.MA = LS.MAYEUCAU
                    WHERE LS.MA NOT IN(
                        SELECT MADATPHONG
                        FROM LICHSUCHECKOUT
                    )
                    AND LS.SOPHONG = {soPhong}
                )
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
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
        public static DateTime layThoiGianTraPhong(int soPhong)
        {
            return DateTime.Now;
            /*DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                    SELECT YC.MAKHACHHANG
                    FROM LICHSUDATPHONG LS
                    JOIN LICHSUGIAHAN GH
                    ON LS.MA = GH.MADATPHONG
                    WHERE LS.MA NOT IN(
                        SELECT MADATPHONG
                        FROM LICHSUCHECKOUT
                    )
                    AND LS.SOPHONG = {soPhong}
                )
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "maSoDinhDanh", "loaiMaSoDinhDanh", "email", "namSinh", "hoTen", "sdt", "diaChiThuongTru", "gioiTinh" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                ThongTinKhachHang customer = new ThongTinKhachHang(customerInfo);
                return customer;
            }
            return null;*/
        }
        public static int themPhong(int soPhong, string maLoaiPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                INSERT INTO PHONG(SOPHONG, LOAIPHONG, TRANGTHAI)
                VALUES({soPhong}, '{maLoaiPhong}', 'TRONG')
            ";
            sqlCmd.Connection = conn.conn;

            return sqlCmd.ExecuteNonQuery();
        }

        public static List<Phong> layDanhSachPhongTrongTheoLoaiPhong(string loaiphong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM PHONG WHERE LOAIPHONG = '{loaiphong}' AND TRANGTHAI = 'TRONG'";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "soPhong", "trangThai", "loaiPhong" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<Phong> list_of_rooms = new List<Phong>();

            while (res.Read())
            {
                Dictionary<string, object> raw_room = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_room.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                Phong room = new Phong(raw_room);
                list_of_rooms.Add(room);
            }
            return list_of_rooms;
        }
        public static int capNhatTrangThai(int soPhong, string status)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                UPDATE PHONG
                SET TRANGTHAI = '{status}'
                WHERE SOPHONG = {soPhong}
            ";
            sqlCmd.Connection = conn.conn;

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
