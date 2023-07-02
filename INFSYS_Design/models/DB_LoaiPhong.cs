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
            string[] columnNames = { "maLoaiPhong", "hangPhong", "soGiuong", "loaiGiuong", "gia" };

            SqlDataReader res = sqlCmd.ExecuteReader();

            if (res.Read())
            {
                Dictionary<string, object> typeRoomInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    typeRoomInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LoaiPhong typeRoom = new LoaiPhong(typeRoomInfo);
                return typeRoom;
            }
            return null;
        }
        public static List<LoaiPhong> layDanhSachLoaiPhong()
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM LOAIPHONG";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maLoaiPhong", "hangPhong", "soGiuong", "loaiGiuong", "gia"};

            SqlDataReader res = sqlCmd.ExecuteReader();
            List<LoaiPhong> list_of_type_rooms = new List<LoaiPhong>();

            while (res.Read())
            {
                Dictionary<string, object> typeRoomInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    typeRoomInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LoaiPhong typeRoom = new LoaiPhong(typeRoomInfo);
                list_of_type_rooms.Add(typeRoom);
            }

            return list_of_type_rooms;
        }
    }
}
