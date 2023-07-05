using INFSYS_Design.controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;

namespace INFSYS_Design.models
{
    class DB_LichSuCheckout
    {
        public static int themLichSuCheckout(int maDatPhong, string thoiGianThucHien, int nguoiThucHien)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO LICHSUCHECKOUT(THOIGIANTHUCHIEN, MADATPHONG, NGUOITHUCHIEN)
                VALUES('{thoiGianThucHien}', {maDatPhong}, {nguoiThucHien})",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
        public static LichSuCheckout layLichSuCheckout(int maDatPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                SELECT * 
                FROM LICHSUCHECKOUT
                WHERE MADATPHONG={maDatPhong}
            ";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "thoiGianThucHien", "maDatPhong", "nguoiThucHien" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> historyInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    historyInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuCheckout history = new LichSuCheckout(historyInfo);
                return history;
            }

            return null;
        }
    }
}
