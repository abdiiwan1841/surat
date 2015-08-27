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

        public static string id_user;

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

            try
            {
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
                    id_user = reader[0].ToString();
                    this.Hide();
                    FormMain main = new FormMain();
                    main.Show();
                }
                conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Database tidak ditemukan atau User dan Password MySQL salah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database dbc = new Database();
                string strconnect = db.getString2();
                MySqlConnection connect = new MySqlConnection(strconnect);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("create database if not exists db_surat", connect);
                MySqlCommand cmd2 = new MySqlCommand("use db_surat", connect);
                MySqlCommand cmd3 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `user` (`id_user` int(11) NOT NULL AUTO_INCREMENT,`username` varchar(19) NOT NULL,`password` varchar(10) NOT NULL,`nama` varchar(40) NOT NULL,PRIMARY KEY (`id_user`),UNIQUE KEY `username` (`username`)) ENGINE=InnoDB", connect);
                MySqlCommand cmd4 = new MySqlCommand("insert  into `user`(`id_user`,`username`,`password`,`nama`) values (NULL,'a','a','a')", connect);
                MySqlCommand cmd5 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `bagian_bidang` (`id_bagian_bidang` int(11) NOT NULL AUTO_INCREMENT,`nama_bagian_bidang` varchar(30) DEFAULT NULL,PRIMARY KEY (`id_bagian_bidang`)) ENGINE=InnoDB", connect);
                MySqlCommand cmd6 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `jenis_surat` (`id_jenis` int(11) NOT NULL AUTO_INCREMENT,`nama_jenis` varchar(20) DEFAULT NULL,PRIMARY KEY (`id_jenis`)) ENGINE=InnoDB", connect);
                MySqlCommand cmd7 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `lampiran` (`id_lampiran` int(11) NOT NULL AUTO_INCREMENT,`nama_lampiran` varchar(40) DEFAULT NULL,PRIMARY KEY (`id_lampiran`)) ENGINE=InnoDB", connect);



                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                //cmd8.ExecuteNonQuery();
                connect.Close();
                cekLogin();
            }
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