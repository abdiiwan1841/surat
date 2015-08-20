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
    public partial class FormTambahSuratMasuk : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string nomor_surat, tgl_surat, tgl_terima, jenis_surat, sifat_surat, 
                        perihal_surat, keterangan_surat, isi_surat, nama_gambar, lokasi_gambar, pengirim,
                        alamat_pengirim, penerima, jabatan_tertanda, tertanda, distribusi_tanggal;

        public FormTambahSuratMasuk()
        {
            InitializeComponent();
        }

        private void tambahTembusan()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                foreach (string tembusan in FormTembusanSuratMasuk.list_tembusan)
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
            lokasi_tujuan = "";

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            if (pictureBoxGambarSuratMasuk.Image != null)
            {
                lokasi_tujuan = Application.StartupPath + "\\image_surat_masuk";
                if (!Directory.Exists(lokasi_tujuan))
                {
                    Directory.CreateDirectory(lokasi_tujuan);
                }
                File.Copy(lokasi_gambar, lokasi_tujuan + "\\" + nama_gambar, true);
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
                cmd.Parameters.AddWithValue("@gambar_surat", lokasi_tujuan + "\\" + nama_gambar);
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
            FormTembusanSuratMasuk form_tembusan = new FormTembusanSuratMasuk();
            form_tembusan.ShowDialog();
        }

        private void buttonTambahSuratMasuk_Click(object sender, EventArgs e)
        {
            tambahSuratMasuk();
            tambahTembusan();
            MessageBox.Show("Data berhasil ditambah", "Sukses");
        }

        private void buttonKembaliSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}