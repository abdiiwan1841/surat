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
    public partial class FormBidang : DevComponents.DotNetBar.OfficeForm
    {
        public string id_bagian_bidang, nama_bagian_bidang;

        public FormBidang()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable bidang = new DataTable();
            bidang.Load(reader);
            bidang.Columns[0].ColumnName = "ID Bidang";
            bidang.Columns[1].ColumnName = "Bidang";

            dataGridViewBidang.ClearSelection();
            dataGridViewBidang.DataSource = bidang;
        }

        public void getAllBidang()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM bagian_bidang";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void cariBidang()
        {
            BidangBagian namaBidang = new BidangBagian();
            string cari = textBoxCariBidang.Text;

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM bagian_bidang WHERE nama_bagian_bidang LIKE '%" + cari + "%'";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cari", cari);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            getAllBidang();
        }


        private void textBoxCariBidang_TextChanged(object sender, EventArgs e)
        {
            cariBidang();
        }

        private void buttonBidangKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahBidang_Click(object sender, EventArgs e)
        {
            FormBidangTambah bidangTambah = new FormBidangTambah(this);
            bidangTambah.Show();
        }

        private void buttonEditBidang_Click(object sender, EventArgs e)
        {
            FormBidangEdit edit = new FormBidangEdit(id_bagian_bidang,nama_bagian_bidang,this);
            edit.ShowDialog();
        }

        private void dataGridViewBidang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBidang_SelectionChanged(object sender, EventArgs e) ////////BELUM BERHASIL
        {
            foreach (DataGridViewRow row in dataGridViewBidang.SelectedRows)
            {
                id_bagian_bidang = row.Cells[0].Value.ToString();
                nama_bagian_bidang = row.Cells[1].Value.ToString();
                textBox1.Text = id_bagian_bidang;
            }
        }

        private void buttonHapusBidang_Click(object sender, EventArgs e)
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

                string query = "DELETE FROM bagian_bidang WHERE id_bagian_bidang = @id_bagian_bidang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bagian_bidang);
                //MessageBox.Show(query);
                int sukses = cmd.ExecuteNonQuery();
                if (sukses > 0)
                {
                    MessageBox.Show("Data berhasil diupdate", "Sukses");
                    getAllBidang();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate", "Gagal");
                }
                conn.Close();
            }
        }
    }
}