using System;
using System.Collections.Generic;
using System.Text;

namespace Surat
{
    public class user
    {
        private string username, password, nama;

        public string getNama()
        {
            return nama;
        }
        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setUsername(string user)
        {
            this.username = user;
        }

        public void setPassword(string pass)
        {
            this.password = pass;
        }
        public void setNama(string nama)
        {
            this.nama=nama;
        }
    }
}
