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
    public partial class FormKlasifikasiSuratTambah : DevComponents.DotNetBar.OfficeForm
    {
        private readonly FormKlasifikasiSurat frm1;
        public FormKlasifikasiSuratTambah(FormKlasifikasiSurat frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void tambahJenisSurat()
        {
            JenisSurat j = new JenisSurat();
            j.setJenis(textBoxJenis.Text);
            string jenis = j.getJenis();

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "INSERT INTO jenis_surat VALUES(NULL, @jenis)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@jenis", jenis);
            int hasil = cmd.ExecuteNonQuery();
            if (hasil > 0)
            {
                MessageBox.Show("Data berhasil ditambah", "Sukses");
                frm1.getAllJenisSurat();
                
            }
            else
            {
                MessageBox.Show("Data gagal ditambah", "Gagal");
            }

            conn.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            tambahJenisSurat();
        }


        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}