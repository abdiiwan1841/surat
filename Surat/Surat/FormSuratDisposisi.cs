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
    public partial class FormSuratDisposisi : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string kriteria, cari;
        public static string nomor_surat;
        

        public FormSuratDisposisi()
        {
            InitializeComponent();
        }

        private void setDataTable(MySqlDataReader reader)
        {
            DataTable disposisi = new DataTable();
            disposisi.Load(reader);
            disposisi.Columns[0].ColumnName = "Nomor Surat";
            disposisi.Columns[1].ColumnName = "Nomor Agenda";
            disposisi.Columns[2].ColumnName = "Tanggal Surat";
            disposisi.Columns[3].ColumnName = "Tanggal Diterima";
            disposisi.Columns[4].ColumnName = "Tanggal Diteruskan";
            disposisi.Columns[5].ColumnName = "Asal Surat";
            disposisi.Columns[6].ColumnName = "Sifat Surat";
            disposisi.Columns[7].ColumnName = "Perihal";
            //dataGridViewSuratDisposisi.ClearSelection();
            dataGridViewSuratDisposisi.DataSource = disposisi;
        }

        private void getSuratDisposisi(string cari)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nomor_surat, nomor_agenda, DATE_FORMAT(tanggal_surat, '%d-%m-%Y'), DATE_FORMAT(tanggal_terima, '%d-%m-%Y'), " +
                        "DATE_FORMAT(tanggal_diteruskan, '%Y-%m-%d'), asal, sifat, perihal " +
                        "FROM surat_disposisi WHERE "+kriteria+" LIKE '%"+cari+"%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //MessageBox.Show(kriteria);
                MySqlDataReader reader = cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        public void getAllSuratDisposisi()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nomor_surat, nomor_agenda, DATE_FORMAT(tanggal_surat, '%d-%m-%Y'), DATE_FORMAT(tanggal_terima, '%d-%m-%Y'), "+
                        "DATE_FORMAT(tanggal_diteruskan, '%d-%m-%Y'), asal, sifat, perihal " +
                        "FROM surat_disposisi";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader =  cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void hapusDisposisiBidang(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "DELETE FROM disposisi_bagian WHERE nomor_surat = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void hapusSuratDisposisi(string nomor_surat)
        {
            DialogResult result =  MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    hapusDisposisiBidang(nomor_surat);
                    query = "DELETE FROM surat_disposisi WHERE nomor_surat = @nomor_surat";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }  
        }

        private void FormSuratDisposisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form_main = new FormMain();
            form_main.Show();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahSuratDisposisi_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiTambah form_tambah = new FormSuratDisposisiTambah(this);
            form_tambah.ShowDialog();
        }

        private void FormSuratDisposisi_Load(object sender, EventArgs e)
        {
            kriteria = "nomor_surat";
            getAllSuratDisposisi();
        }

        private void radioButtonNomorSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_surat";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonNomorAgenda_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_agenda";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonAsalSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "asal";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonPerihalSuratMasuk_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "perihal";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonTanggalSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "tanggal_surat";
            textBoxCari.SendToBack();
            dataGridViewSuratDisposisi.BringToFront();
            getAllSuratDisposisi();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cari = textBoxCari.Text;
            getSuratDisposisi(cari);
        }

        private void dateTimeInputTanggalSurat_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            cari = dateTimeInputTanggalSurat.Value.Date.ToString("yyyy-MM-dd");
            //MessageBox.Show(cari);
            getSuratDisposisi(cari);
        }

        private void dataGridViewSuratDisposisi_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSuratDisposisi.SelectedRows)
            {
                nomor_surat = row.Cells[0].Value.ToString();
            }
        }

        private void buttonHapusSuratDisposisi_Click(object sender, EventArgs e)
        {
            hapusSuratDisposisi(nomor_surat);
            getAllSuratDisposisi();
        }

        private void buttonEditSuratDisposisi_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiEdit form_edit = new FormSuratDisposisiEdit(this);
            form_edit.ShowDialog();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiDetail form_detail = new FormSuratDisposisiDetail();
            form_detail.ShowDialog();
        }
    }
}