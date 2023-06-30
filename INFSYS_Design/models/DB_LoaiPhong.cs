using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_LoaiPhong
    {
        public static LoaiPhong layThongTinLoaiPhong(string maLoaiPhong)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT TOP 1 * FROM LOAIPHONG WHERE MALOAIPHONG = '{maLoaiPhong}'";
            sqlCmd.Connection = conn.conn;

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                LoaiPhong roomType = new LoaiPhong(
                    res.GetString(0),
                    res.GetInt16(1),
                    res.GetInt16(2),
                    res.GetInt16(3),
                    res.GetInt32(4)
                );
                return roomType;
            }
            return null;
        }
    }
}
