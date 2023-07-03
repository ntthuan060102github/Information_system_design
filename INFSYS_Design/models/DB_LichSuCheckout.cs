using INFSYS_Design.controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFSYS_Design.models
{
    class DB_LichSuCheckout
    {
        public static int themLichSuCheckout(LichSuCheckout c)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO LICHSUCHECKOUT(THOIGIANTHUCHIEN, MADATPHONG, NGUOITHUCHIEN)
                VALUES('{c.thoiGianThucHien}', {c.maDatPhong}, {c.nguoiThucHien})",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
