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
    public partial class FormSuBidangEdit : DevComponents.DotNetBar.OfficeForm
    {
        public string id_sub_bagian_bidang, nama_sub_bagian_bidang;
        private readonly FormSubBidang frm1;

        public FormSuBidangEdit(string id, string nama, FormSubBidang frm)
        {
            InitializeComponent();
            id_sub_bagian_bidang = id;
            nama_sub_bagian_bidang = nama;
            textBoxEditSubBidang.Text = nama;
            frm1 = frm;
        }

        private void buttonEditSubBidangKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditSubBidang_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "UPDATE sub_bagian_bidang SET nama_sub_bagian_bidang = @nama_sub_bagian_bidang WHERE id_sub_bagian_bidang = @id_sub_bagian_bidang";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_sub_bagian_bidang", id_sub_bagian_bidang);
            cmd.Parameters.AddWithValue("@nama_sub_bagian_bidang", textBoxEditSubBidang.Text);
            //MessageBox.Show(query);
            int sukses = cmd.ExecuteNonQuery();
            if (sukses > 0)
            {
                MessageBox.Show("Data berhasil diupdate", "Sukses");
                frm1.getAllSubBidang();
            }
            else
            {
                MessageBox.Show("Data gagal diupdate", "Gagal");
            }
            conn.Close();
        }
    }
}