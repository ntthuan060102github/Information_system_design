using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INFSYS_Design.models
{
    class DB_LichSuGiaHan
    {
        public static int themLichSuGiaHan(int maDatPhong, string thoiGianGiaHan)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = $@"
                INSERT INTO LICHSUGIAHAN(NGAYGIAHAN, MADATPHONG, NHANVIENTHUCHIEN)
                VALUES('{thoiGianGiaHan}', {maDatPhong}, {Program.currentUserId});
            ";
            sqlCmd.Connection = conn.conn;
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
