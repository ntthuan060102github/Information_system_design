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
    class DB_LichSuDatPhong
    {
        public static LichSuDatPhong layLichSuDatPhongTheoMaYeuCau(int maYeuCau)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM LICHSUDATPHONG WHERE MAYEUCAU = {maYeuCau}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin"};
            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> lichSu = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    lichSu.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong lsdp = new LichSuDatPhong(lichSu);
                return lsdp;
            }
            return null;
        }
        public static LichSuDatPhong layLichSuDatPhong(int ma)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM LICHSUDATPHONG WHERE MA = {ma}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin" };
            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> lichSu = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    lichSu.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong lsdp = new LichSuDatPhong(lichSu);
                return lsdp;
            }
            return null;
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

        public static int capNhatThoiGianCheckin(int maDatPhong, string thoiGianCheckin)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                UPDATE LICHSUDATPHONG 
                SET THOIGIANCHECKIN = '{thoiGianCheckin}' 
                WHERE MA={maDatPhong}
                AND THOIGIANCHECKIN IS NULL
            ";
            sqlCmd.Connection = conn.conn;

            return sqlCmd.ExecuteNonQuery();
        }

        public static LichSuDatPhong layLichSuDatPhongTheoSoPhong(int soPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                    SELECT *
                    FROM LICHSUDATPHONG 
                    WHERE SOPHONG = {soPhong}
                    AND MA NOT IN (
                        SELECT MADATPHONG
                        FROM LICHSUCHECKOUT
                    )            
                ",
                Connection = conn.conn
            };

            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin" };
            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> lichSu = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    lichSu.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong lsdp = new LichSuDatPhong(lichSu);
                return lsdp;
            }
            return null;
        }
        public static LichSuDatPhong layLichSuDatPhongTheoMaKH(int maKh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                    SELECT *
                    FROM LICHSUDATPHONG 
                    WHERE MA IN (
                        SELECT MAKHACHHANG
                        FROM YEUCAUDATPHONG
                        WHERE MAKHACHHANG = {maKh}
                    )            
                ",
                Connection = conn.conn
            };

            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin" };
            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> lichSu = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    lichSu.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong lsdp = new LichSuDatPhong(lichSu);
                return lsdp;
            }
            return null;
        }
    }
}
