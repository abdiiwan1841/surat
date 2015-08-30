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
    public partial class FormSuratKeluarLampiran : DevComponents.DotNetBar.OfficeForm
    {
        public FormSuratKeluarLampiran()
        {
            InitializeComponent();
        }
        public static List<string> list_lampiran = new List<string>();
        private string lampiran, lampiran_sebelumnya;
        private int index_lampiran;
        private string strconn, query;
        //public static bool opened = false;
        private void getLampiran()
        {
            dataGridViewLampiranSuratKeluar.Rows.Clear();
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM lampiran_surat_Keluar WHERE nomor_surat_Keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //list_lampiran.Add(reader["nama_lampiran"].ToString());
                    dataGridViewLampiranSuratKeluar.Rows.Add(reader["nama_lampiran"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void tampil_lampiran()
        {
            dataGridViewLampiranSuratKeluar.Rows.Clear();
            foreach (var lampiran in list_lampiran)
            {
                dataGridViewLampiranSuratKeluar.Rows.Add(lampiran);
            }
        }

        private void FormSuratKeluarLampiran_Load(object sender, EventArgs e)
        {
             if (FormSuratKeluar.status == "Tambah")
            {
                tampil_lampiran();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                getLampiran();
            } 
        }

        private void buttonKembaliLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            lampiran = textBoxLampiranSuratKeluar.Text;
            if (FormSuratMasuk.status == "Tambah")
            {
                dataGridViewLampiranSuratKeluar.Rows.Add(lampiran);
                list_lampiran.Add(lampiran);
                textBoxLampiranSuratKeluar.Clear();
                textBoxLampiranSuratKeluar.Focus();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "INSERT INTO lampiran_surat_keluar VALUES(NULL, @nama_lampiran, @nomor_surat)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_lampiran", lampiran);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close(); 
                getLampiran();
            }
        }

        private void dataGridViewLampiranSuratKeluar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLampiranSuratKeluar.SelectedRows)
            {
                textBoxLampiranSuratKeluar.Text = row.Cells[0].Value.ToString();
            }
            index_lampiran = dataGridViewLampiranSuratKeluar.CurrentCell.RowIndex;
        }

        private void buttonEditLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            if (FormSuratKeluar.status == "Tambah")
            {
                list_lampiran[index_lampiran] = textBoxLampiranSuratKeluar.Text;
                tampil_lampiran();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                foreach (DataGridViewRow row in dataGridViewLampiranSuratKeluar.SelectedRows)
                {
                    lampiran_sebelumnya = row.Cells[0].Value.ToString();
                }
                try
                {
                    query = "UPDATE lampiran_surat_keluar SET nama_lampiran = @nama_lampiran " +
                            "WHERE nomor_surat_keluar = @nomor_surat AND nama_lampiran = @lampiran_sebelumnya";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_lampiran", textBoxLampiranSuratKeluar.Text);
                    cmd.Parameters.AddWithValue("@lampiran_sebelumnya", lampiran_sebelumnya);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                getLampiran();
            }
        }

        private void buttonHapusLampiranSuratKeluar_Click(object sender, EventArgs e)
        {
            if (FormSuratKeluar.status == "Tambah")
            {
                list_lampiran.RemoveAt(index_lampiran);
                tampil_lampiran();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "DELETE FROM lampiran_surat_keluar WHERE nomor_surat_keluar =  @nomor_surat AND nama_lampiran = @lampiran";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                    cmd.Parameters.AddWithValue("@lampiran", textBoxLampiranSuratKeluar.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                getLampiran();
            }
        }

        private void FormSuratKeluarLampiran_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratKeluar.status == "Edit")
            {
                dataGridViewLampiranSuratKeluar.Rows.Clear();
            }
        }
    }
}