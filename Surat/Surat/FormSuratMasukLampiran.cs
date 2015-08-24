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
    public partial class FormSuratMasukLampiran : DevComponents.DotNetBar.OfficeForm
    {
        public FormSuratMasukLampiran()
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
            dataGridViewLampiranSuratMasuk.Rows.Clear();
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM lampiran_surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //list_lampiran.Add(reader["nama_lampiran"].ToString());
                    dataGridViewLampiranSuratMasuk.Rows.Add(reader["nama_lampiran"].ToString());
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
            dataGridViewLampiranSuratMasuk.Rows.Clear();
            foreach (var lampiran in list_lampiran)
            {
                dataGridViewLampiranSuratMasuk.Rows.Add(lampiran);
            }
        }

        private void buttonKembaliLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            lampiran = textBoxLampiranSuratMasuk.Text;
            if (FormSuratMasuk.status == "Tambah")
            {
                dataGridViewLampiranSuratMasuk.Rows.Add(lampiran);
                list_lampiran.Add(lampiran);
                textBoxLampiranSuratMasuk.Clear();
                textBoxLampiranSuratMasuk.Focus();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "INSERT INTO lampiran_surat_masuk VALUES(NULL, @nama_lampiran, @nomor_surat)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_lampiran", lampiran);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
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

        private void FormLampiranSuratMasuk_Load(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                tampil_lampiran();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                getLampiran();
            } 
        }

        private void dataGridViewLampiranSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLampiranSuratMasuk.SelectedRows)
            {
                textBoxLampiranSuratMasuk.Text = row.Cells[0].Value.ToString();
            }
            index_lampiran = dataGridViewLampiranSuratMasuk.CurrentCell.RowIndex;
        }

        private void buttonEditLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                list_lampiran[index_lampiran] = textBoxLampiranSuratMasuk.Text;
                tampil_lampiran();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                foreach (DataGridViewRow row in dataGridViewLampiranSuratMasuk.SelectedRows)
                {
                    lampiran_sebelumnya = row.Cells[0].Value.ToString();
                }
                try
                {
                    query = "UPDATE lampiran_surat_masuk SET nama_lampiran = @nama_lampiran " +
                            "WHERE nomor_surat_masuk = @nomor_surat AND nama_lampiran = @lampiran_sebelumnya";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_lampiran", textBoxLampiranSuratMasuk.Text);
                    cmd.Parameters.AddWithValue("@lampiran_sebelumnya", lampiran_sebelumnya);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
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

        private void buttonHapusLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                list_lampiran.RemoveAt(index_lampiran);
                tampil_lampiran();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "DELETE FROM lampiran_surat_masuk WHERE nomor_surat_masuk =  @nomor_surat AND nama_lampiran = @lampiran";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                    cmd.Parameters.AddWithValue("@lampiran", textBoxLampiranSuratMasuk.Text);
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

        private void FormSuratMasukLampiran_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratMasuk.status == "Edit")
            {
                dataGridViewLampiranSuratMasuk.Rows.Clear();
            }
        }
    }
}