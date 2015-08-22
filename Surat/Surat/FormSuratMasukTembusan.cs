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
        private string tembusan;
        private int index_tembusan;
        public static bool opened = false;

        public FormSuratMasukTembusan()
        {
            InitializeComponent();
        }

        private void getTembusan()
        {
            dataGridViewTembusanSuratMasuk.Rows.Clear();
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                string query = "SELECT * FROM tembusan_surat_masuk WHERE nomor_surat_masuk = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", FormSuratMasuk.nomor_surat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_tembusan.Add(reader[2].ToString());
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
            dataGridViewTembusanSuratMasuk.Rows.Add(tembusan);
            list_tembusan.Add(tembusan);
            textBoxTembusanSuratMasuk.Clear();
            textBoxTembusanSuratMasuk.Focus();
        }

        private void FormTembusanSuratMasuk_Load(object sender, EventArgs e)
        {
            if (FormSuratMasuk.status == "Tambah")
            {
                tampil_tembusan();
            }
            else if (FormSuratMasuk.status == "Edit" && opened == false)
            {
                getTembusan();
                tampil_tembusan();
            }
            else if (FormSuratMasuk.status == "Edit" && opened == true)
            {
                tampil_tembusan();
            }
            if (list_tembusan.Count == 0)
            {
                buttonEditTembusanSuratMasuk.Enabled = false;
                buttonHapusTembusanSuratMasuk.Enabled = false;
            }
            if (textBoxTembusanSuratMasuk.Text == "")
            {
                buttonEditTembusanSuratMasuk.Enabled = false;
                buttonTambahTembusanSuratMasuk.Enabled = false;
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
            list_tembusan[index_tembusan] = textBoxTembusanSuratMasuk.Text;
            tampil_tembusan();
        }

        private void buttonHapusTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            list_tembusan.RemoveAt(index_tembusan);
            tampil_tembusan();
        }

        private void textBoxTembusanSuratMasuk_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTembusanSuratMasuk.Text == "")
            {
                buttonTambahTembusanSuratMasuk.Enabled = false;
                buttonEditTembusanSuratMasuk.Enabled = false;
            }
            else
            {
                buttonTambahTembusanSuratMasuk.Enabled = true;
                if (list_tembusan.Count == 0)
                {
                    buttonEditTembusanSuratMasuk.Enabled = false;
                }
                else
                {
                    buttonEditTembusanSuratMasuk.Enabled = true;
                }
            }
        }

        private void FormSuratMasukTembusan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormSuratMasuk.status == "Edit")
            {
                dataGridViewTembusanSuratMasuk.Rows.Clear();
                opened = true;
            }
        }
    }
}