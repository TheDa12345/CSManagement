﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.GoodMethod
{
    public class GetSqlConnection
    {

        private string connstr = "Data Source=localhost;database=db_CSManage;uid=sa;pwd=sa";
        public GetSqlConnection()
        {

        }

        public SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            return con;
        }
    }

}
