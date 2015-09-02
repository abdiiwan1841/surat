using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    public partial class FormSuratDisposisiEdit : DevComponents.DotNetBar.OfficeForm
    {
        private string diproses, dilaksanakan, ditanggapi, diperhatikan, dilaporkan, diketahui, diedarkan, diperbanyak, ditampung, dihadiri, dikonsepkan, dievaluasi, saran, disimpan;
        private string nama_gambar, lokasi_gambar, lokasi_tujuan;
        private bool ganti_gambar;
        private string strconn, query;
        private string nomor_surat, nomor_surat_sebelumnya, nomor_agenda, asal_surat, perihal, sifat_surat, tanggal_surat, tanggal_diterima, tanggal_diteruskan, isi_surat, lain, id_user, bidang;
        private readonly FormSuratDisposisi frm;

        public FormSuratDisposisiEdit(FormSuratDisposisi frm1)
        {
            InitializeComponent();
            frm = frm1;
        }

        private bool validasi()
        {
            bool error = false;
            if (textBoxNomorSurat.Text == "")
            {
                error = true;
                MessageBox.Show("Nomor surat belum diisi. Penyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNomorSurat.Focus();
            }
            return error;
        }

        private void tambahBidangDisposisi(string nomor_surat, string bidang)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "INSERT INTO disposisi_bagian VALUES(@nomor_surat, "+
                        "(SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @bagian_bidang))";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@bagian_bidang", bidang);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void hapusBidangDisposisi(string nomor_surat, string bidang)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "DELETE FROM disposisi_bagian WHERE nomor_surat = @nomor_surat AND id_bagian_bidang = " +
                        "(SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @bagian_bidang)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@bagian_bidang", bidang);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getBidangDisposisi(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT nomor_surat, disposisi_bagian.id_bagian_bidang, bagian_bidang.nama_bagian_bidang AS nama FROM disposisi_bagian JOIN bagian_bidang USING(id_bagian_bidang) "+
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
                comboBoxSifatSurat.SelectedText = reader["sifat"].ToString();
                dateTimeInputTanggalSurat.Value = DateTime.Parse(reader["tanggal_surat"].ToString());
                dateTimeInputTanggalDiterima.Value = DateTime.Parse(reader["tanggal_terima"].ToString());
                dateTimeInputDiteruskan.Value = DateTime.Parse(reader["tanggal_diteruskan"].ToString());
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
                pictureBoxGambarSurat.Image = new Bitmap(Application.StartupPath + "\\image_surat_disposisi\\"+reader["gambar_surat"].ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void editSuratDisposisi(string nomor_surat_sebelumnya)
        {
            nomor_surat = textBoxNomorSurat.Text;
            nomor_agenda = textBoxNomorAgenda.Text;
            asal_surat = textBoxAsalSurat.Text;
            perihal = textBoxPerihal.Text;
            sifat_surat = comboBoxSifatSurat.Text;
            isi_surat = textBoxIsiSurat.Text;
            lain = textBoxKeterangan.Text;
            tanggal_surat = dateTimeInputTanggalSurat.Value.Date.ToString("dd-MM-yyyy");
            if (tanggal_surat == "01-01-0001")
                tanggal_surat = "00-00-0000";
            tanggal_diterima = dateTimeInputTanggalDiterima.Value.Date.ToString("dd-MM-yyyy");
            if (tanggal_diterima == "01-01-0001")
                tanggal_diterima = "00-00-0000";
            tanggal_diteruskan = dateTimeInputDiteruskan.Value.Date.ToString("dd-MM-yyyy");
            if (tanggal_diteruskan == "01-01-0001")
                tanggal_diteruskan = "00-00-0000";
            lokasi_tujuan = Application.StartupPath + "\\image_surat_disposisi";
            id_user = FormMain.id_user;

            if (!Directory.Exists(lokasi_tujuan))
            {
                Directory.CreateDirectory(lokasi_tujuan);
            }
            if (ganti_gambar)
            {
                File.Copy(lokasi_gambar, lokasi_tujuan + "\\" + nama_gambar, true);
            }

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "UPDATE surat_disposisi " +
                        "SET nomor_surat = @nomor_surat, nomor_agenda = @nomor_agenda, tanggal_surat = STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), " +
                             "tanggal_terima = STR_TO_DATE(@tanggal_diterima, '%d-%m-%Y'), tanggal_diteruskan = STR_TO_DATE(@tanggal_diteruskan, '%d-%m-%Y'), " +
                             "asal = @asal, sifat = @sifat, perihal = @perihal, perintah = @perintah, disposisi_lain = @lain, " +
                             "diproses_diselesaikan = @diproses, dilaksanakan =  @dilaksanakan, ditanggapi = @ditanggapi, diperhatikan = @diperhatikan, " +
                             "dilaporkan = @dilaporkan, diketahui = @diketahui, diedarkan = @diedarkan, diperbanyak_dicopy = @diperbanyak, " +
                             "ditampung = @ditampung, dihadiri_diwakilkan = @dihadiri, dikonsepkan_jawaban = @dikonsepkan, " +
                             "dievaluasi_diteliti = @dievaluasi, saran_pendapat = @saran_pendapat, disimpan_file_arsip = @disimpan, " +
                             "gambar_surat = @gambar_surat, id_user = @id_user, tanggal_update = NOW() " +
                         "WHERE nomor_surat = @nomor_surat_sebelumnya";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@nomor_agenda", nomor_agenda);
                cmd.Parameters.AddWithValue("@tanggal_surat", tanggal_surat);
                cmd.Parameters.AddWithValue("@tanggal_diterima", tanggal_diterima);
                cmd.Parameters.AddWithValue("@tanggal_diteruskan", tanggal_diteruskan);
                cmd.Parameters.AddWithValue("@asal", asal_surat);
                cmd.Parameters.AddWithValue("@sifat", sifat_surat);
                cmd.Parameters.AddWithValue("@perihal", perihal);
                cmd.Parameters.AddWithValue("@perintah", isi_surat);
                cmd.Parameters.AddWithValue("@lain", lain);
                cmd.Parameters.AddWithValue("@diproses", diproses);
                cmd.Parameters.AddWithValue("@dilaksanakan", dilaksanakan);
                cmd.Parameters.AddWithValue("@ditanggapi", ditanggapi);
                cmd.Parameters.AddWithValue("@diperhatikan", diperhatikan);
                cmd.Parameters.AddWithValue("@dilaporkan", dilaporkan);
                cmd.Parameters.AddWithValue("@diketahui", diketahui);
                cmd.Parameters.AddWithValue("@diedarkan", diedarkan);
                cmd.Parameters.AddWithValue("@diperbanyak", diperbanyak);
                cmd.Parameters.AddWithValue("@ditampung", ditampung);
                cmd.Parameters.AddWithValue("@dihadiri", dihadiri);
                cmd.Parameters.AddWithValue("@dikonsepkan", dikonsepkan);
                cmd.Parameters.AddWithValue("@dievaluasi", dievaluasi);
                cmd.Parameters.AddWithValue("@saran_pendapat", saran);
                cmd.Parameters.AddWithValue("@disimpan", disimpan);
                cmd.Parameters.AddWithValue("@gambar_surat", nama_gambar);
                cmd.Parameters.AddWithValue("@id_user", id_user);
                cmd.Parameters.AddWithValue("@nomor_surat_sebelumnya", nomor_surat_sebelumnya);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void FormSuratDisposisiEdit_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratDisposisi.nomor_surat;
            nomor_surat_sebelumnya = FormSuratDisposisi.nomor_surat;
            ganti_gambar = false;
            getSuratDisposisi(nomor_surat);

            checkBoxKabagTataUsaha.CheckedChanged -= checkBoxKabagTataUsaha_CheckedChanged;
            checkBoxKabidLPU.CheckedChanged -= checkBoxKabidLPU_CheckedChanged;
            checkBoxKabidPemberitaan.CheckedChanged -= checkBoxKabidPemberitaan_CheckedChanged;
            checkBoxKabidProgramaSiaran.CheckedChanged -= checkBoxKabidProgramaSiaran_CheckedChanged;
            checkBoxKabidTeknologi.CheckedChanged -= checkBoxKabidTeknologi_CheckedChanged;

            getBidangDisposisi(nomor_surat);

            checkBoxKabagTataUsaha.CheckedChanged += checkBoxKabagTataUsaha_CheckedChanged;
            checkBoxKabidLPU.CheckedChanged += checkBoxKabidLPU_CheckedChanged;
            checkBoxKabidPemberitaan.CheckedChanged += checkBoxKabidPemberitaan_CheckedChanged;
            checkBoxKabidProgramaSiaran.CheckedChanged += checkBoxKabidProgramaSiaran_CheckedChanged;
            checkBoxKabidTeknologi.CheckedChanged += checkBoxKabidTeknologi_CheckedChanged;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxKabagTataUsaha_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Tata Usaha";
            if (checkBoxKabagTataUsaha.Checked)
            {
                tambahBidangDisposisi(nomor_surat, bidang);
            }
            else
            {
                hapusBidangDisposisi(nomor_surat, bidang);
            }
        }

        private void checkBoxKabidProgramaSiaran_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Programa Siaran";
            if (checkBoxKabidProgramaSiaran.Checked)
            {
                tambahBidangDisposisi(nomor_surat, bidang);
            }
            else
            {
                hapusBidangDisposisi(nomor_surat, bidang);
            }
        }

        private void checkBoxKabidPemberitaan_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Pemberitaan";
            if (checkBoxKabidPemberitaan.Checked)
            {
                tambahBidangDisposisi(nomor_surat, bidang);
            }
            else
            {
                hapusBidangDisposisi(nomor_surat, bidang);
            }
        }

        private void checkBoxKabidTeknologi_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Teknologi dan Media Baru";
            if (checkBoxKabidTeknologi.Checked)
            {
                tambahBidangDisposisi(nomor_surat, bidang);
            }
            else
            {
                hapusBidangDisposisi(nomor_surat, bidang);
            }
        }

        private void checkBoxKabidLPU_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Layanan dan Pengembangan";
            if (checkBoxKabidLPU.Checked)
            {
                tambahBidangDisposisi(nomor_surat, bidang);
            }
            else
            {
                hapusBidangDisposisi(nomor_surat, bidang);
            }
        }

        private void buttonGambarSurat_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ganti_gambar = true;
                lokasi_gambar = dialog.FileName;
                nama_gambar = Path.GetFileName(lokasi_gambar);
                pictureBoxGambarSurat.Image = new Bitmap(lokasi_gambar);
            } 
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (validasi())
            {
                return;
            }
            else
            {
                editSuratDisposisi(nomor_surat_sebelumnya);
            }
            frm.getAllSuratDisposisi();
        }

        private void checkBoxDiproses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiproses.Checked)
            {
                diproses = "Y";
            }
            else
            {
                diproses = "T";
            }
            // MessageBox.Show(diproses);
        }

        private void checkBoxDilaksanakan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDilaksanakan.Checked)
            {
                dilaksanakan = "Y";
            }
            else
            {
                dilaksanakan = "T";
            }
        }

        private void checkBoxDitanggapi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDitanggapi.Checked)
            {
                ditanggapi = "Y";
            }
            else
            {
                ditanggapi = "T";
            }
        }

        private void checkBoxDiperhatikan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiperhatikan.Checked)
            {
                diperhatikan = "Y";
            }
            else
            {
                diperhatikan = "T";
            }
        }

        private void checkBoxDilaporkan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDilaporkan.Checked)
            {
                dilaporkan = "Y";
            }
            else
            {
                dilaporkan = "T";
            }
        }

        private void checkBoxDiketahui_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiketahui.Checked)
            {
                diketahui = "Y";
            }
            else
            {
                diketahui = "T";
            }
        }

        private void checkBoxDiedarkan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiedarkan.Checked)
            {
                diedarkan = "Y";
            }
            else
            {
                diedarkan = "T";
            }
        }

        private void checkBoxDiperbanyak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiperbanyak.Checked)
            {
                diperbanyak = "Y";
            }
            else
            {
                diperbanyak = "T";
            }
        }

        private void checkBoxDitampung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDitampung.Checked)
            {
                ditampung = "Y";
            }
            else
            {
                ditampung = "T";
            }
        }

        private void checkBoxDihadiri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDihadiri.Checked)
            {
                dihadiri = "Y";
            }
            else
            {
                dihadiri = "T";
            }
        }

        private void checkBoxDikonsepkan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDikonsepkan.Checked)
            {
                dikonsepkan = "Y";
            }
            else
            {
                dikonsepkan = "T";
            }
        }

        private void checkBoxDievaluasi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDievaluasi.Checked)
            {
                dievaluasi = "Y";
            }
            else
            {
                dievaluasi = "T";
            }
        }

        private void checkBoxSaran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaran.Checked)
            {
                saran = "Y";
            }
            else
            {
                saran = "T";
            }
        }

        private void checkBoxDisimpan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisimpan.Checked)
            {
                disimpan = "Y";
            }
            else
            {
                disimpan = "T";
            }
        }
    }
}