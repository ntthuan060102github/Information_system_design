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
    }
}
