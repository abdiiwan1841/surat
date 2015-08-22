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
        private string lampiran;
        private int index_lampiran;
        public static bool opened = false;

        private void getLampiran()
        {
            dataGridViewLampiranSuratMasuk.Rows.Clear();
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                string query = "SELECT * FROM lampiran_surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_lampiran.Add(reader["nama_lampiran"].ToString());
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
            foreach (var tembusan in list_lampiran)
            {
                dataGridViewLampiranSuratMasuk.Rows.Add(tembusan);
            }
        }

        private void FormSuratMasukLampiran_Load(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                tampil_lampiran();
            }
            else if (FormSuratMasuk.status == "Edit" && opened == false)
            {
                getLampiran();
                tampil_lampiran();
            }
            else if (FormSuratMasuk.status == "Edit" && opened == true)
            {
                tampil_lampiran();
            }
            if (list_lampiran.Count == 0)
            {
                buttonEditLampiranSuratMasuk.Enabled = false;
                buttonHapusLampiranSuratMasuk.Enabled = false;
            }
            if (textBoxLampiranSuratMasuk.Text == "")
            {
                buttonEditLampiranSuratMasuk.Enabled = false;
                buttonTambahLampiranSuratMasuk.Enabled = false;
            }
            //MessageBox.Show(FormSuratMasuk.status);
        }

        private void buttonKembaliLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLampiranSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLampiranSuratMasuk.SelectedRows)
            {
                textBoxLampiranSuratMasuk.Text = row.Cells[0].Value.ToString();
            }
            index_lampiran = dataGridViewLampiranSuratMasuk.CurrentCell.RowIndex;
        }

        private void buttonTambahLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            lampiran = textBoxLampiranSuratMasuk.Text;
            dataGridViewLampiranSuratMasuk.Rows.Add(lampiran);
            list_lampiran.Add(lampiran);
            textBoxLampiranSuratMasuk.Clear();
            textBoxLampiranSuratMasuk.Focus();
        }

        private void buttonEditLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            list_lampiran[index_lampiran] = textBoxLampiranSuratMasuk.Text;
            tampil_lampiran();
        }

        private void buttonHapusLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            list_lampiran.RemoveAt(index_lampiran);
            tampil_lampiran();
        }

        private void textBoxLampiranSuratMasuk_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLampiranSuratMasuk.Text == "")
            {
                buttonTambahLampiranSuratMasuk.Enabled = false;
                buttonEditLampiranSuratMasuk.Enabled = false;
            }
            else
            {
                buttonTambahLampiranSuratMasuk.Enabled = true;
                if (list_lampiran.Count == 0)
                {
                    buttonEditLampiranSuratMasuk.Enabled = false;
                }
                else
                {
                    buttonEditLampiranSuratMasuk.Enabled = true;
                }
            }
        }

        private void FormSuratMasukLampiran_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratMasuk.status == "Edit")
            {
                dataGridViewLampiranSuratMasuk.Rows.Clear();
                opened = true;
            }
        }
    }
}