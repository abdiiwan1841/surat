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
    public partial class FormKlasifikasiSurat : DevComponents.DotNetBar.OfficeForm
    {
        public FormKlasifikasiSurat()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable jenis_surat = new DataTable();
            jenis_surat.Load(reader);
            jenis_surat.Columns[0].ColumnName = "ID Jenis Surat";
            jenis_surat.Columns[1].ColumnName = "Jenis Surat";

            dataGridViewJenisSurat.ClearSelection();
            dataGridViewJenisSurat.DataSource = jenis_surat;
        }

        public void getAllJenisSurat()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM jenis_surat";
            MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void cariJenisSurat()
        {
            JenisSurat jenis = new JenisSurat();
            string cari = textBoxCari.Text;
            
            Database db = new Database();
            string strconn =  db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM jenis_surat WHERE nama_jenis LIKE '%"+cari+"%'";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cari", cari);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void FormKlasifikasiSurat_Load(object sender, EventArgs e)
        {
            getAllJenisSurat();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormKlasifikasiSuratTambah formTambah = new FormKlasifikasiSuratTambah(this);
            formTambah.ShowDialog();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cariJenisSurat();
        }
    }
}