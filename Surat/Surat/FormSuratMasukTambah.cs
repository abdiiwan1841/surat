using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Surat
{
    public partial class FormSuratMasukTambah : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string nomor_surat, tgl_surat, tgl_terima, jenis_surat, sifat_surat, 
                        perihal_surat, keterangan_surat, isi_surat, nama_gambar, lokasi_gambar, pengirim,
                        alamat_pengirim, penerima, jabatan_tertanda, tertanda, distribusi_tanggal;
        private readonly FormSuratMasuk frm1;
        private List<string> list_bagian = new List<string>();

        public FormSuratMasukTambah(FormSuratMasuk frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void tambahTembusan()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                foreach (string tembusan in FormSuratMasukTembusan.list_tembusan)
                {
                    query = "INSERT INTO tembusan_surat_masuk VALUES(NULL, @tembusan, @nomor_surat_masuk)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tembusan", tembusan);
                    cmd.Parameters.AddWithValue("@nomor_surat_masuk", nomor_surat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void tambahLampiran()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                foreach (string lampiran in FormSuratMasukLampiran.list_lampiran)
                {
                    query = "INSERT INTO lampiran_surat_masuk VALUES(NULL, @lampiran, @nomor_surat_masuk)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lampiran", lampiran);
                    cmd.Parameters.AddWithValue("@nomor_surat_masuk", nomor_surat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        public void getJenisSurat()
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

        public string getIdJenisSurat(string nama_jenis)
        {
            string id_jenis = "";
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            query = "SELECT id_jenis FROM jenis_surat WHERE nama_jenis = @nama_jenis";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_jenis", nama_jenis);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_jenis = reader[0].ToString();
            }
            conn.Close();
            return id_jenis;
        }

        private void tambahBagianBidang()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                foreach (var kabag in list_bagian)
                {
                    query = "INSERT INTO detail_bagian_bidang_surat_masuk VALUES(@nomor_surat, (SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @bagian))";
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

        public void tambahSuratMasuk()
        {
            string lokasi_tujuan;
            nomor_surat = textBoxNomorSuratMasuk.Text;
            tgl_surat = dateTimeInputTanggalSuratMasuk.Value.Date.ToString("dd-MM-yyyy");
            tgl_terima = dateTimeInputTanggalTerimaSuratMasuk.Value.Date.ToString("dd-MM-yyyy");
            jenis_surat = comboBoxJenisSuratMasuk.Text;
            sifat_surat = comboBoxSifatSuratMasuk.Text;
            perihal_surat = textBoxPerihalSuratMasuk.Text;
            keterangan_surat = textBoxKeteranganSuratMasuk.Text;
            isi_surat = textBoxIsiSuratMasuk.Text;
            pengirim = textBoxInstansiPengirimSuratMasuk.Text;
            alamat_pengirim = textBoxAlamatPengirimSuratMasuk.Text;
            penerima = textBoxPenerimaSuratMasuk.Text;
            jabatan_tertanda = textBoxJabatanTertandaSuratMasuk.Text;
            tertanda = textBoxTertandaPengirimSuratMasuk.Text;
            distribusi_tanggal = dateTimeInputTanggalDistribusiSuratMasuk.Value.Date.ToString("dd-MM-yyyy");
            lokasi_tujuan = Application.StartupPath + "\\image_surat_masuk";

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            if (!Directory.Exists(lokasi_tujuan))
            {
                Directory.CreateDirectory(lokasi_tujuan);
            }
            if (pictureBoxGambarSuratMasuk.Image != null)
            {
                File.Copy(lokasi_gambar, lokasi_tujuan + "\\" + nama_gambar, true);
            }
            else
            {
                nama_gambar = "no_image.png";
                File.Copy(Application.StartupPath + "\\no_image.png", lokasi_tujuan + "\\no_image.png", true);
            }

            try
            {
                query = "INSERT INTO surat_masuk(nomor_surat_masuk, perihal, tanggal_surat, tanggal_terima, id_jenis, "+
                                                "sifat_surat, pengirim, alamat_pengirim, penerima, jabatan_tertanda, tertanda, "+
                                                "distribusi_tanggal, isi_singkat, keterangan, gambar_surat, tanggal_update) "+
                        "VALUES(@nomor_surat, @perihal_surat, STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), "+
                                "STR_TO_DATE(@tanggal_terima, '%d-%m-%Y'), @id_jenis, "+
                                "@sifat_surat, @pengirim, @alamat_pengirim, @penerima, @jabatan_tertanda, @tertanda, "+
                                "STR_TO_DATE(@distribusi_tanggal, '%d-%m-%Y'), @isi_singkat, @keterangan, @gambar_surat, CURDATE())";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@sifat_surat", sifat_surat);
                cmd.Parameters.AddWithValue("@id_jenis", getIdJenisSurat(jenis_surat));
                cmd.Parameters.AddWithValue("@gambar_surat", nama_gambar);
                cmd.Parameters.AddWithValue("@perihal_surat", perihal_surat);
                cmd.Parameters.AddWithValue("@tanggal_surat", tgl_surat);
                cmd.Parameters.AddWithValue("@tanggal_terima", tgl_terima);
                cmd.Parameters.AddWithValue("@pengirim", pengirim);
                cmd.Parameters.AddWithValue("@alamat_pengirim", alamat_pengirim);
                cmd.Parameters.AddWithValue("@penerima", penerima);
                cmd.Parameters.AddWithValue("@jabatan_tertanda", jabatan_tertanda);
                cmd.Parameters.AddWithValue("@tertanda", tertanda);
                cmd.Parameters.AddWithValue("@distribusi_tanggal", distribusi_tanggal);
                cmd.Parameters.AddWithValue("@isi_singkat", isi_surat);
                cmd.Parameters.AddWithValue("@keterangan", keterangan_surat);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void FormTambahSuratMasuk_Load(object sender, EventArgs e)
        {
            getJenisSurat();
            comboBoxJenisSuratMasuk.SelectedIndex = 0;
            comboBoxSifatSuratMasuk.SelectedIndex = 0;
            textBoxNomorSuratMasuk.Focus();
        }

        private void buttonGambarSuratMasuk_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lokasi_gambar = dialog.FileName;
                nama_gambar = Path.GetFileName(dialog.FileName);
                pictureBoxGambarSuratMasuk.Image = new Bitmap(dialog.FileName);
            }
        }

        private void buttonTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            FormSuratMasukTembusan form_tembusan = new FormSuratMasukTembusan();
            form_tembusan.ShowDialog();
        }

        private void buttonTambahSuratMasuk_Click(object sender, EventArgs e)
        {
            tambahSuratMasuk();
            if (FormSuratMasukLampiran.list_lampiran.Count != 0)
            {
                tambahLampiran();
            }
            if (FormSuratMasukTembusan.list_tembusan.Count != 0)
            {
                tambahTembusan();
            }
            if (list_bagian.Count != 0)
            {
                tambahBagianBidang();
            }
            MessageBox.Show("Data berhasil ditambah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm1.getAllSuratMasuk();
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

        private void FormTambahSuratMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSuratMasukLampiran.list_lampiran.Clear();
            FormSuratMasukTembusan.list_tembusan.Clear();
        }

        private void checkBoxTataUsaha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTataUsaha.Checked)
            {
                list_bagian.Add("Tata Usaha");
            }
            else
            {
                list_bagian.Remove("Tata Usaha");
            }
        }

        private void checkBoxProgramaSiaran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProgramaSiaran.Checked)
            {
                list_bagian.Add("Programa Siaran");
            }
            else
            {
                list_bagian.Remove("Programa Siaran");
            }
        }

        private void checkBoxPemberitaan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPemberitaan.Checked)
            {
                list_bagian.Add("Pemberitaan");
            }
            else
            {
                list_bagian.Remove("Pemberitaan");
            }
        }

        private void checkBoxTeknologi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeknologi.Checked)
            {
                list_bagian.Add("Teknologi dan Media Baru");
            }
            else
            {
                list_bagian.Remove("Teknologi dan Media Baru");
            }
        }

        private void checkBoxLayanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLayanan.Checked)
            {
                list_bagian.Add("Layanan dan Pengembangan");
            }
            else
            {
                list_bagian.Remove("Layanan dan Pengembangan");
            }
        }
    }
}