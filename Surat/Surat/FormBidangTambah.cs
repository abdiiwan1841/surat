using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    public partial class FormBidangTambah : DevComponents.DotNetBar.OfficeForm
    {
        private readonly FormBidang frm1;
        
        public FormBidangTambah(FormBidang frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void buttonBidangTambahKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBidangTambah_Click(object sender, EventArgs e)
        {
            tambahBidang();
        }

        private void tambahBidang()
        {
            BidangBagian bdg = new BidangBagian();
            bdg.setBidang(textBoxBidangTambah.Text);
            string bidang = bdg.getBidang();

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "INSERT INTO bagian_bidang VALUES(NULL, @nama_bagian_bidang)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_bagian_bidang", bidang);
            int hasil = cmd.ExecuteNonQuery();
            if (hasil > 0)
            {
                MessageBox.Show("Data berhasil ditambah", "Sukses");
                frm1.getAllBidang();

            }
            else
            {
                MessageBox.Show("Data gagal ditambah", "Gagal");
            }

            conn.Close();
        }
    }
}