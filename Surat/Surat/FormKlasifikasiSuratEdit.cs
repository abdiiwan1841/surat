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
    public partial class FormKlasifikasiSuratEdit : DevComponents.DotNetBar.OfficeForm
    {
        public string id_jenis, nama_jenis;
        private readonly FormKlasifikasiSurat frm1;

        public FormKlasifikasiSuratEdit(string id, string nama, FormKlasifikasiSurat frm)
        {
            InitializeComponent();
            id_jenis = id;
            nama_jenis = nama;
            textBoxEditJenisSurat.Text = nama;
            frm1 = frm;
        }

        private void buttonEditJenisSuratKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditJenisSurat_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "UPDATE jenis_surat SET nama_jenis = @nama_jenis WHERE id_jenis = @id_jenis";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_jenis", id_jenis);
            cmd.Parameters.AddWithValue("@nama_jenis", textBoxEditJenisSurat.Text);
            //MessageBox.Show(query);
            int sukses = cmd.ExecuteNonQuery();
            if (sukses > 0)
            {
                MessageBox.Show("Data berhasil diupdate", "Sukses");
                frm1.getAllJenisSurat();
            }
            else
            {
                MessageBox.Show("Data gagal diupdate", "Gagal");
            }
            conn.Close();
        }
    }
}