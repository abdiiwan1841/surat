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
    public partial class FormRekapDisposisi : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query, tahun, totalSurat;
        public FormRekapDisposisi()
        {
            InitializeComponent();
            tahun = dateTimeRekapDisposisi.Value.Year.ToString();
            getAllRekapDisposisi();
            getTotalRekapDisposisi();
        }
        public void getAllRekapDisposisi()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT MONTH(tanggal_terima) as BULAN, count(nomor_surat) from surat_disposisi WHERE YEAR(tanggal_terima)=" + tahun + " GROUP BY BULAN ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable rekap_surat = new DataTable();
            rekap_surat.Load(reader);
            rekap_surat.Columns[0].ColumnName = "Bulan ke-";
            rekap_surat.Columns[1].ColumnName = "Jumlah Surat Keluar";
            //jenis_surat.Columns[2].ColumnName = "Perihal";
            //jenis_surat.Columns[3].ColumnName = "Jenis Surat";

            dataRekapDisposisi.ClearSelection();
            dataRekapDisposisi.DataSource = rekap_surat;
            dataRekapDisposisi.AutoResizeColumns();

        }

        private void dateTimeRekapSuratKeluar_ValueChanged(object sender, EventArgs e)
        {
            tahun = dateTimeRekapDisposisi.Value.Year.ToString();
            getAllRekapDisposisi();
            getTotalRekapDisposisi();
        }
        public void getTotalRekapDisposisi()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT count(nomor_surat) as total_surat from surat_disposisi WHERE YEAR(tanggal_terima)=" + tahun + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                //setDataTable(reader);
                while (reader.Read())
                {
                    totalSurat = reader["total_surat"].ToString();
                }
                textBoxDisposisi.Text = totalSurat.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeRekapDisposisi_ValueChanged(object sender, EventArgs e)
        {
            tahun = dateTimeRekapDisposisi.Value.Year.ToString();
            getAllRekapDisposisi();
            getTotalRekapDisposisi();
        }
    }
}