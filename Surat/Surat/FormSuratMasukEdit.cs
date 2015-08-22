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
    public partial class FormSuratMasukEdit : DevComponents.DotNetBar.OfficeForm
    {
        private string query, strconn;
        private string nomor_surat, perihal, tanggal_surat, tanggal_terima, 
                        id_jenis, jenis_surat, sifat_surat, pengirim, alamat_pengirim, 
                        penerima, jabatan_tertanda, tertanda, distribusi_tanggal, 
                        isi_singkat, keterangan, gambar_surat;

        public FormSuratMasukEdit()
        {
            InitializeComponent();
        }

        private void getAllJenisSurat()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            query = "SELECT nama_jenis FROM jenis_surat";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxJenisSuratMasuk.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void getJenisSurat(string id_jenis)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM jenis_surat WHERE id_jenis = @id_jenis";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_jenis", id_jenis);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jenis_surat = reader["nama_jenis"].ToString();
                }
                comboBoxJenisSuratMasuk.SelectedText = jenis_surat;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getSifatSurat(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT sifat_surat FROM surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sifat_surat = reader["sifat_surat"].ToString();
                }
                comboBoxSifatSuratMasuk.SelectedText = sifat_surat;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getSuratMasuk()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    perihal = reader[1].ToString();
                    tanggal_surat = reader[2].ToString();
                    tanggal_terima = reader["tanggal_terima"].ToString();
                    id_jenis = reader["id_jenis"].ToString();
                    pengirim = reader["pengirim"].ToString();
                    alamat_pengirim = reader["pengirim"].ToString();
                    penerima = reader["penerima"].ToString();
                    jabatan_tertanda = reader["jabatan_tertanda"].ToString();
                    tertanda = reader["tertanda"].ToString();
                    distribusi_tanggal = reader["distribusi_tanggal"].ToString();
                    isi_singkat = reader["isi_singkat"].ToString();
                    keterangan = reader["keterangan"].ToString();
                    gambar_surat = reader["gambar_surat"].ToString();
                }
                textBoxNomorSuratMasuk.Text = nomor_surat;
                textBoxPerihalSuratMasuk.Text = perihal;
                dateTimeInputTanggalSuratMasuk.Value = DateTime.Parse(tanggal_surat);
                dateTimeInputTanggalTerimaSuratMasuk.Value = DateTime.Parse(tanggal_terima);
                textBoxInstansiPengirimSuratMasuk.Text = pengirim;
                textBoxAlamatPengirimSuratMasuk.Text = alamat_pengirim;
                textBoxPenerimaSuratMasuk.Text = penerima;
                textBoxJabatanTertandaSuratMasuk.Text = jabatan_tertanda;
                textBoxTertandaPengirimSuratMasuk.Text = tertanda;
                dateTimeInputTanggalDistribusiSuratMasuk.Value = DateTime.Parse(distribusi_tanggal);
                textBoxKeteranganSuratMasuk.Text = keterangan;
                textBoxIsiSuratMasuk.Text = isi_singkat;
                pictureBoxGambarSuratMasuk.Image = new Bitmap(Application.StartupPath  + "\\image_surat_masuk\\"+gambar_surat);
                getJenisSurat(id_jenis);
                getSifatSurat(nomor_surat);
                textBoxNomorSuratMasuk.SelectionStart = 0;
                textBoxNomorSuratMasuk.SelectionLength = textBoxNomorSuratMasuk.Text.Length;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void FormSuratMasukEdit_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratMasuk.nomor_surat;
            getAllJenisSurat();
            getSuratMasuk();
        }

        private void buttonKembaliSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            FormSuratMasukLampiran form_lampiran = new FormSuratMasukLampiran();
            form_lampiran.ShowDialog();
        }

        private void FormSuratMasukEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSuratMasukLampiran.list_lampiran.Clear();
            FormSuratMasukTembusan.list_tembusan.Clear();
            FormSuratMasukLampiran.opened = false;
            FormSuratMasukTembusan.opened = false;
        }

        private void buttonTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            FormSuratMasukTembusan form_tembusan = new FormSuratMasukTembusan();
            form_tembusan.ShowDialog();
        }
    }
}