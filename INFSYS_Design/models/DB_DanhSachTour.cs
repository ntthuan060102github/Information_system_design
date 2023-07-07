using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_DanhSachTour
    {
        public static List<DanhSachTour> layDanhSachTour()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM DANHSACHTOUR";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "tenTour", "moTa", "thoiGianBatDau", "thoiGianKetThuc", "loaiDichVu", "donViLuHanh" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            List<DanhSachTour> list_of_tours = new List<DanhSachTour>();

            while (res.Read())
            {
                Dictionary<string, object> raw_tour = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_tour.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                DanhSachTour tour = new DanhSachTour(raw_tour);
                list_of_tours.Add(tour);
            }
            return list_of_tours;
        }
        public static int xoaTour(int maTour)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $"DELETE FROM DANHSACHTOUR WHERE MA = {maTour}",
                Connection = conn.conn
            };

            int res = sqlCmd.ExecuteNonQuery();

            return res;
        }
        public static int themTour(string tenTour, string moTa, string thoiGianBatDau, string thoiGianKetThuc, string loaiTour, string donViLuHanh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO DANHSACHTOUR(TENTOUR, MOTA, THOIGIANBATDAU, THOIGIANKETTHUC, LOAIDICHVU, DONVILUHANH)
                VALUES(N'{tenTour}', N'{moTa}', '{thoiGianBatDau}', '{thoiGianKetThuc}', N'{loaiTour}', N'{donViLuHanh}')",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
        public static int suaTour(int maTour, string tenTour, string moTa, string thoiGianBatDau, string thoiGianKetThuc, string loaiTour, string donViLuHanh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                        UPDATE DANHSACHTOUR
                        SET TENTOUR = N'{tenTour}', 
                            MOTA = N'{moTa}', 
                            THOIGIANBATDAU = '{thoiGianBatDau}', 
                            THOIGIANKETTHUC = '{thoiGianKetThuc}', 
                            LOAIDICHVU = N'{loaiTour}', 
                            DONVILUHANH = N'{donViLuHanh}'
                        WHERE MA = {maTour};
                    ",
                Connection = conn.conn
            };
            Console.WriteLine(sqlCmd.CommandText);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
