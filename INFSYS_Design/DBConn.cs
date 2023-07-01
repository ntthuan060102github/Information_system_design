using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INFSYS_Design
{
    class DBConn
    {
        // Thuan DB: @"Data Source=LAPTOP-AOM8J85N\SQLEXPRESS;Initial Catalog=PTTK_HTTT;Integrated Security=True";
        // Son DB: @"Data Source=SONVO\SQLEXPRESS01;Initial Catalog=PTTK_HTTT;Integrated Security=True"
        // Thai DB: @"Data Source=LAPTOP-OIBBNV6Q\SQLEXPRESS;Initial Catalog=PTTK_HTTT;Integrated Security=True"
        private string strConn = @"Data Source=LAPTOP-OIBBNV6Q\SQLEXPRESS;Initial Catalog=PTTK_HTTT;Integrated Security=True";
        public SqlConnection conn { get; } = null;

        public DBConn()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /*~DBConn()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }*/

    }
}
