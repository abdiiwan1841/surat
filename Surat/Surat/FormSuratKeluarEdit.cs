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
    public partial class FormSuratKeluarEdit : DevComponents.DotNetBar.OfficeForm
    {
        private string query, strconn;
        private string nomor_surat, perihal, tanggal_surat,
                        id_jenis, jenis_surat,
                        penerima, jabatan_tertanda, tertanda, distribusi_tanggal,
                        isi_singkat, keterangan, bidang, sifat_surat, gambar_surat, nama_gambar, lokasi_gambar;
        private List<string> list_bagian = new List<string>();
        private readonly FormSuratKeluar frm1;
        public FormSuratKeluarEdit(FormSuratKeluar frm)
        {
            InitializeComponent();
            frm1 = frm;
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
                comboBoxSifatSurat.SelectedText = sifat_surat;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void tambahDistribusi(string nomor_surat, string bidang)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "INSERT INTO detail_bagian_bidang_surat_keluar VALUES(@nomor_surat, " +
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

        private void hapusDistribusi(string nomor_surat, string bidang)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "DELETE FROM detail_bagian_bidang_surat_keluar WHERE nomor_surat_keluar = @nomor_surat AND id_bagian_bidang = " +
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
                comboBoxJenisSuratKeluar.Items.Add(reader[0]);
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
                comboBoxJenisSuratKeluar.SelectedText = jenis_surat;
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
                query = "SELECT * FROM surat_keluar WHERE nomor_surat_keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    perihal = reader["perihal"].ToString();
                    tanggal_surat = reader["tanggal_surat"].ToString();
                    id_jenis = reader["id_jenis"].ToString();
                    sifat_surat = reader["sifat_surat"].ToString();
                    penerima = reader["penerima"].ToString();
                    jabatan_tertanda = reader["jabatan_tertanda"].ToString();
                    tertanda = reader["tertanda"].ToString();
                    keterangan = reader["keterangan"].ToString();
                    distribusi_tanggal = reader["distribusi_tanggal"].ToString();
                    isi_singkat = reader["isi_singkat"].ToString();
                    gambar_surat = reader["gambar_surat"].ToString();
                }
                textBoxNomorSuratKeluar.Text = nomor_surat;
                textBoxPerihalSuratKeluar.Text = perihal;
                dateTimeInputTanggalSuratKeluar.Value = DateTime.Parse(tanggal_surat);
                textBoxPenerimaSuratKeluar.Text = penerima;
                textBoxJabatanTertandaSuratKeluar.Text = jabatan_tertanda;
                textBoxTertandaPengirimSuratKeluar.Text = tertanda;
                dateTimeInputTanggalDistribusiSuratKeluar.Value = DateTime.Parse(distribusi_tanggal);
                textBoxKeteranganSuratKeluar.Text = keterangan;
                textBoxIsiSuratKeluar.Text = isi_singkat;
                pictureBoxGambarSuratKeluar.Image = new Bitmap(Application.StartupPath + "\\image_surat_keluar\\" + gambar_surat);
                textBoxNomorSuratKeluar.SelectionStart = 0;
                textBoxNomorSuratKeluar.SelectionLength = textBoxNomorSuratKeluar.Text.Length;
                nama_gambar = gambar_surat;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void editSuratKeluar()
        {
            string lokasi_tujuan;
            nomor_surat = textBoxNomorSuratKeluar.Text;
            tanggal_surat = dateTimeInputTanggalSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            jenis_surat = comboBoxJenisSuratKeluar.Text;
            sifat_surat = comboBoxSifatSurat.Text;
            perihal = textBoxPerihalSuratKeluar.Text;
            keterangan = textBoxKeteranganSuratKeluar.Text;
            isi_singkat = textBoxIsiSuratKeluar.Text;
            penerima = textBoxPenerimaSuratKeluar.Text;
            jabatan_tertanda = textBoxJabatanTertandaSuratKeluar.Text;
            tertanda = textBoxTertandaPengirimSuratKeluar.Text;
            distribusi_tanggal = dateTimeInputTanggalDistribusiSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            lokasi_tujuan = "";

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            if (pictureBoxGambarSuratKeluar.Image != null)
            {
                lokasi_tujuan = Application.StartupPath + "\\image_surat_keluar";
                if (!Directory.Exists(lokasi_tujuan))
                {
                    Directory.CreateDirectory(lokasi_tujuan);
                }
                if (!File.Exists(Application.StartupPath + "\\image_surat_keluar\\" + gambar_surat))
                {
                    File.Copy(lokasi_gambar, lokasi_tujuan + "\\" + nama_gambar, true);
                }
            }

            try
            {
                query = "UPDATE surat_keluar SET nomor_surat_keluar = @nomor_surat, perihal = @perihal_surat, " +
                                                "tanggal_surat = STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), " +
                                                "id_jenis = @id_jenis, " +
                                                "sifat_surat = @sifat_surat, " +
                                                "penerima = @penerima, " +
                                                "jabatan_tertanda = @jabatan_tertanda, tertanda = @tertanda, " +
                                                "distribusi_tanggal = STR_TO_DATE(@distribusi_tanggal, '%d-%m-%Y'), " +
                                                "isi_singkat = @isi_singkat, keterangan = @keterangan, " +
                                                "gambar_surat = @gambar_surat, id_user = @id_user, tanggal_update = NOW() " +
                        "WHERE nomor_surat_keluar = @nomor_surat_sebelumnya";
                // MessageBox.Show(nama_gambar);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@sifat_surat", sifat_surat);
                cmd.Parameters.AddWithValue("@id_jenis", getIdJenisSurat(jenis_surat));
                cmd.Parameters.AddWithValue("@gambar_surat", nama_gambar);
                cmd.Parameters.AddWithValue("@perihal_surat", perihal);
                cmd.Parameters.AddWithValue("@tanggal_surat", tanggal_surat);
                cmd.Parameters.AddWithValue("@penerima", penerima);
                cmd.Parameters.AddWithValue("@jabatan_tertanda", jabatan_tertanda);
                cmd.Parameters.AddWithValue("@tertanda", tertanda);
                cmd.Parameters.AddWithValue("@distribusi_tanggal", distribusi_tanggal);
                cmd.Parameters.AddWithValue("@isi_singkat", isi_singkat);
                cmd.Parameters.AddWithValue("@keterangan", keterangan);
                cmd.Parameters.AddWithValue("@nomor_surat_sebelumnya", FormSuratKeluar.nomor_surat);
                cmd.Parameters.AddWithValue("@id_user", FormMain.id_user);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Surat Keluar berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void FormSuratKeluarEdit_Load(object sender, EventArgs e)
        {
            nomor_surat = FormSuratKeluar.nomor_surat;
            getAllJenisSurat();
            getSuratKeluar();
            getJenisSurat(id_jenis);
            getSifatSurat(nomor_surat);

            checkBoxTataUsaha.CheckedChanged -= checkBoxTataUsaha_CheckedChanged;
            checkBoxLayanan.CheckedChanged -= checkBoxLayanan_CheckedChanged;
            checkBoxPemberitaan.CheckedChanged -= checkBoxPemberitaan_CheckedChanged;
            checkBoxProgramaSiaran.CheckedChanged -= checkBoxProgramaSiaran_CheckedChanged;
            checkBoxTeknologi.CheckedChanged -= checkBoxTeknologi_CheckedChanged;

            getDistribusi();

            checkBoxTataUsaha.CheckedChanged += checkBoxTataUsaha_CheckedChanged;
            checkBoxLayanan.CheckedChanged += checkBoxLayanan_CheckedChanged;
            checkBoxPemberitaan.CheckedChanged += checkBoxPemberitaan_CheckedChanged;
            checkBoxProgramaSiaran.CheckedChanged += checkBoxProgramaSiaran_CheckedChanged;
            checkBoxTeknologi.CheckedChanged += checkBoxTeknologi_CheckedChanged;
        }

        private void buttonKembaliSuratKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            form_lampiran.ShowDialog();
        }

        private void FormSuratKeluarEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSuratKeluarLampiran.list_lampiran.Clear();
            FormSuratKeluarTembusan.list_tembusan.Clear();
        }

        private void buttonTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarTembusan form_tembusan = new FormSuratKeluarTembusan();
            form_tembusan.ShowDialog();
        }

        private void buttonEditSuratKeluar_Click(object sender, EventArgs e)
        {
            editSuratKeluar();
            frm1.getAllSuratKeluar();
        }

        private void checkBoxTataUsaha_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Tata Usaha";
            if (checkBoxTataUsaha.Checked)
            {
                tambahDistribusi(nomor_surat, bidang);
            }
            else
            {
                hapusDistribusi(nomor_surat, bidang);
            }
        }

        private void checkBoxProgramaSiaran_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Programa Siaran";
            if (checkBoxProgramaSiaran.Checked)
            {
                tambahDistribusi(nomor_surat, bidang);
            }
            else
            {
                hapusDistribusi(nomor_surat, bidang);
            }
        }

        private void checkBoxPemberitaan_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Pemberitaan";
            if (checkBoxPemberitaan.Checked)
            {
                tambahDistribusi(nomor_surat, bidang);
            }
            else
            {
                hapusDistribusi(nomor_surat, bidang);
            }
        }

        private void checkBoxTeknologi_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Teknologi dan Media Baru";
            if (checkBoxTeknologi.Checked)
            {
                tambahDistribusi(nomor_surat, bidang);
            }
            else
            {
                hapusDistribusi(nomor_surat, bidang);
            }
        }

        private void checkBoxLayanan_CheckedChanged(object sender, EventArgs e)
        {
            bidang = "Layanan dan Pengembangan";
            if (checkBoxLayanan.Checked)
            {
                tambahDistribusi(nomor_surat, bidang);
            }
            else
            {
                hapusDistribusi(nomor_surat, bidang);
            }
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
            else
            {
                nama_gambar = gambar_surat;
            }
        }

    }
}