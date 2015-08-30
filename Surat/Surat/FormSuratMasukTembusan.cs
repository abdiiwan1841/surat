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
    public partial class FormSuratMasukTembusan : DevComponents.DotNetBar.OfficeForm
    {
        public static List<string> list_tembusan = new List<string>();
        private string tembusan, tembusan_sebelumnya;
        private int index_tembusan;
        private string strconn, query;
        //public static bool opened = false;

        public FormSuratMasukTembusan()
        {
            InitializeComponent();
        }

        private void getTembusan()
        {
            dataGridViewTembusanSuratMasuk.Rows.Clear();
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT * FROM tembusan_surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //list_tembusan.Add(reader["nama_tembusan"].ToString());
                    dataGridViewTembusanSuratMasuk.Rows.Add(reader["nama_tembusan"].ToString());
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
            dataGridViewTembusanSuratMasuk.Rows.Clear();
            foreach (var tembusan in list_tembusan)
            {
                dataGridViewTembusanSuratMasuk.Rows.Add(tembusan);
            }
        }

        private void buttonKembaliTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            tembusan = textBoxTembusanSuratMasuk.Text;
            if (FormSuratMasuk.status == "Tambah")
            {
                dataGridViewTembusanSuratMasuk.Rows.Add(tembusan);
                list_tembusan.Add(tembusan);
                textBoxTembusanSuratMasuk.Clear();
                textBoxTembusanSuratMasuk.Focus();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "INSERT INTO tembusan_surat_masuk VALUES(NULL, @nama_tembusan, @nomor_surat)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tembusan", tembusan);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
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

        private void FormTembusanSuratMasuk_Load(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                tampil_tembusan();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                getTembusan();
            }
            else if (FormSuratMasuk.status == "Detail")
            {
                this.Size = new System.Drawing.Size(305, 322);
                textBoxTembusanSuratMasuk.ReadOnly = true;
                getTembusan();
            }
        }

        private void dataGridViewTembusanSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewTembusanSuratMasuk.SelectedRows)
            {
                textBoxTembusanSuratMasuk.Text = row.Cells[0].Value.ToString();
            }
            index_tembusan = dataGridViewTembusanSuratMasuk.CurrentCell.RowIndex;
        }

        private void buttonEditTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                list_tembusan[index_tembusan] = textBoxTembusanSuratMasuk.Text;
                tampil_tembusan();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                foreach (DataGridViewRow row in dataGridViewTembusanSuratMasuk.SelectedRows)
                {
                    tembusan_sebelumnya = row.Cells[0].Value.ToString();
                }
                try
                {
                    query = "UPDATE tembusan_surat_masuk SET nama_tembusan = @nama_tembusan "+
                            "WHERE nomor_surat_masuk = @nomor_surat AND nama_tembusan = @tembusan_sebelumnya";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_tembusan", textBoxTembusanSuratMasuk.Text);
                    cmd.Parameters.AddWithValue("@tembusan_sebelumnya", tembusan_sebelumnya);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
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

        private void buttonHapusTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                list_tembusan.RemoveAt(index_tembusan);
                tampil_tembusan();
            }
            else if (FormSuratMasuk.status == "Edit")
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    query = "DELETE FROM tembusan_surat_masuk WHERE nomor_surat_masuk =  @nomor_surat AND nama_tembusan = @tembusan";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                    cmd.Parameters.AddWithValue("@tembusan", textBoxTembusanSuratMasuk.Text);
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


        private void FormSuratMasukTembusan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratMasuk.status == "Edit")
            {
                dataGridViewTembusanSuratMasuk.Rows.Clear();
            }
        }
    }
}