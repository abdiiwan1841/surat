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
    public partial class FormRekapSuratKeluar : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn,query,tahun,totalSurat;
        public FormRekapSuratKeluar()
        {
            InitializeComponent();
            tahun = dateTimeRekapSuratKeluar.Value.Year.ToString();
            getAllRekapSuratKeluar();
            getTotalRekapSuratKeluar();
        }

        public void getAllRekapSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT MONTH(tanggal_surat) as BULAN, count(nomor_surat_keluar) from surat_keluar WHERE YEAR(tanggal_surat)="+tahun+" GROUP BY BULAN ASC";
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
            
            dataRekapKeluar.ClearSelection();
            dataRekapKeluar.DataSource = rekap_surat;
            dataRekapKeluar.AutoResizeColumns();
            
        }

        private void dateTimeRekapSuratKeluar_ValueChanged(object sender, EventArgs e)
        {
            tahun = dateTimeRekapSuratKeluar.Value.Year.ToString();
            getAllRekapSuratKeluar();
            getTotalRekapSuratKeluar();
        }
        public void getTotalRekapSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT count(nomor_surat_keluar) as total_surat from surat_keluar WHERE YEAR(tanggal_surat)=" + tahun + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                //setDataTable(reader);
                while (reader.Read())
                {
                    totalSurat = reader["total_surat"].ToString();
                }
                textBoxTotalSurat.Text = totalSurat.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            conn.Close();
            
        }

        private void textBoxTotalSurat_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}