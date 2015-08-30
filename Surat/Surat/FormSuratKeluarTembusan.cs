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
    public partial class FormSuratKeluarTembusan : DevComponents.DotNetBar.OfficeForm
    {
        public static List<string> list_tembusan = new List<string>();
        private string tembusan, tembusan_sebelumnya;
        private int index_tembusan;
        private string strconn, query;

        public FormSuratKeluarTembusan()
        {
            InitializeComponent();
        }

        private void getTembusan()
        {
            dataGridViewTembusanSuratKeluar.Rows.Clear();
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM tembusan_surat_Keluar WHERE nomor_surat_Keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //list_tembusan.Add(reader["nama_tembusan"].ToString());
                    dataGridViewTembusanSuratKeluar.Rows.Add(reader["nama_tembusan"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void tampil_tembusan()
        {
            dataGridViewTembusanSuratKeluar.Rows.Clear();
            foreach (var tembusan in list_tembusan)
            {
                dataGridViewTembusanSuratKeluar.Rows.Add(tembusan);
            }
        }

        private void FormSuratKeluarTembusan_Load(object sender, EventArgs e)
        {
            if (FormSuratKeluar.status == "Tambah")
            {
                tampil_tembusan();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                getTembusan();
            } 
        }

        private void buttonKembaliTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            tembusan = textBoxTembusanSuratKeluar.Text;
            if (FormSuratKeluar.status == "Tambah")
            {
                dataGridViewTembusanSuratKeluar.Rows.Add(tembusan);
                list_tembusan.Add(tembusan);
                textBoxTembusanSuratKeluar.Clear();
                textBoxTembusanSuratKeluar.Focus();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "INSERT INTO tembusan_surat_keluar VALUES(NULL, @nama_tembusan, @nomor_surat)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tembusan", tembusan);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                getTembusan();
            }
        }

        private void dataGridViewTembusanSuratKeluar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewTembusanSuratKeluar.SelectedRows)
            {
                textBoxTembusanSuratKeluar.Text = row.Cells[0].Value.ToString();
            }
            index_tembusan = dataGridViewTembusanSuratKeluar.CurrentCell.RowIndex;
        }

        private void buttonEditTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            if (FormSuratKeluar.status == "Tambah")
            {
                list_tembusan[index_tembusan] = textBoxTembusanSuratKeluar.Text;
                tampil_tembusan();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                foreach (DataGridViewRow row in dataGridViewTembusanSuratKeluar.SelectedRows)
                {
                    tembusan_sebelumnya = row.Cells[0].Value.ToString();
                }
                try
                {
                    query = "UPDATE tembusan_surat_Keluar SET nama_tembusan = @nama_tembusan " +
                            "WHERE nomor_surat_Keluar = @nomor_surat AND nama_tembusan = @tembusan_sebelumnya";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tembusan", textBoxTembusanSuratKeluar.Text);
                    cmd.Parameters.AddWithValue("@tembusan_sebelumnya", tembusan_sebelumnya);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                getTembusan();
            }
        }

        private void buttonHapusTembusanSuratKeluar_Click(object sender, EventArgs e)
        {
            if (FormSuratKeluar.status == "Tambah")
            {
                list_tembusan.RemoveAt(index_tembusan);
                tampil_tembusan();
            }
            else if (FormSuratKeluar.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "DELETE FROM tembusan_surat_Keluar WHERE nomor_surat_keluar =  @nomor_surat AND nama_tembusan = @tembusan";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratKeluar.nomor_surat);
                    cmd.Parameters.AddWithValue("@tembusan", textBoxTembusanSuratKeluar.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                getTembusan();
            }
        }

        private void FormSuratKeluarTembusan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratKeluar.status == "Edit")
            {
                dataGridViewTembusanSuratKeluar.Rows.Clear();
            }
        }

    }
}