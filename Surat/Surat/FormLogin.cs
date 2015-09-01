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
                MessageBox.Show("Mencari Database, Harap tunggu...", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Database dbc = new Database();
                string strconnect = db.getString2();
                MySqlConnection connect = new MySqlConnection(strconnect);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("create database if not exists db_surat", connect);
                MySqlCommand cmd2 = new MySqlCommand("use db_surat", connect);
                MySqlCommand cmd1 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `user` (`id_user` int(11) NOT NULL AUTO_INCREMENT,`username` varchar(19) NOT NULL,`password` varchar(10) NOT NULL,`nama` varchar(40) NOT NULL,PRIMARY KEY (`id_user`),UNIQUE KEY `username` (`username`)) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd3 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `bagian_bidang` (`id_bagian_bidang` int(11) NOT NULL AUTO_INCREMENT,`nama_bagian_bidang` varchar(50) DEFAULT NULL, PRIMARY KEY (`id_bagian_bidang`)) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd4 = new MySqlCommand("insert  into `user`(`id_user`,`username`,`password`,`nama`) values (NULL,'admin','admin','admin')", connect);
                MySqlCommand cmd5 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `bagian_bidang` (`id_bagian_bidang` int(11) NOT NULL AUTO_INCREMENT,`nama_bagian_bidang` varchar(30) DEFAULT NULL,PRIMARY KEY (`id_bagian_bidang`)) ENGINE=InnoDB", connect);
                MySqlCommand cmd6 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `jenis_surat` (`id_jenis` int(11) NOT NULL AUTO_INCREMENT,`nama_jenis` varchar(20) DEFAULT NULL,PRIMARY KEY (`id_jenis`)) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                //MySqlCommand cmd7 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `lampiran` (`id_lampiran` int(11) NOT NULL AUTO_INCREMENT,`nama_lampiran` varchar(40) DEFAULT NULL,PRIMARY KEY (`id_lampiran`)) ENGINE=InnoDB", connect);
                MySqlCommand cmd8 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `surat_keluar` (`nomor_surat_keluar` varchar(40) NOT NULL,`perihal` varchar(40) DEFAULT NULL,`tanggal_surat` date DEFAULT NULL,`id_jenis` int(11) DEFAULT NULL,`penerima` varchar(50) DEFAULT NULL,`jumlah_lampiran` int(11) DEFAULT '0',`jabatan_tertanda` varchar(50) DEFAULT NULL,`tertanda` varchar(50) DEFAULT NULL,`keterangan` varchar(50) DEFAULT NULL,`distribusi_tanggal` date DEFAULT NULL,`isi_singkat` varchar(150) DEFAULT NULL,`gambar_surat` varchar(200) DEFAULT NULL,`id_user` int(11) DEFAULT NULL,`tanggal_update` date DEFAULT NULL,PRIMARY KEY (`nomor_surat_keluar`),KEY `surat_keluar_ibfk_1` (`id_jenis`),KEY `surat_keluar_ibfk_2` (`id_user`),CONSTRAINT `surat_keluar_ibfk_1` FOREIGN KEY (`id_jenis`) REFERENCES `jenis_surat` (`id_jenis`) ON DELETE SET NULL ON UPDATE CASCADE,CONSTRAINT `surat_keluar_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd9 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `surat_masuk` (`nomor_surat_masuk` varchar(40) NOT NULL,`perihal` varchar(40) DEFAULT NULL,`tanggal_surat` date DEFAULT NULL,`tanggal_terima` date DEFAULT NULL,`id_jenis` int(11) DEFAULT NULL,`sifat_surat` varchar(10) DEFAULT NULL,`pengirim` varchar(50) DEFAULT NULL,`alamat_pengirim` varchar(100) DEFAULT NULL,`penerima` varchar(50) DEFAULT NULL,`jumlah_lampiran` int(11) DEFAULT '0',`jabatan_tertanda` varchar(50) DEFAULT NULL,`tertanda` varchar(50) DEFAULT NULL,`distribusi_tanggal` date DEFAULT NULL,`isi_singkat` varchar(150) DEFAULT NULL,`keterangan` varchar(50) DEFAULT NULL,`gambar_surat` varchar(200) DEFAULT NULL,`id_user` int(11) DEFAULT NULL,`tanggal_update` date DEFAULT NULL,PRIMARY KEY (`nomor_surat_masuk`),KEY `surat_masuk_ibfk_1` (`id_jenis`),KEY `id_user` (`id_user`),CONSTRAINT `surat_masuk_ibfk_1` FOREIGN KEY (`id_jenis`) REFERENCES `jenis_surat` (`id_jenis`) ON DELETE SET NULL ON UPDATE CASCADE,  CONSTRAINT `surat_masuk_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd10 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `surat_disposisi` (  `nomor_surat` varchar(40) NOT NULL,  `nomor_agenda` varchar(40) DEFAULT NULL,  `tanggal_surat` date DEFAULT NULL,  `tanggal_terima` date DEFAULT NULL,  `tanggal_diteruskan` date DEFAULT NULL,  `asal` varchar(40) DEFAULT NULL,  `sifat` varchar(20) DEFAULT NULL,  `perihal` varchar(50) DEFAULT NULL,  `perintah` varchar(200) DEFAULT NULL, `disposisi_lain` varchar(200) DEFAULT NULL,  `diproses_diselesaikan` char(2) DEFAULT 'T',  `dilaksanakan` char(2) DEFAULT 'T',  `ditanggapi` char(2) DEFAULT 'T',  `diperhatikan` char(2) DEFAULT 'T',  `dilaporkan` char(2) DEFAULT 'T',  `diketahui` char(2) DEFAULT 'T',  `diedarkan` char(2) DEFAULT 'T',  `diperbanyak_dicopy` char(2) DEFAULT 'T',  `ditampung` char(2) DEFAULT 'T',  `dihadiri_diwakilkan` char(2) DEFAULT 'T',  `dikonsepkan_jawaban` char(2) DEFAULT 'T',  `dievaluasi_diteliti` char(2) DEFAULT 'T',  `saran_pendapat` char(2) DEFAULT 'T',  `disimpan_file_arsip` char(2) DEFAULT 'T',  `gambar_surat` varchar(200) DEFAULT 'no_image.png',  `id_user` int(11) DEFAULT NULL,  `tanggal_update` datetime DEFAULT NULL,  PRIMARY KEY (`nomor_surat`),  UNIQUE KEY `nomor_agenda` (`nomor_agenda`),  KEY `id_user` (`id_user`),  CONSTRAINT `surat_disposisi_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                //MySqlCommand cmd11 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `sub_bagian_bidang` (`id_sub_bagian_bidang` int(11) NOT NULL AUTO_INCREMENT,`id_bagian_bidang` int(11) DEFAULT NULL,`nama_sub_bagian_bidang` varchar(30) DEFAULT NULL,PRIMARY KEY (`id_sub_bagian_bidang`),KEY `id_bagian_bidang` (`id_bagian_bidang`),CONSTRAINT `sub_bagian_bidang_ibfk_1` FOREIGN KEY (`id_bagian_bidang`) REFERENCES `bagian_bidang` (`id_bagian_bidang`) ON DELETE SET NULL ON UPDATE SET NULL) ENGINE=InnoDB", connect);
                MySqlCommand cmd12 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `detail_bagian_bidang_surat_keluar` ( `nomor_surat_keluar` varchar(40) DEFAULT NULL,  `id_bagian_bidang` int(11) DEFAULT NULL,  KEY `nomor_surat_keluar` (`nomor_surat_keluar`),  KEY `id_sub_bagian_bidang` (`id_bagian_bidang`),  CONSTRAINT `detail_bagian_bidang_surat_keluar_ibfk_1` FOREIGN KEY (`nomor_surat_keluar`) REFERENCES `surat_keluar` (`nomor_surat_keluar`) ON DELETE SET NULL ON UPDATE CASCADE,  CONSTRAINT `detail_bagian_bidang_surat_keluar_ibfk_2` FOREIGN KEY (`id_bagian_bidang`) REFERENCES `bagian_bidang` (`id_bagian_bidang`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd13 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `detail_bagian_bidang_surat_masuk` (  `nomor_surat_masuk` varchar(40) DEFAULT NULL,  `id_bagian_bidang` int(11) DEFAULT NULL,  KEY `detail_bagian_bidang_surat_masuk_ibfk_1` (`nomor_surat_masuk`),  KEY `detail_bagian_bidang_surat_masuk_ibfk_2` (`id_bagian_bidang`),  CONSTRAINT `detail_bagian_bidang_surat_masuk_ibfk_1` FOREIGN KEY (`nomor_surat_masuk`) REFERENCES `surat_masuk` (`nomor_surat_masuk`) ON DELETE SET NULL ON UPDATE CASCADE,  CONSTRAINT `detail_bagian_bidang_surat_masuk_ibfk_2` FOREIGN KEY (`id_bagian_bidang`) REFERENCES `bagian_bidang` (`id_bagian_bidang`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd14 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `disposisi_bagian` (  `nomor_surat` varchar(40) DEFAULT NULL,  `id_bagian_bidang` int(11) DEFAULT NULL,  KEY `nomor_surat` (`nomor_surat`),  KEY `id_bagian` (`id_bagian_bidang`),  CONSTRAINT `disposisi_bagian_ibfk_1` FOREIGN KEY (`nomor_surat`) REFERENCES `surat_disposisi` (`nomor_surat`) ON DELETE SET NULL ON UPDATE CASCADE,  CONSTRAINT `disposisi_bagian_ibfk_2` FOREIGN KEY (`id_bagian_bidang`) REFERENCES `bagian_bidang` (`id_bagian_bidang`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd15 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `lampiran_surat_keluar` (  `id_lampiran` int(11) NOT NULL AUTO_INCREMENT,  `nama_lampiran` varchar(40) DEFAULT NULL,  `nomor_surat_keluar` varchar(40) DEFAULT NULL,  PRIMARY KEY (`id_lampiran`),  KEY `lampiran_surat_keluar_ibfk_1` (`nomor_surat_keluar`),  CONSTRAINT `lampiran_surat_keluar_ibfk_1` FOREIGN KEY (`nomor_surat_keluar`) REFERENCES `surat_keluar` (`nomor_surat_keluar`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd16 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `lampiran_surat_masuk` (  `id_lampiran` int(11) NOT NULL AUTO_INCREMENT,  `nama_lampiran` varchar(40) DEFAULT NULL,  `nomor_surat_masuk` varchar(40) DEFAULT NULL,  PRIMARY KEY (`id_lampiran`),  KEY `lampiran_surat_masuk_ibfk_1` (`nomor_surat_masuk`),  CONSTRAINT `lampiran_surat_masuk_ibfk_1` FOREIGN KEY (`nomor_surat_masuk`) REFERENCES `surat_masuk` (`nomor_surat_masuk`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB  DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd17 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tembusan_surat_keluar` (  `id_tembusan` int(11) DEFAULT NULL,  `nama_tembusan` varchar(40) DEFAULT NULL,  `nomor_surat_keluar` varchar(40) DEFAULT NULL,  KEY `tembusan_surat_keluar_ibfk_1` (`nomor_surat_keluar`),  CONSTRAINT `tembusan_surat_keluar_ibfk_1` FOREIGN KEY (`nomor_surat_keluar`) REFERENCES `surat_keluar` (`nomor_surat_keluar`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd18 = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tembusan_surat_masuk` (`id_tembusan` int(11) NOT NULL AUTO_INCREMENT,  `nama_tembusan` varchar(40) DEFAULT NULL,  `nomor_surat_masuk` varchar(40) DEFAULT NULL,  PRIMARY KEY (`id_tembusan`),  KEY `tembusan_surat_masuk_ibfk_1` (`nomor_surat_masuk`),  CONSTRAINT `tembusan_surat_masuk_ibfk_1` FOREIGN KEY (`nomor_surat_masuk`) REFERENCES `surat_masuk` (`nomor_surat_masuk`) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1", connect);
                MySqlCommand cmd19 = new MySqlCommand("insert  into  `jenis_surat`(`id_jenis`,`nama_jenis`) values (1,'Surat Dinas'),(2,'Nota Dinas'),(3,'Surat Undangan')", connect);
                MySqlCommand cmd20 = new MySqlCommand("insert  into  `bagian_bidang`(`id_bagian_bidang`,`nama_bagian_bidang`) values (1,'Tata Usaha'),(2,'Programa Siaran'),(3,'Pemberitaan'),(4,'Teknologi dan Media Baru'),(5,'Layanan dan Pengembangan')", connect);
                

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                //cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                cmd10.ExecuteNonQuery();
                //cmd11.ExecuteNonQuery();
                cmd12.ExecuteNonQuery();
                cmd13.ExecuteNonQuery();
                cmd14.ExecuteNonQuery();
                cmd15.ExecuteNonQuery();
                cmd16.ExecuteNonQuery();
                cmd17.ExecuteNonQuery();
                cmd18.ExecuteNonQuery();
                cmd19.ExecuteNonQuery();
                cmd20.ExecuteNonQuery();
                //cmd21.ExecuteNonQuery();
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