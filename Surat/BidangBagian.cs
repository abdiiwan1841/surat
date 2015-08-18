using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    class BidangBagian
    {
        private string nama_bidang;

        public void setBidang(string bidang)
        {
            this.nama_bidang = bidang;
        }

        public string getBidang()
        {
            return this.nama_bidang;
        }
    }
}
