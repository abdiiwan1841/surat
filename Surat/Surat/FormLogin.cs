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

    public partial class FormLogin : DevComponents.DotNetBar.OfficeForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cekLogin()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            user u = new user();
            u.setUsername(username);
            u.setPassword(password);
            username = u.getUsername();
            password = u.getPassword();

            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "SELECT * FROM user WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Username atau Password salah. Silahkan ulangi kembali.", "Kesalahan");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }
            else
            {
                this.Hide();
                FormMain main = new FormMain();
                main.Show();
            }
            conn.Close();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            cekLogin();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}