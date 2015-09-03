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
    public partial class FormEditUser : DevComponents.DotNetBar.OfficeForm
    {
        public string id_user, username, password, nama, password_baru;
        public readonly FormUser frm2;
        public FormEditUser(string id, string name, string u_name, string psswrd, FormUser frm)
        {
            InitializeComponent();
            Database db = new Database();
            string strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            string query = "SELECT password FROM user WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", u_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            password = reader["password"].ToString();
            //MessageBox.Show(password);
            conn.Close();
            id_user = id;
            username = u_name;
            txtBoxUserEdit.Text = u_name;
            nama = name;
            txtBoxNamaLengkapUser.Text = name;
            frm2 = frm;
        }

        private bool cekValid()
        {
            bool error = false;
            if (txtBoxUserEdit.Text == "")
            {
                error = true;
                MessageBox.Show("Username harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBoxNamaLengkapUser.Text == "")
            {
                error = true;
                MessageBox.Show("Nama harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBoxPasswordUser.Text == "")
            {
                error = true;
                MessageBox.Show("Password harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBoxPasswordUser.Text != password)
            {
                error = true;
                MessageBox.Show("Password lama yang diisikan tidak sama dengan password yang ada. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPasswordBaru.Text == "")
            {
                error = true;
                MessageBox.Show("Password baru harus diisi. Proses peyimpanan data dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        private void ButtonKembaliUserEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonUserEdit_Click(object sender, EventArgs e)
        {
            if (cekValid())
                return;
            else
            {
                Database db = new Database();
                string strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    string query = "UPDATE user SET username = @username, password = @password, nama = @nama WHERE id_user = @id_user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    cmd.Parameters.AddWithValue("@username", txtBoxUserEdit.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPasswordBaru.Text);
                    cmd.Parameters.AddWithValue("@nama", txtBoxNamaLengkapUser.Text);
                    //MessageBox.Show(query);
                    int sukses = cmd.ExecuteNonQuery();
                    if (sukses > 0)
                    {
                        MessageBox.Show("Data berhasil diupdate", "Sukses");
                        frm2.getAllUser();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diupdate", "Gagal");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }
    }
}