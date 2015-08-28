using System;
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
            username = "root";
            password = "";

            string strconn = "server=localhost;User Id='root';password='';database=db_surat; Allow Zero Datetime=true ";

            return strconn;
        }

        public string getString2()
        {
            username = "root";
            password = "";

            string strconn = "server=localhost;User Id='root';password=''; Allow Zero Datetime=true ";

            return strconn;
        }
    }
}
