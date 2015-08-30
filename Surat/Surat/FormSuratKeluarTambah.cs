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
                        tertanda_pengirim,jabatan_tertanda,penerima;
        private readonly FormSuratKeluar frm1;

        public FormSuratKeluarTambah(FormSuratKeluar frm)
        {
            InitializeComponent();
            frm1 = frm;
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
            try
            {
                query = "INSERT INTO surat_keluar(nomor_surat_keluar, perihal, tanggal_surat, id_jenis, " +
                                                "penerima, jabatan_tertanda, tertanda, " +
                                                "isi_singkat, keterangan, tanggal_update) " +
                        "VALUES(@nomor_surat, @perihal_surat, STR_TO_DATE(@tanggal_surat, '%d-%m-%Y'), " +
                                "@id_jenis, " +
                                "@penerima, @jabatan_tertanda, @tertanda_pengirim, " +
                                "@isi_singkat, @keterangan,CURDATE())";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.Parameters.AddWithValue("@id_jenis", getIdJenisSurat(jenis_surat));
                cmd.Parameters.AddWithValue("@perihal_surat", perihal_surat);
                cmd.Parameters.AddWithValue("@tanggal_surat", tgl_surat);
                cmd.Parameters.AddWithValue("@penerima", penerima);
                cmd.Parameters.AddWithValue("@jabatan_tertanda", jabatan_tertanda);
                cmd.Parameters.AddWithValue("@tertanda_pengirim", tertanda_pengirim);
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

        private void textBoxNomorSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTanggalSuratKeluar_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimeInputTanggalSuratKeluar_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxJenisSuratKeluar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxIsiSuratKeluar_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPerihalSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKeteranganSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIsiSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            form_lampiran.ShowDialog();
        }

        private void textBoxInstansiPengirimSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxPengirimSuratKeluar_Enter(object sender, EventArgs e)
        {

        }


        private void textBoxTertandaPengirimSuratKeluar_TextChanged(object sender, EventArgs e)
        {

        }


        private void groupBoxPenerimaSuratKeluar_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPenerimaSuratKeluar_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonKembaliSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}