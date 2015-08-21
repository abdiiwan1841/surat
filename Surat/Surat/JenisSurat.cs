using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    class JenisSurat
    {
        private string nama_jenis;

        public void setJenis(string jenis)
        {
            this.nama_jenis = jenis;
        }

        public string getJenis()
        {
            return this.nama_jenis;
        }
    }
}
