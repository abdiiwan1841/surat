using System;
using System.Collections.Generic;
using System.Text;

namespace Surat
{
    class SubBidangBagian
    {
        private string nama_sub_bidang;

        public void setSubBidang(string bidang)
        {
            this.nama_sub_bidang = bidang;
        }

        public string getSubBidang()
        {
            return this.nama_sub_bidang;
        }

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
