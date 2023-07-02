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
    class DB_YeuCauDatPhong
    {
        
        public static bool themYeuCauDatPhong(YeuCauDatPhong yc)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO YeuCauDatPhong (SODEMLUUTRU, NGAYDEN, NGAYYEUCAU, YEUCAUDACBIET, MAKH, LOAIPHONG) VALUES (@soDemLuuTru, @ngayDen, @ngayYeuCau, @yeuCauDacBiet, @maKH, @loaiPhong)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@ma", yc.ma);
            sqlCmd.Parameters.AddWithValue("@soDemLuuTru", yc.soDemLuuTru);
            sqlCmd.Parameters.AddWithValue("@ngayDen", yc.ngayDen);
            sqlCmd.Parameters.AddWithValue("@ngayYeuCau", yc.ngayYeuCau);
            sqlCmd.Parameters.AddWithValue("@yeuCauDacBiet", yc.yeuCauDacBiet);
            sqlCmd.Parameters.AddWithValue("@maKH", yc.maKH);
            sqlCmd.Parameters.AddWithValue("@loaiPhong", yc.loaiPhong);

            try
            {
                // Thực thi câu lệnh SQL insert
                int rowsAffected = sqlCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    //chèn dữ liệu thành công
                    return true;
                }
                else
                {
                    //chèn dữ liệu thất bại
                    return false;
                }
            }
            catch
            {
                //lỗi ngoại lệ
                return false;
            }
        }

    }
}
