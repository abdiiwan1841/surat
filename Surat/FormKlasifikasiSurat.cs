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
    public partial class FormKlasifikasiSurat : DevComponents.DotNetBar.OfficeForm
    {
        public string id_jenis, nama_jenis;
 
        public FormKlasifikasiSurat()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable jenis_surat = new DataTable();
            jenis_surat.Load(reader);
            jenis_surat.Columns[0].ColumnName = "ID Jenis Surat";
            jenis_surat.Columns[1].ColumnName = "Jenis Surat";

            dataGridViewJenisSurat.ClearSelection();
            dataGridViewJenisSurat.DataSource = jenis_surat;
        }

        public void getAllJenisSurat()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM jenis_surat";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void cariJenisSurat()
        {
            JenisSurat jenis = new JenisSurat();
            string cari = textBoxCari.Text;
            
            Database db = new Database();
            string strconn =  db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM jenis_surat WHERE nama_jenis LIKE '%"+cari+"%'";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cari", cari);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void FormKlasifikasiSurat_Load(object sender, EventArgs e)
        {
            getAllJenisSurat();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormKlasifikasiSuratTambah formTambah = new FormKlasifikasiSuratTambah(this);
            formTambah.ShowDialog();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cariJenisSurat();
        }

        private void dataGridViewJenisSurat_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewJenisSurat.SelectedRows)
            {
                id_jenis = row.Cells[0].Value.ToString();
                nama_jenis = row.Cells[1].Value.ToString();
            }
        }

        private void buttonEditJenisSurat_Click(object sender, EventArgs e)
        {
            FormKlasifikasiSuratEdit form = new FormKlasifikasiSuratEdit(id_jenis, nama_jenis, this);
            form.ShowDialog();
        }

        private void buttonHapusJenisSurat_Click(object sender, EventArgs e)
        {
            string title = "Konfirmasi Penghapusan Data";
            string konten = "Apakah Anda yakin ingin menhapus data?";

            DialogResult result = MessageBox.Show(konten, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Database db = new Database();
                string strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                string query = "DELETE FROM jenis_surat WHERE id_jenis = @id_jenis";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_jenis", id_jenis);
                //MessageBox.Show(query);
                int sukses = cmd.ExecuteNonQuery();
                if (sukses > 0)
                {
                    MessageBox.Show("Data berhasil diupdate", "Sukses");
                    getAllJenisSurat();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate", "Gagal");
                }
                conn.Close();
            }
        }
    }
}