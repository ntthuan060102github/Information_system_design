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
        public static LichSuDatPhong layLichSuDatPhong(int maKH)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $"SELECT * FROM LichSuDatPhong WHERE MAKHACHHANG={maKH}";
            sqlCmd.Connection = conn.conn;
            string[] columnNames = { "ma", "thoiGianTraPhongDuKien", "thoiGianDat", "hinhThucThanhToan", "soTienDatCoc", "maYeuCau", "soPhong", "thoiGianCheckin"};

            SqlDataReader res = sqlCmd.ExecuteReader();

            while (res.Read())
            {
                Dictionary<string, object> customerInfo = new Dictionary<string, object>();
                foreach (string colName in columnNames)
                {
                    customerInfo.Add(colName.ToUpper(), res.GetValue(res.GetOrdinal(colName.ToUpper())));
                }
                LichSuDatPhong customer = new LichSuDatPhong(customerInfo);
                return customer;
            }

            return null;
        }

        public static void themLichSuDatPhong(LichSuDatPhong lsdp)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO LichSuDatPhong (THOIGIANTRAPHONGDUKIEN, THOIGIANDAT, HINHTHUCTHANHTOAN, SOTIENDATCOC, MAYEUCAU, SOPHONG, THOIGIANCHECKIN) VALUES (@thoiGianTraPhongDuKien, @thoiGianDat, @hinhThucThanhToan, @soTienDatCoc, @maYeuCau, @soPhong, @thoiGianCheckin)";
            sqlCmd.Connection = conn.conn;

            sqlCmd.Parameters.AddWithValue("@thoiGianTraPhongDuKien", lsdp.thoiGianTraPhongDuKien);
            sqlCmd.Parameters.AddWithValue("@thoiGianDat", lsdp.thoiGianDat);
            sqlCmd.Parameters.AddWithValue("@hinhThucThanhToan", lsdp.hinhThucThanhToan);
            sqlCmd.Parameters.AddWithValue("@soTienDatCoc", lsdp.soTienDatCoc);
            sqlCmd.Parameters.AddWithValue("@maYeuCau", lsdp.maYeuCau);
            sqlCmd.Parameters.AddWithValue("@soPhong", lsdp.soPhong);
            sqlCmd.Parameters.AddWithValue("@thoiGianCheckin", lsdp.thoiGianCheckin);

            try
            {
                int rowsAffected = sqlCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo chèn dữ liệu thành công
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                else
                {
                    // Thông báo chèn dữ liệu thất bại
                    MessageBox.Show("Thêm khách hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi ngoại lệ
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
