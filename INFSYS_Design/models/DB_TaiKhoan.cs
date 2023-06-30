using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_TaiKhoan
    {
        
        public static TaiKhoan layThongTinTaiKhoan(string username)
        {
            try
            {

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandText = $"SELECT TOP 1 * FROM TAIKHOAN WHERE TAIKHOAN=\'{username}\'";
                sqlCmd.Connection = new DBConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();
                if (res.Read())
                {
                    TaiKhoan taiKhoan = new TaiKhoan(
                        res.GetInt32(0),
                        res.GetInt32(1),
                        res.GetString(2),
                        res.GetString(3)
                    );
                    return taiKhoan;
                }
                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
