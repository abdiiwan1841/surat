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
        public string id_sub_bagian_bidang, nama_sub_bagian_bidang,id_bidang,nama_bidang,id_bagian;
        private readonly FormBidang frm1;

        public FormSubBidang(string id, string nama, FormBidang frm)
        {
            InitializeComponent();
            id_bagian_bidang = id;
            nama_bagian_bidang = nama;
            getBidang();
            //getIdBidang(nama);
            comboBoxBidang.SelectedValue = id_bagian_bidang;
            comboBoxBidang.SelectedText = nama_bagian_bidang;
            frm1 = frm;
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable subbidang = new DataTable();
            subbidang.Load(reader);
            subbidang.Columns[0].ColumnName = "ID Sub Bidang";
            subbidang.Columns[1].ColumnName = "ID Bidang";
            subbidang.Columns[2].ColumnName = "Sub Bidang";
            subbidang.Columns[3].ColumnName = "Bidang";

            dataGridViewSubBidang.ClearSelection();
            dataGridViewSubBidang.DataSource = subbidang;
        }

        public void getAllSubBidang()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT sub.*,bdg.nama_bagian_bidang FROM sub_bagian_bidang as sub join bagian_bidang as bdg USING (id_bagian_bidang) where  id_bagian_bidang = @id_bagian_bidang";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bagian_bidang);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        public void getAllSubBidang2(string id_bidang)
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM sub_bagian_bidang where id_bagian_bidang = @id_bidang";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_bagian_bidang", id_bidang);
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
            //pilihBidang();
            //MessageBox.Show(id_bagian);
            tambah.ShowDialog();
            
        }

        private void buttonSubBidangKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBidang bidang = new FormBidang();
            //bidang.Show();
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

        public void getBidang()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "SELECT * FROM bagian_bidang";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxBidang.SelectedValue = reader[0];
                comboBoxBidang.Items.Add(reader[1]);
            }
            conn.Close();
        }

        public string getIdBidang(string nama_bagian)
        {
            string id_bagian = "";
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "SELECT id_bagian_bidang FROM bagian_bidang WHERE nama_bagian_bidang = @nama_bagian";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_bagian", nama_bagian);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_bagian = reader[0].ToString();
            }
            conn.Close();
            MessageBox.Show(id_bagian);
            return id_bagian;
            
        }

        private void comboBoxBidang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormSubBidang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormBidang bidang = new FormBidang();
            bidang.Show();
        }

        private void buttonPilihBidang_Click(object sender, EventArgs e)
        {

            pilihBidang();
            
        }

        private string pilihBidang()
        {
            
            nama_bidang = comboBoxBidang.SelectedItem.ToString();
            //getAllSubBidang2(id_bidang);
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT sub.*,bdg.nama_bagian_bidang FROM sub_bagian_bidang as sub join bagian_bidang as bdg USING (id_bagian_bidang) where  nama_bagian_bidang = @nama_bidang";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_bidang", nama_bidang);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);


            conn.Close();
            getIdBidang(nama_bidang);
            return id_bagian;
        }
    }
}