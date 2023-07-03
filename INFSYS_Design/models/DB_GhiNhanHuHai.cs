using INFSYS_Design.controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFSYS_Design.models
{
    class DB_GhiNhanHuHai
    {
        public static int themGhiNhanHuHai(GhiNhanHuHai hh)
        {
            DBConn conn = new DBConn();
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = $@"
                INSERT INTO GHINHANHUHAI(THIETBIHUHAI, MOTATINHTRANG, CHIPHIDENBU, MACHECKOUT)
                VALUES('{hh.thietBiHuHai}', '{hh.moTaTinhTrang}', {hh.chiPhiDenBu}, {hh.maCheckout})",
                Connection = conn.conn
            };

            return sqlCmd.ExecuteNonQuery();
        }
    }
}
