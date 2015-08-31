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
    public partial class FormSuratKeluar : DevComponents.DotNetBar.OfficeForm
    {
        private string query, strconn, kriteria;
        public static string nomor_surat;
        public static string status;

        public FormSuratKeluar()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable jenis_surat = new DataTable();
            jenis_surat.Load(reader);
            jenis_surat.Columns[0].ColumnName = "Nomor Surat";
            jenis_surat.Columns[1].ColumnName = "Tanggal Surat";
            jenis_surat.Columns[2].ColumnName = "Perihal";
            jenis_surat.Columns[3].ColumnName = "Jenis Surat";

            dataGridViewSuratKeluar.ClearSelection();
            dataGridViewSuratKeluar.DataSource = jenis_surat;
        }

        public void getSuratID()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            conn.Close();


        }

        public void getAllSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT nomor_surat_Keluar, tanggal_surat,perihal, j.nama_jenis AS jenis_surat " +
                                "FROM surat_Keluar JOIN jenis_surat AS j USING(id_jenis)";
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

        private void deleteSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM surat_keluar WHERE nomor_surat_keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                //MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "Sukses");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void deleteTembusanSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM tembusan_surat_keluar WHERE nomor_surat_keluar = @nomor_surat";
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

        private void FormSuratKeluar_Load(object sender, EventArgs e)
        {
            getAllSuratKeluar();
            kriteria = "nomor_surat_keluar";
        }

        private void dataGridViewSuratKeluar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambahSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            status = "Tambah";
            FormSuratKeluarTambah form_tambah = new FormSuratKeluarTambah(this);
            form_tambah.ShowDialog();
        }

        private void radioButtonNomorSuratKeluar_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_surat_keluar";
        }

        private void radioButtonPerihalSuratKeluar_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "perihal";
        }

        private void textBoxCariSuratKeluar_TextChanged(object sender, EventArgs e)
        {
            string cari;
            cari = textBoxCariSuratKeluar.Text;

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT nomor_surat_keluar, tanggal_surat,perihal,nama_jenis AS jenis_surat " +
                                "FROM surat_Keluar JOIN jenis_surat AS j USING(id_jenis) "+
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

        private void FormSuratKeluar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form_main = new FormMain();
            form_main.Show();
        }

        private void buttonHapusSuratKeluar_Click(object sender, EventArgs e)
        {
            string title = "Konfirmasi Penghapusan Data";
            string konten = "Apakah Anda yakin ingin menghapus data?";

            DialogResult result = MessageBox.Show(konten, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                deleteTembusanSuratKeluar();
                deleteSuratKeluar();
                getAllSuratKeluar();
            }
        }

        private void dataGridViewSuratKeluar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSuratKeluar.SelectedRows)
            {
                nomor_surat = row.Cells[0].Value.ToString();
            }
        }

        private void buttonEditSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            status = "Edit";
            FormSuratKeluarEdit form_edit = new FormSuratKeluarEdit(this);
            form_edit.ShowDialog();
        }

        //private void radioButtonInstansiPengirim_CheckedChanged(object sender, EventArgs e)
        //{
          //  kriteria = "penerima";
       // }

    }
}