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
    public partial class FormTambahUser : DevComponents.DotNetBar.OfficeForm
    {
        private readonly FormUser frm2;
        public FormTambahUser(FormUser frm)
        {
            InitializeComponent();
            frm2 = frm;
        }

        private bool cekValid()
        {
            bool error = false;
            if (txtBoxusername.Text == "")
            {
                error = true;
                MessageBox.Show("Username harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBoxnama.Text == "")
            {
                error = true;
                MessageBox.Show("Nama harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBoxpassword.Text == "")
            {
                error = true;
                MessageBox.Show("Password harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPasswordLagi.Text == "")
            {
                error = true;
                MessageBox.Show("Password harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPasswordLagi.Text != txtBoxpassword.Text)
            {
                error = true;
                MessageBox.Show("Password yang diisikan tidak sama dengan password yang diisikan lainnya. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        private void tambahuser()
        {
            user u = new user();
            u.setUsername(txtBoxusername.Text);
            string username = u.getUsername();
            u.setPassword(txtBoxpassword.Text);
            string password = u.getPassword();
            u.setNama(txtBoxnama.Text);
            string nama = u.getNama();

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "INSERT INTO user VALUES(NULL, @username, @password, @nama)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nama", nama);

            int hasil = cmd.ExecuteNonQuery();
            if (hasil > 0)
            {
                MessageBox.Show("Data berhasil ditambah", "Sukses");
                frm2.getAllUser();

            }
            else
            {
                MessageBox.Show("Data gagal ditambah", "Gagal");
            }

            conn.Close();
        }
        
        private void ButtonKembaliTambahUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSimpanTambah_Click(object sender, EventArgs e)
        {
            if (cekValid())
            {
                return;
            }
            else
                tambahuser();
        }

    }
}