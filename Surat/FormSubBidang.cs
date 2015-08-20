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
    public partial class FormSubBidang : DevComponents.DotNetBar.OfficeForm
    {
        public string id_bagian_bidang, nama_bagian_bidang;
        public string id_sub_bagian_bidang, nama_sub_bagian_bidang;
        private readonly FormBidang frm1;

        public FormSubBidang(string id, string nama, FormBidang frm)
        {
            InitializeComponent();
            id_bagian_bidang = id;
            nama_bagian_bidang = nama;
            frm1 = frm;
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable subbidang = new DataTable();
            subbidang.Load(reader);
            subbidang.Columns[0].ColumnName = "ID Sub Bidang";
            subbidang.Columns[1].ColumnName = "Sub Bidang";
            subbidang.Columns[2].ColumnName = "Bidang";

            dataGridViewSubBidang.ClearSelection();
            dataGridViewSubBidang.DataSource = subbidang;
        }

        public void getAllSubBidang()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM sub_bagian_bidang where id_bagian_bidang = @id_bagian_bidang";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bagian_bidang);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void FormSubBidang_Load(object sender, EventArgs e)
        {
            getAllSubBidang();
        }

        private void buttonTambahSubBidang_Click(object sender, EventArgs e)
        {
            FormSubBidangTambah tambah = new FormSubBidangTambah(id_bagian_bidang, nama_bagian_bidang, this);
            tambah.ShowDialog();
        }

        private void buttonSubBidangKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBidang bidang = new FormBidang();
            bidang.Show();
        }

        private void buttonHapusSubBidang_Click(object sender, EventArgs e)
        {
            string title = "Konfirmasi Penghapusan Data";
            string konten = "Apakah Anda yakin ingin menhapus data?";

            DialogResult result = MessageBox.Show(konten, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Database db = new Database();
                string strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                string query = "DELETE FROM sub_bagian_bidang WHERE id_sub_bagian_bidang = @id_sub_bagian_bidang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_sub_bagian_bidang", id_sub_bagian_bidang);
                //MessageBox.Show(query);
                int sukses = cmd.ExecuteNonQuery();
                if (sukses > 0)
                {
                    MessageBox.Show("Data berhasil diupdate", "Sukses");
                    getAllSubBidang();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate", "Gagal");
                }
                conn.Close();
            }
        }

        private void dataGridViewSubBidang_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSubBidang.SelectedRows)
            {
                id_sub_bagian_bidang = row.Cells[0].Value.ToString();
                nama_sub_bagian_bidang = row.Cells[2].Value.ToString();
            }
        }

        private void buttonEditSubBidang_Click(object sender, EventArgs e)
        {
            FormSuBidangEdit edit = new FormSuBidangEdit(id_sub_bagian_bidang, nama_sub_bagian_bidang, this);
            edit.ShowDialog();
        }

        private void cariBidang()
        {
            SubBidangBagian namaBidang = new SubBidangBagian();
            string cari = textBoxCariSubBidang.Text;

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM sub_bagian_bidang WHERE nama_sub_bagian_bidang LIKE '%" + cari + "%'";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cari", cari);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void textBoxCariSubBidang_TextChanged(object sender, EventArgs e)
        {
            cariBidang();
        }
    }
}