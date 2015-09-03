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
    public partial class FormSuratDisposisiDetail : DevComponents.DotNetBar.OfficeForm
    {
        private string nomor_surat, nama_gambar;
        private string strconn, query;

        public FormSuratDisposisiDetail()
        {
            InitializeComponent();
        }

        private void getBidangDisposisi(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nomor_surat, disposisi_bagian.id_bagian_bidang, bagian_bidang.nama_bagian_bidang AS nama FROM disposisi_bagian JOIN bagian_bidang USING(id_bagian_bidang) " +
                        "WHERE nomor_surat = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["nama"].ToString().Equals("Tata Usaha"))
                    {
                        checkBoxKabagTataUsaha.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Programa Siaran"))
                    {
                        checkBoxKabidProgramaSiaran.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Pemberitaan"))
                    {
                        checkBoxKabidPemberitaan.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Teknologi dan Media Baru"))
                    {
                        checkBoxKabidTeknologi.Checked = true;
                    }
                    if (reader["nama"].ToString().Equals("Layanan dan Pengembangan"))
                    {
                        checkBoxKabidLPU.Checked = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getSuratDisposisi(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM surat_disposisi WHERE nomor_surat = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                textBoxNomorSurat.Text = nomor_surat;
                textBoxNomorAgenda.Text = reader["nomor_agenda"].ToString();
                textBoxAsalSurat.Text = reader["asal"].ToString();
                textBoxPerihal.Text = reader["perihal"].ToString();
                textBoxSifatSurat.Text = reader["sifat"].ToString();
                if (reader["tanggal_surat"].ToString().Equals("1/1/0001"))
                    textBoxTanggalSurat.Text = "";
                else
                    textBoxTanggalSurat.Text = reader["tanggal_surat"].ToString();
                if (reader["tanggal_terima"].ToString().Equals("1/1/0001"))
                    textBoxTanggalDiterima.Text = "";
                else
                    textBoxTanggalDiterima.Text = reader["tanggal_terima"].ToString();
                if (reader["tanggal_diteruskan"].ToString().Equals("1/1/0001"))
                    textBoxTanggalSurat.Text = "";
                else
                    textBoxTanggalDiteruskan.Text = reader["tanggal_diteruskan"].ToString();
                textBoxIsiSurat.Text = reader["perintah"].ToString();
                textBoxKeterangan.Text = reader["disposisi_lain"].ToString();
                nama_gambar = reader["gambar_surat"].ToString();
                if (reader["diproses_diselesaikan"].ToString().Equals("Y"))
                {
                    checkBoxDiproses.Checked = true;
                }
                if (reader["dilaksanakan"].ToString().Equals("Y"))
                {
                    checkBoxDilaksanakan.Checked = true;
                }
                if (reader["ditanggapi"].ToString().Equals("Y"))
                {
                    checkBoxDitanggapi.Checked = true;
                }
                if (reader["diperhatikan"].ToString().Equals("Y"))
                {
                    checkBoxDiperhatikan.Checked = true;
                }
                if (reader["dilaporkan"].ToString().Equals("Y"))
                {
                    checkBoxDilaporkan.Checked = true;
                }
                if (reader["diketahui"].ToString().Equals("Y"))
                {
                    checkBoxDiketahui.Checked = true;
                }
                if (reader["diedarkan"].ToString().Equals("Y"))
                {
                    checkBoxDiedarkan.Checked = true;
                }
                if (reader["diperbanyak_dicopy"].ToString().Equals("Y"))
                {
                    checkBoxDiperbanyak.Checked = true;
                }
                if (reader["ditampung"].ToString().Equals("Y"))
                {
                    checkBoxDitampung.Checked = true;
                }
                if (reader["dihadiri_diwakilkan"].ToString().Equals("Y"))
                {
                    checkBoxDihadiri.Checked = true;
                }
                if (reader["dikonsepkan_jawaban"].ToString().Equals("Y"))
                {
                    checkBoxDikonsepkan.Checked = true;
                }
                if (reader["dievaluasi_diteliti"].ToString().Equals("Y"))
                {
                    checkBoxDievaluasi.Checked = true;
                }
                if (reader["saran_pendapat"].ToString().Equals("Y"))
                {
                    checkBoxSaran.Checked = true;
                }
                if (reader["disimpan_file_arsip"].ToString().Equals("Y"))
                {
                    checkBoxDisimpan.Checked = true;
                }
                pictureBoxGambarSurat.Image = new Bitmap(Application.StartupPath + "\\image_surat_disposisi\\" + reader["gambar_surat"].ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void FormSuratDisposisiDetail_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratDisposisi.nomor_surat;
            getSuratDisposisi(nomor_surat);
            getBidangDisposisi(nomor_surat);
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}