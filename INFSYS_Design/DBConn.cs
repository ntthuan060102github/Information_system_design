﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INFSYS_Design
{
    class DBConn
    {
        private string strConn = @"Data Source=LAPTOP-OIBBNV6Q\SQLEXPRESS;Initial Catalog=PTTK_HTTT_23;Integrated Security=True";
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
