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
    public partial class FormTambahSuratMasuk : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;

        public FormTambahSuratMasuk()
        {
            InitializeComponent();
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
                comboBoxJenisSuratMasuk.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void FormTambahSuratMasuk_Load(object sender, EventArgs e)
        {
            getJenisSurat();
            comboBoxJenisSuratMasuk.SelectedIndex = 0;
            comboBoxSifatSuratMasuk.SelectedIndex = 0;
            textBoxNomorSuratMasuk.Focus();
        }

        private void buttonGambarSuratMasuk_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGambarSuratMasuk.Image = new Bitmap(dialog.FileName);
            }
        }
    }
}