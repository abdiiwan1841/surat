﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    public class Database
    {
        public string username, password;

        public string getString()
        {
            string strconn = "server=localhost;User Id='root';password='admin';database=db_surat; Allow Zero Datetime=true ";

            return strconn;
        }

        public string getString2()
        {
            string strconn = "server=localhost;User Id='root';password='admin'; Allow Zero Datetime=true ";

            return strconn;
        }
    }
}
