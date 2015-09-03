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
    public partial class FormSuratMasukDetail : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string nomor_surat, jenis_surat;

        public FormSuratMasukDetail()
        {
            InitializeComponent();
        }

        private void getDistribusi()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nomor_surat_masuk, detail_bagian_bidang_surat_masuk.id_bagian_bidang, bagian_bidang.nama_bagian_bidang AS nama FROM detail_bagian_bidang_surat_masuk JOIN bagian_bidang USING(id_bagian_bidang) " +
                        "WHERE  detail_bagian_bidang_surat_masuk.nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["nama"].ToString().Equals("Tata Usaha"))
                    {
                        checkBoxTataUsaha.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Programa Siaran"))
                    {
                        checkBoxProgramaSiaran.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Pemberitaan"))
                    {
                        checkBoxPemberitaan.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Teknologi dan Media Baru"))
                    {
                        checkBoxTeknologi.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Layanan dan Pengembangan"))
                    {
                        checkBoxLayanan.Checked = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getJenisSurat(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nama_jenis FROM jenis_surat JOIN surat_masuk USING (id_jenis) WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jenis_surat = reader["nama_jenis"].ToString();
                }
                textBoxJenisSurat.Text = jenis_surat;
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
                    textBoxSifatSurat.Text = reader["sifat_surat"].ToString();
                }
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
                while (reader.Read())
                {
                    textBoxNomorSuratMasuk.Text = nomor_surat;
                    textBoxPerihalSuratMasuk.Text = reader["perihal"].ToString();
                    if (reader["tanggal_terima"].ToString().Equals("1/1/0001"))
                        textBoxTanggalTerima.Text = "";
                    else
                        textBoxTanggalTerima.Text = reader["tanggal_terima"].ToString();
                    if (reader["tanggal_surat"].ToString().Equals("1/1/0001"))
                        textBoxTanggalSurat.Text = "";
                    else
                        textBoxTanggalSurat.Text = reader["tanggal_surat"].ToString();
                    textBoxInstansiPengirimSuratMasuk.Text = reader["pengirim"].ToString();
                    textBoxAlamatPengirimSuratMasuk.Text = reader["alamat_pengirim"].ToString();
                    textBoxPenerimaSuratMasuk.Text = reader["penerima"].ToString();
                    textBoxJabatanTertandaSuratMasuk.Text = reader["jabatan_tertanda"].ToString();
                    textBoxTertandaPengirimSuratMasuk.Text = reader["tertanda"].ToString();
                    if (reader["distribusi_tanggal"].ToString().Equals("1/1/0001"))
                        textBoxTanggalDistribusi.Text = "";
                    else
                        textBoxTanggalDistribusi.Text = reader["distribusi_tanggal"].ToString();
                    textBoxKeteranganSuratMasuk.Text = reader["keterangan"].ToString();
                    textBoxIsiSuratMasuk.Text = reader["isi_singkat"].ToString();
                    pictureBoxGambarSuratMasuk.Image = new Bitmap(Application.StartupPath + "\\image_surat_masuk\\" + reader["gambar_surat"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void FormSuratMasukDetail_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratMasuk.nomor_surat;
            getSuratMasuk();
            getJenisSurat(nomor_surat);
            getSifatSurat(nomor_surat);
            getDistribusi();
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

        private void buttonTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            FormSuratMasukTembusan form_tembusan = new FormSuratMasukTembusan();
            form_tembusan.ShowDialog();
        }
    }
}