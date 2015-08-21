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
    public partial class FormSuratMasuk : DevComponents.DotNetBar.OfficeForm
    {
        private string query, strconn, kriteria;
        public static string nomor_surat;

        public FormSuratMasuk()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable jenis_surat = new DataTable();
            jenis_surat.Load(reader);
            jenis_surat.Columns[0].ColumnName = "Nomor Surat";
            jenis_surat.Columns[1].ColumnName = "Tanggal Surat";
            jenis_surat.Columns[2].ColumnName = "Tanggal Terima";
            jenis_surat.Columns[3].ColumnName = "Perihal";
            jenis_surat.Columns[4].ColumnName = "Pengirim";
            jenis_surat.Columns[5].ColumnName = "Sifat Surat";
            jenis_surat.Columns[6].ColumnName = "Jenis Surat";

            dataGridViewSuratMasuk.ClearSelection();
            dataGridViewSuratMasuk.DataSource = jenis_surat;
        }

        public void getSuratID()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            conn.Close();

            
        }

        public void getAllSuratMasuk()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT nomor_surat_masuk, tanggal_surat, tanggal_terima, perihal, pengirim, sifat_surat, j.nama_jenis AS jenis_surat " +
                                "FROM surat_masuk JOIN jenis_surat AS j USING(id_jenis)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
    
            conn.Close();
        }

        private void deleteSuratMasuk()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                //MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "Sukses");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void deleteTembusanSuratMasuk()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM tembusan_surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                //MessageBox.Show(query);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void buttonTambahSuratMasuk_Click(object sender, EventArgs e)
        {
            FormTambahSuratMasuk form_tambah = new FormTambahSuratMasuk();
            form_tambah.ShowDialog();
        }

        private void FormSuratMasuk_Load(object sender, EventArgs e)
        {
            getAllSuratMasuk();
            kriteria = "nomor_surat_masuk";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_surat_masuk";
        }

        private void radioButtonPerihalSuratMasuk_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "perihal";
        }

        private void radioButtonInstansiPengirim_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "pengirim";
        }

        private void textBoxCariSuratMasuk_TextChanged(object sender, EventArgs e)
        {
            string cari;
            cari = textBoxCariSuratMasuk.Text;

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT nomor_surat_masuk, tanggal_surat, tanggal_terima, perihal, pengirim, sifat_surat, j.nama_jenis AS jenis_surat " +
                                "FROM surat_masuk JOIN jenis_surat AS j USING(id_jenis) "+
                                "WHERE "+kriteria+" LIKE '%"+cari+"%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuratMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form_main = new FormMain();
            form_main.Show();
        }

        private void buttonHapusSuratMasuk_Click(object sender, EventArgs e)
        {
            string title = "Konfirmasi Penghapusan Data";
            string konten = "Apakah Anda yakin ingin menghapus data?";

            DialogResult result = MessageBox.Show(konten, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                deleteTembusanSuratMasuk();
                deleteSuratMasuk();
                getAllSuratMasuk();
            }
        }

        private void dataGridViewSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSuratMasuk.SelectedRows)
            {
                nomor_surat = row.Cells[0].Value.ToString();
            }
        }
    }
}