using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_DanhSachCho
    {
        public static List<DanhSachCho> layDanhSachTheoTheoLoaiPhong(string maLoaiPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                SELECT *
                FROM DANHSACHCHO
                WHERE MAYEUCAU IN (
                    SELECT MA
                    FROM YEUCAUDATPHONG 
                    WHERE LOAIPHONG = '{maLoaiPhong}'
                    AND MA NOT IN (
                        SELECT MAYEUCAU
                        FROM LICHSUDATPHONG
                    )
                )
                AND TRANGTHAI = 'DANG_CHO'
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "trangThai", "thoiGianTao", "hanChot", "nguoiThucHien", "maYeuCau" };
            SqlDataReader res = sqlCmd.ExecuteReader();

            List<DanhSachCho> waitingList = new List<DanhSachCho> { };

            while (res.Read())
            {
                Dictionary<string, object> raw_item = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    raw_item.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                DanhSachCho item = new DanhSachCho(raw_item);
                waitingList.Add(item);
            }
            return waitingList;
        }

        public static int themDanhSachCho(string deadline, int requestId, string createdTime, int userId)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = @"
                INSERT INTO DANHSACHCHO(TRANGTHAI, THOIGIANTAO, HANCHOT, NGUOITHUCHIEN, MAYEUCAU)
                VALUES (@trangThai, @thoiGianTao, @hanChot, @nguoiThucHien, @maYeuCau)
            ";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@trangThai", "DANG_CHO");
            sqlCmd.Parameters.AddWithValue("@thoiGianTao", createdTime);
            sqlCmd.Parameters.AddWithValue("@hanChot", deadline);
            sqlCmd.Parameters.AddWithValue("@nguoiThucHien", userId);
            sqlCmd.Parameters.AddWithValue("@maYeuCau", requestId);

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
