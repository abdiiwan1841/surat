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
    public partial class FormSuratKeluarTambah : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string nomor_surat, tgl_surat, jenis_surat,
                        perihal_surat, keterangan_surat, isi_surat,
                        tertanda_pengirim, jabatan_tertanda, penerima, distribusi_tanggal, lokasi_gambar, nama_gambar, sifat_surat;
        private List<string> list_bagian = new List<string>();
        private readonly FormSuratKeluar frm1;

        public FormSuratKeluarTambah(FormSuratKeluar frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void clear()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private bool cekValid()
        {
            bool error = false;
            if (textBoxNomorSuratKeluar.Text == "")
            {
                error = true;
                MessageBox.Show("Nomor surat belum diisi. Proses penyimpanan data dibatalkan");
            }
            return error;
        }

        private void tambah_tembusan()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                foreach (string tembusan in FormSuratKeluarTembusan.list_tembusan)
                {
                    query = "INSERT INTO tembusan_surat_keluar VALUES(NULL, @tembusan, @nomor_surat_keluar)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tembusan", tembusan);
                    cmd.Parameters.AddWithValue("@nomor_surat_keluar", nomor_surat);
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
                foreach (string lampiran in FormSuratKeluarLampiran.list_lampiran)
                {
                    query = "INSERT INTO lampiran_surat_keluar VALUES(NULL, @lampiran, @nomor_surat_keluar)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lampiran", lampiran);
                    cmd.Parameters.AddWithValue("@nomor_surat_keluar", nomor_surat);
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
                comboBoxJenisSuratKeluar.Items.Add(reader[0]);
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

        public void tambahSuratKeluar()
        {
            string lokasi_tujuan;
            nomor_surat = textBoxNomorSuratKeluar.Text;
            tgl_surat = dateTimeInputTanggalSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            jenis_surat = comboBoxJenisSuratKeluar.Text;
            perihal_surat = textBoxPerihalSuratKeluar.Text;
            keterangan_surat = textBoxKeteranganSuratKeluar.Text;
            isi_surat = textBoxIsiSuratKeluar.Text;
            penerima = textBoxPenerimaSuratKeluar.Text;
            jabatan_tertanda = textBoxJabatanTertandaSuratKeluar.Text;
            tertanda_pengirim = textBoxTertandaPengirimSuratKeluar.Text;
            distribusi_tanggal = dateTimeInputTanggalDistribusiSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            sifat_surat = comboBoxSifatSurat.Text;
            //distribusi_tanggal = dateTimeInputTanggalDistribusiSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            lokasi_tujuan = Application.StartupPath + "\\image_surat_keluar";

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            if (!Directory.Exists(lokasi_tujuan))
            {
                Directory.CreateDirectory(lokasi_tujuan);
            }
            if (pictureBoxGambarSuratKeluar.Image != null)
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
                query = "INSERT INTO surat_keluar(nomor_surat_keluar, perihal, tanggal_surat, id_jenis, sifat_surat, " +
                                                "penerima, jabatan_tertanda, tertanda, " +
                                                "distribusi_tanggal, isi_singkat, keterangan, gambar_surat, id_user, tanggal_update) " +
                        "VALUES(@nomor_surat, @perihal_surat, STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), " +
                                "@id_jenis, @sifat_surat, " +
                                "@penerima, @jabatan_tertanda, @tertanda_pengirim, " +
                                "STR_TO_DATE(@distribusi_tanggal, '%d-%m-%Y'), @isi_singkat, @keterangan, @gambar_surat, @id_user, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@id_jenis", getIdJenisSurat(jenis_surat));
                cmd.Parameters.AddWithValue("@sifat_surat", sifat_surat);
                cmd.Parameters.AddWithValue("@perihal_surat", perihal_surat);
                cmd.Parameters.AddWithValue("@tanggal_surat", tgl_surat);
                cmd.Parameters.AddWithValue("@penerima", penerima);
                cmd.Parameters.AddWithValue("@jabatan_tertanda", jabatan_tertanda);
                cmd.Parameters.AddWithValue("@tertanda_pengirim", tertanda_pengirim);
                cmd.Parameters.AddWithValue("@distribusi_tanggal", distribusi_tanggal);
                cmd.Parameters.AddWithValue("@isi_singkat", isi_surat);
                cmd.Parameters.AddWithValue("@keterangan", keterangan_surat);
                cmd.Parameters.AddWithValue("@gambar_surat", nama_gambar);
                cmd.Parameters.AddWithValue("@id_user", FormMain.id_user);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void buttonLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            form_lampiran.ShowDialog();
        }

        private void buttonTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarTembusan form_tembusan = new FormSuratKeluarTembusan();
            form_tembusan.ShowDialog();
        }

        private void tambahTembusan()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                foreach (string tembusan in FormSuratKeluarTembusan.list_tembusan)
                {
                    query = "INSERT INTO tembusan_surat_keluar VALUES(NULL, @tembusan, @nomor_surat_keluar)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tembusan", tembusan);
                    cmd.Parameters.AddWithValue("@nomor_surat_keluar", nomor_surat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void buttonTambahSuratKeluar_Click(object sender, EventArgs e)
        {
            tambahSuratKeluar();
            if (FormSuratKeluarLampiran.list_lampiran.Count != 0)
            {
                tambahLampiran();
            }
            if (FormSuratKeluarTembusan.list_tembusan.Count != 0)
            {
                tambahTembusan();
            }
            MessageBox.Show("Data berhasil ditambah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm1.getAllSuratKeluar();
        }

        private void buttonKembaliSuratKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuratKeluarTambah_Load(object sender, EventArgs e)
        {
            getJenisSurat();
            comboBoxJenisSuratKeluar.SelectedIndex = 0;
            comboBoxSifatSurat.SelectedIndex = 0;
            textBoxNomorSuratKeluar.Focus();
        }

        private void FormSuratKeluarTambah_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSuratKeluarLampiran.list_lampiran.Clear();
            FormSuratKeluarTembusan.list_tembusan.Clear();
        }

        private void buttonLampiranSuratKeluar_Click_1(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran lampirankeluar = new FormSuratKeluarLampiran();
            lampirankeluar.Show();
        }

        private void buttonTembusanSuratKeluar_Click_1(object sender, EventArgs e)
        {
            FormSuratKeluarTembusan Tembusankeluar = new FormSuratKeluarTembusan();
            Tembusankeluar.Show();
        }

        private void buttonTambahSuratKeluar_Click_1(object sender, EventArgs e)
        {
            if (cekValid())
                return;
            else
            {
                tambahSuratKeluar();
                if (FormSuratKeluarLampiran.list_lampiran.Count != 0)
                {
                    tambahLampiran();
                }
                if (FormSuratKeluarTembusan.list_tembusan.Count != 0)
                {
                    tambahTembusan();
                }
                if (list_bagian.Count != 0)
                {
                    tambahBagianBidang();
                }
            }
            clear();
            frm1.getAllSuratKeluar();
        }

        private void buttonKembaliSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    query = "INSERT INTO detail_bagian_bidang_surat_keluar VALUES(@nomor_surat, (SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @bagian))";
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

        private void buttonGambarSuratKeluar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lokasi_gambar = dialog.FileName;
                nama_gambar = Path.GetFileName(dialog.FileName);
                pictureBoxGambarSuratKeluar.Image = new Bitmap(dialog.FileName);
            }
        }

    }
}