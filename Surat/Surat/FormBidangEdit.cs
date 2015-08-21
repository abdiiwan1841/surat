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
    public partial class FormBidangEdit : DevComponents.DotNetBar.OfficeForm
    {
        public string id_bagian_bidang, nama_bagian_bidang;
        private readonly FormBidang frm1;

        public FormBidangEdit(string id, string nama, FormBidang frm)
        {
            InitializeComponent();
            id_bagian_bidang = id;
            nama_bagian_bidang = nama;
            textBoxEditBidang.Text = nama;
            frm1 = frm;
        }




        private void buttonEditBidangKembali_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditBidang_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "UPDATE bagian_bidang SET nama_bagian_bidang = @nama_bagian_bidang WHERE id_bagian_bidang = @id_bagian_bidang";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bagian_bidang);
            cmd.Parameters.AddWithValue("@nama_bagian_bidang", textBoxEditBidang.Text);
            //MessageBox.Show(query);
            int sukses = cmd.ExecuteNonQuery();
            if (sukses > 0)
            {
                MessageBox.Show("Data berhasil diupdate", "Sukses");
                frm1.getAllBidang();
            }
            else
            {
                MessageBox.Show("Data gagal diupdate", "Gagal");
            }
            conn.Close();
        }
    }
}