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
    public partial class FormDetailSuratKeluar : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string nomor_surat, jenis_surat;

        public FormDetailSuratKeluar()
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
                query = "SELECT nomor_surat_keluar, detail_bagian_bidang_surat_keluar.id_bagian_bidang, bagian_bidang.nama_bagian_bidang AS nama FROM detail_bagian_bidang_surat_keluar JOIN bagian_bidang USING(id_bagian_bidang) " +
                        "WHERE  detail_bagian_bidang_surat_keluar.nomor_surat_keluar = @nomor_surat";
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
                query = "SELECT nama_jenis FROM jenis_surat JOIN surat_keluar USING (id_jenis) WHERE nomor_surat_keluar = @nomor_surat";
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

        private void getSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM surat_Keluar WHERE nomor_surat_Keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxNomorSuratKeluar.Text = nomor_surat;
                    textBoxPerihalSuratKeluar.Text = reader["perihal"].ToString();
                    textBoxTanggalSurat.Text = reader["tanggal_surat"].ToString();
                    textBoxPenerimaSuratKeluar.Text = reader["penerima"].ToString();
                    textBoxJabatanTertandaSuratKeluar.Text = reader["jabatan_tertanda"].ToString();
                    textBoxTertandaPengirimSuratKeluar.Text = reader["tertanda"].ToString();
                    textBoxTanggalDistribusi.Text = reader["distribusi_tanggal"].ToString();
                    textBoxKeteranganSuratKeluar.Text = reader["keterangan"].ToString();
                    textBoxIsiSuratKeluar.Text = reader["isi_singkat"].ToString();
                    textBoxSifatSuratKeluar.Text = reader["sifat_surat"].ToString();
                    pictureBoxGambarSuratKeluar.Image = new Bitmap(Application.StartupPath + "\\image_surat_keluar\\" + reader["gambar_surat"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void buttonKembaliSuratKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetailSuratKeluar_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratKeluar.nomor_surat;
            getSuratKeluar();
            getJenisSurat(nomor_surat);
            getDistribusi();
        }

        private void buttonLampiranSuratKeluar_Click_1(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            form_lampiran.ShowDialog();
        }

        private void buttonTembusanSuratKeluar_Click_1(object sender, EventArgs e)
        {
            FormSuratKeluarTembusan form_tembusan = new FormSuratKeluarTembusan();
            form_tembusan.ShowDialog();

        }

        private void textBoxTanggalDistribusi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKembaliSuratKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}