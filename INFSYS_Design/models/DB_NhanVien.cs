using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFSYS_Design;
using INFSYS_Design.controllers;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_NhanVien
    {
        public static NhanVien layThongTinNhanVien(int maNv)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM NHANVIEN WHERE MANV = {maNv}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "maNv", "hoTen", "chucVu", "ngaySinh", "gioiTinh", "email", "sdt", "diaChi", "trangThaiLamViec", "maSoDinhDanh", "loaiMaSoDinhDanh" };

            SqlDataReader res = sqlCmd.ExecuteReader();
            

            if (res.Read())
            {
                Dictionary<string, object> empDict = new Dictionary<string, object>();
                foreach(string colName in columnNames)
                {
                    empDict.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                NhanVien nhanVien = new NhanVien(empDict);
                return nhanVien;
            }
            return null;
        }
    }
}
