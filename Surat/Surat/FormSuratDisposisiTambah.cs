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
    public partial class FormSuratDisposisiTambah : DevComponents.DotNetBar.OfficeForm
    {
        private string diproses, dilaksanakan, ditanggapi, diperhatikan, dilaporkan, diketahui, diedarkan, diperbanyak, ditampung, dihadiri, dikonsepkan, dievaluasi, saran, disimpan;
        private string nama_gambar, lokasi_gambar, lokasi_tujuan;
        private string strconn, query;
        private string nomor_surat, nomor_agenda, asal_surat, perihal, sifat_surat, tanggal_surat, tanggal_diterima, tanggal_diteruskan, isi_surat, lain, id_user;
        private List<string> list_kabag = new List<string>();
        private readonly FormSuratDisposisi frm;

        public FormSuratDisposisiTambah(FormSuratDisposisi frm1)
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

        private void tambahKabag()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                foreach (var kabag in list_kabag)
                {
                    query = "INSERT INTO disposisi_bagian VALUES(@nomor_surat, (SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @bagian))";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                    cmd.Parameters.AddWithValue("@bagian", kabag);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void tambahDisposisi()
        {
            nomor_surat = textBoxNomorSurat.Text;
            nomor_agenda = textBoxNomorAgenda.Text;
            asal_surat = textBoxAsalSurat.Text;
            perihal = textBoxPerihal.Text;
            sifat_surat = comboBoxSifatSurat.Text;
            isi_surat = textBoxIsiSurat.Text;
            lain = textBoxKeterangan.Text;
            tanggal_surat = dateTimeInputTanggalSurat.Value.Date.ToString("dd-MM-yyyy");
            if(tanggal_surat == "01-01-0001")
                tanggal_surat = "00-00-0000";
            tanggal_diterima = dateTimeInputTanggalDiterima.Value.Date.ToString("dd-MM-yyyy");
            if (tanggal_diterima == "01-01-0001")
                tanggal_diterima = "00-00-0000";
            tanggal_diteruskan = dateTimeInputDiteruskan.Value.Date.ToString("dd-MM-yyyy");
            if (tanggal_diterima == "01-01-0001")
                tanggal_diterima = "00-00-0000";
            lokasi_tujuan = Application.StartupPath + "\\image_surat_disposisi";
            id_user = FormMain.id_user;

            if (!Directory.Exists(lokasi_tujuan))
            {
                Directory.CreateDirectory(lokasi_tujuan);
            }
            if (pictureBoxGambarSurat.Image != null)
            { 
                File.Copy(lokasi_gambar, lokasi_tujuan + "\\" + nama_gambar, true);
            }
            else
            {
                nama_gambar = "no_image.png";
                File.Copy(Application.StartupPath + "\\no_image.png", lokasi_tujuan + "\\no_image.png", true);
            }

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "INSERT INTO surat_disposisi "+
                        "VALUES(@nomor_surat, @nomor_agenda, STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), "+
                                "STR_TO_DATE(@tanggal_diterima, '%d-%m-%Y'), STR_TO_DATE(@tanggal_diteruskan, '%d-%m-%Y'), "+
                                "@asal, @sifat, @perihal, @perintah, @lain, @diproses, @dilaksanakan, @ditanggapi, @diperhatikan, "+
                                "@dilaporkan, @diketahui, @diedarkan, @diperbanyak, @ditampung, @dihadiri, @dikonsepkan, "+
                                "@dievaluasi, @saran_pendapat, @disimpan, @gambar_surat, @id_user, NOW())";
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
                cmd.ExecuteNonQuery();
                tambahKabag();
                MessageBox.Show("Data berhasil ditambah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuratDisposisiTambah_Load(object sender, EventArgs e)
        {
            comboBoxSifatSurat.SelectedIndex = 0;
            diproses = "T";
            dilaksanakan = "T";
            ditanggapi = "T";
            diperhatikan = "T";
            dilaporkan = "T";
            diketahui = "T";
            diedarkan = "T";
            diperbanyak = "T";
            ditampung = "T";
            dihadiri = "T";
            dikonsepkan = "T";
            dievaluasi = "T";
            saran = "T";
            disimpan = "T";
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

        private void buttonGambarSurat_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                lokasi_gambar = dialog.FileName;
                nama_gambar = Path.GetFileName(lokasi_gambar);
                pictureBoxGambarSurat.Image = new Bitmap(lokasi_gambar);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (validasi())
            {
                return;
            }
            else
            {
                tambahDisposisi();
                frm.getAllSuratDisposisi();
            }
        }

        private void checkBoxKabagTataUsaha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKabagTataUsaha.Checked)
            {
                list_kabag.Add("Tata Usaha");
            }
            else
            {
                list_kabag.Remove("Tata Usaha");
            }
        }

        private void checkBoxKabidProgramaSiaran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKabidProgramaSiaran.Checked)
            {
                list_kabag.Add("Programa Siaran");
            }
            else
            {
                list_kabag.Remove("Programa Siaran");
            }
        }

        private void checkBoxKabidPemberitaan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKabidPemberitaan.Checked)
            {
                list_kabag.Add("Pemberitaan");
            }
            else
            {
                list_kabag.Remove("Pemberitaan");
            }
        }

        private void checkBoxKabidTeknologi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKabidTeknologi.Checked)
            {
                list_kabag.Add("Teknologi dan Media Baru");
            }
            else
            {
                list_kabag.Remove("Teknologi dan Media Baru");
            }
        }

        private void checkBoxKabidLPU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKabidLPU.Checked)
            {
                list_kabag.Add("Layanan dan Pengembangan");
            }
            else
            {
                list_kabag.Remove("Layanan dan Pengembangan");
            }
        }
    }
}