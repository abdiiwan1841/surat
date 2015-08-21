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
        public string id_user, username, password, nama;
        public readonly FormUser frm2;
        public FormEditUser(string id, string name, string u_name, string psswrd, FormUser frm)
        {
            InitializeComponent();
            id_user = id;
            username = u_name;
            txtBoxUserEdit.Text = u_name;
            password = psswrd;
            txtBoxPasswordUser.Text = psswrd;
            nama = name;
            txtBoxNamaLengkapUser.Text = name;
            frm2 = frm;
        }

        private void ButtonKembaliUserEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonUserEdit_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@password", txtBoxPasswordUser.Text);
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