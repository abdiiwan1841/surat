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
                        isi_singkat, keterangan;
        private readonly FormSuratKeluar frm1;
        public FormSuratKeluarEdit(FormSuratKeluar frm)
        {
            InitializeComponent();
            frm1 = frm;
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
                query = "SELECT * FROM surat_Keluar WHERE nomor_surat_Keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    perihal = reader[1].ToString();
                    tanggal_surat = reader[2].ToString();
                    id_jenis = reader["id_jenis"].ToString();
                    penerima = reader["penerima"].ToString();
                    jabatan_tertanda = reader["jabatan_tertanda"].ToString();
                    tertanda = reader["tertanda"].ToString();
                    distribusi_tanggal = reader["distribusi_tanggal"].ToString();
                    isi_singkat = reader["isi_singkat"].ToString();
                    keterangan = reader["keterangan"].ToString();
                }
                textBoxNomorSuratKeluar.Text = nomor_surat;
                textBoxPerihalSuratKeluar.Text = perihal;
                dateTimeInputTanggalSuratKeluar.Value = DateTime.Parse(tanggal_surat);
                textBoxPenerimaSuratKeluar.Text = penerima;
                dateTimeInputTanggalDistribusiSuratKeluar.Value = DateTime.Parse(distribusi_tanggal);
                textBoxKeteranganSuratKeluar.Text = keterangan;
                textBoxIsiSuratKeluar.Text = isi_singkat;
                textBoxNomorSuratKeluar.SelectionStart = 0;
                textBoxNomorSuratKeluar.SelectionLength = textBoxNomorSuratKeluar.Text.Length;
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
            nomor_surat = textBoxNomorSuratKeluar.Text;
            tanggal_surat = dateTimeInputTanggalSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            jenis_surat = comboBoxJenisSuratKeluar.Text;
            perihal = textBoxPerihalSuratKeluar.Text;
            keterangan = textBoxKeteranganSuratKeluar.Text;
            isi_singkat = textBoxIsiSuratKeluar.Text;
            penerima = textBoxPenerimaSuratKeluar.Text;
            distribusi_tanggal = dateTimeInputTanggalDistribusiSuratKeluar.Value.Date.ToString("dd-MM-yyyy");
            jabatan_tertanda = textBoxJabatanTertandaSuratKeluar.Text;
            tertanda = textBoxTertandaPengirimSuratKeluar.Text;

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

          

            try
            {
                query = "UPDATE surat_keluar SET nomor_surat_keluar = @nomor_surat, perihal = @perihal_surat, " +
                                                "tanggal_surat = STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), " +
                                                "id_jenis = @id_jenis, " +
                                                "penerima = @penerima, " +
                                                "jabatan_tertanda = @jabatan_tertanda, tertanda = @tertanda, " +
                                                "distribusi_tanggal = STR_TO_DATE(@distribusi_tanggal, '%d-%m-%Y'), " +
                                                "isi_singkat = @isi_singkat, keterangan = @keterangan, " +
                                                "tanggal_update = CURDATE() " +
                        "WHERE nomor_surat_Keluar = @nomor_surat_sebelumnya";
                // MessageBox.Show(nama_gambar);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@id_jenis", getIdJenisSurat(jenis_surat));
                cmd.Parameters.AddWithValue("@perihal_surat", perihal);
                cmd.Parameters.AddWithValue("@tanggal_surat", tanggal_surat);
                cmd.Parameters.AddWithValue("@penerima", penerima);
                cmd.Parameters.AddWithValue("@jabatan_tertanda", jabatan_tertanda);
                cmd.Parameters.AddWithValue("@tertanda", tertanda);
                cmd.Parameters.AddWithValue("@distribusi_tanggal", distribusi_tanggal);
                cmd.Parameters.AddWithValue("@isi_singkat", isi_singkat);
                cmd.Parameters.AddWithValue("@keterangan", keterangan);
                cmd.Parameters.AddWithValue("@nomor_surat_sebelumnya", FormSuratKeluar.nomor_surat);
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

    }
}