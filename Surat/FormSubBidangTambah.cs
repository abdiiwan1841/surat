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
    public partial class FormSubBidangTambah : DevComponents.DotNetBar.OfficeForm
    {
        public string id_bagian_bidang, nama_bagian_bidang;
        private readonly FormSubBidang frm1;

        public FormSubBidangTambah(string id, string nama, FormSubBidang frm)
        {
            InitializeComponent();
            id_bagian_bidang = id;
            nama_bagian_bidang = nama;
            frm1 = frm;
        }

        private void tambahSubBidang()
        {
            BidangBagian bdg = new BidangBagian();
            bdg.setBidang(textBoxSubBidangTambah.Text);
            string bidang = bdg.getBidang();

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "INSERT INTO sub_bagian_bidang VALUES(NULL, @id_bagian_bidang, @nama_sub_bagian_bidang)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_sub_bagian_bidang", bidang);
            cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bagian_bidang);
            int hasil = cmd.ExecuteNonQuery();
            if (hasil > 0)
            {
                MessageBox.Show("Data berhasil ditambah", "Sukses");
                frm1.getAllSubBidang();

            }
            else
            {
                MessageBox.Show("Data gagal ditambah", "Gagal");
            }

            conn.Close();
        }

        private void buttonSubBidangTambah_Click(object sender, EventArgs e)
        {
            tambahSubBidang();
        }

        private void buttonSubBidangTambahKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}