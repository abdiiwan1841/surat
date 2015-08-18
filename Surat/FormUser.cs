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
    public partial class FormUser : DevComponents.DotNetBar.OfficeForm
    {
        public FormUser()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable user = new DataTable();
            user.Load(reader);
            user.Columns[0].ColumnName = "ID User";
            user.Columns[1].ColumnName = "Username";
            user.Columns[2].ColumnName = "Password";
            user.Columns[3].ColumnName = "Nama";

            dataGridUser.ClearSelection();
            dataGridUser.DataSource = user;
        }

        public void getAllUser()
        {
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM user";
            MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void cariuser()
        {
            user usernames = new user();
            string cari = txtboxsearch.Text;

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            string query = "SELECT * FROM user WHERE usernames LIKE '%" + cari + "%'";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cari", cari);
            MySqlDataReader reader = cmd.ExecuteReader();

            setDataTable(reader);
            conn.Close();
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonTambahUser_Click(object sender, EventArgs e)
        {
            FormTambahUser tambahs = new FormTambahUser(this);
            tambahs.ShowDialog();
        }

        private void ButtonKembaliUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            getAllUser();
        }
    }
}