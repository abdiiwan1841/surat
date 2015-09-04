using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace Surat
{
    public partial class FormSuratDisposisi : DevComponents.DotNetBar.OfficeForm
    {
        private string strconn, query;
        private string kriteria, cari;
        public static string nomor_surat;
        

        public FormSuratDisposisi()
        {
            InitializeComponent();
        }

        private void setDataTable(MySqlDataReader reader)
        {
            DataTable disposisi = new DataTable();
            disposisi.Load(reader);
            disposisi.Columns[0].ColumnName = "Nomor Urut";
            disposisi.Columns[1].ColumnName = "Nomor Surat";
            disposisi.Columns[2].ColumnName = "Nomor Agenda";
            disposisi.Columns[3].ColumnName = "Tanggal Surat";
            disposisi.Columns[4].ColumnName = "Tanggal Diterima";
            disposisi.Columns[5].ColumnName = "Tanggal Diteruskan";
            disposisi.Columns[6].ColumnName = "Asal Surat";
            disposisi.Columns[7].ColumnName = "Perihal";
            disposisi.Columns[8].ColumnName = "Sifat Surat";
            //dataGridViewSuratDisposisi.ClearSelection();
            dataGridViewSuratDisposisi.DataSource = disposisi;
            labelJumlahSurat.Text = "Jumlah Surat Disposisi : " + dataGridViewSuratDisposisi.RowCount.ToString();
        }

        private void getSuratDisposisi(string cari)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT @s:=@s+1 AS nomor, nomor_surat, nomor_agenda, DATE_FORMAT(tanggal_surat, '%d-%m-%Y'), DATE_FORMAT(tanggal_terima, '%d-%m-%Y'), " +
                        "DATE_FORMAT(tanggal_diteruskan, '%Y-%m-%d'), asal, perihal, sifat " +
                        "FROM surat_disposisi, (SELECT @s:=0) AS s WHERE "+kriteria+" LIKE '%"+cari+"%' ORDER BY nomor";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //MessageBox.Show(kriteria);
                MySqlDataReader reader = cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        public void getAllSuratDisposisi()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "SELECT @s:=@s+1 AS nomor, nomor_surat, nomor_agenda, DATE_FORMAT(tanggal_surat, '%d-%m-%Y'), DATE_FORMAT(tanggal_terima, '%d-%m-%Y'), "+
                        "DATE_FORMAT(tanggal_diteruskan, '%d-%m-%Y'), asal, perihal, sifat " +
                        "FROM surat_disposisi, (SELECT @s:=0) AS s ORDER BY nomor ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader =  cmd.ExecuteReader();
                setDataTable(reader);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void hapusDisposisiBidang(string nomor_surat)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            try
            {
                query = "DELETE FROM disposisi_bagian WHERE nomor_surat = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void hapusSuratDisposisi(string nomor_surat)
        {
            DialogResult result =  MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();
                try
                {
                    hapusDisposisiBidang(nomor_surat);
                    query = "DELETE FROM surat_disposisi WHERE nomor_surat = @nomor_surat";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }  
        }

        private void FormSuratDisposisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form_main = new FormMain();
            form_main.Show();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahSuratDisposisi_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiTambah form_tambah = new FormSuratDisposisiTambah(this);
            form_tambah.ShowDialog();
        }

        private void FormSuratDisposisi_Load(object sender, EventArgs e)
        {
            kriteria = "nomor_surat";
            getAllSuratDisposisi();
        }

        private void radioButtonNomorSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_surat";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonNomorAgenda_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "nomor_agenda";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonAsalSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "asal";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonPerihalSuratMasuk_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "perihal";
            textBoxCari.BringToFront();
            getAllSuratDisposisi();
        }

        private void radioButtonTanggalSurat_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "tanggal_surat";
            textBoxCari.SendToBack();
            dataGridViewSuratDisposisi.BringToFront();
            getAllSuratDisposisi();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cari = textBoxCari.Text;
            getSuratDisposisi(cari);
        }

        private void dateTimeInputTanggalSurat_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            cari = dateTimeInputTanggalSurat.Value.Date.ToString("yyyy-MM-dd");
            //MessageBox.Show(cari);
            getSuratDisposisi(cari);
        }

        private void dataGridViewSuratDisposisi_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSuratDisposisi.SelectedRows)
            {
                nomor_surat = row.Cells[1].Value.ToString();
            }
        }

        private void buttonHapusSuratDisposisi_Click(object sender, EventArgs e)
        {
            hapusSuratDisposisi(nomor_surat);
            getAllSuratDisposisi();
        }

        private void buttonEditSuratDisposisi_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiEdit form_edit = new FormSuratDisposisiEdit(this);
            form_edit.ShowDialog();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            FormSuratDisposisiDetail form_detail = new FormSuratDisposisiDetail();
            form_detail.ShowDialog();
        }

        public void GenerateExcel2007(string p_strPath, DataSet p_dsSrc)
        {
            using (ExcelPackage objExcelPackage = new ExcelPackage())
            {
                foreach (DataTable dtSrc in p_dsSrc.Tables)
                {
                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dtSrc.TableName);

                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dtSrc, true, OfficeOpenXml.Table.TableStyles.Medium1);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 11));
                    objWorksheet.Cells.AutoFitColumns();
                    objWorksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells["A1:L1"])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Gray);

                        objWorksheet.Column(1).Width = 25;
                        objWorksheet.Column(2).Width = 20;
                        objWorksheet.Column(3).Width = 17;
                        objWorksheet.Column(4).Width = 19;
                        objWorksheet.Column(5).Width = 19;
                        objWorksheet.Column(6).Width = 15;
                        objWorksheet.Column(7).Width = 19;
                        objWorksheet.Column(8).Width = 19;
                        objWorksheet.Column(9).Width = 25;
                        objWorksheet.Column(10).Width = 19;
                        objWorksheet.Column(11).Width = 19;
                        objWorksheet.Column(12).Width = 19;

                        objWorksheet.Column(1).Style.WrapText = true;
                        objWorksheet.Column(2).Style.WrapText = true;
                        objWorksheet.Column(3).Style.WrapText = true;
                        objWorksheet.Column(4).Style.WrapText = true;
                        objWorksheet.Column(5).Style.WrapText = true;
                        objWorksheet.Column(6).Style.WrapText = true;
                        objWorksheet.Column(7).Style.WrapText = true;
                        objWorksheet.Column(8).Style.WrapText = true;
                        objWorksheet.Column(9).Style.WrapText = true;
                        objWorksheet.Column(10).Style.WrapText = true;
                        objWorksheet.Column(11).Style.WrapText = true;
                        objWorksheet.Column(12).Style.WrapText = true;

                        objWorksheet.Column(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(2).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(3).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(4).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(5).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(6).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(7).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(8).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(9).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(10).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(11).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objWorksheet.Column(12).Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        objWorksheet.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(6).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(7).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(8).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(9).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(10).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(11).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        objWorksheet.Column(12).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                        objWorksheet.Cells["A1:L1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    //objWorksheet.Row(2).Style.Border.BorderAround(ExcelBorderStyle.Thin);

                }

                //Write it back to the client    
                if (File.Exists(p_strPath))
                    File.Delete(p_strPath);

                //Create excel file on physical disk    
                FileStream objFileStrm = File.Create(p_strPath);
                objFileStrm.Close();

                //Write content to excel file    
                File.WriteAllBytes(p_strPath, objExcelPackage.GetAsByteArray());
            }
        }    

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel 2007/2010 File|*.xlsx";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string file = dialog.FileName;
                //MessageBox.Show(dialog.FileName);
                Database db = new Database();
                strconn = db.getString();
                MySqlConnection conn = new MySqlConnection(strconn);
                try
                {
                    query = "SELECT nomor_surat AS 'Nomor Surat', nomor_agenda AS 'Nomor Agenda', "+
                                    "DATE_FORMAT(tanggal_surat, '%d-%m-%Y') AS 'Tanggal Surat', DATE_FORMAT(tanggal_terima, '%d-%m-%Y') AS 'Tanggal Terima', " +
                                    "DATE_FORMAT(tanggal_diteruskan, '%d-%m-%Y') AS 'Tanggal Diteruskan', asal AS 'Asal Surat', " +
                                    "sifat AS 'Sifat Surat', perihal AS 'Perihal', perintah AS 'Isi Perintah Surat', " +
                                    "disposisi_lain AS 'Diteruskan', " +
                                    "u.nama AS 'Penginput Data', " +
                                    "DATE_FORMAT(tanggal_update, '%d-%m-%Y %H:%i:%s') AS 'Waktu Update Terakhir' " +
                            "FROM surat_disposisi JOIN user AS u USING(id_user) ORDER BY tanggal_surat ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //cmd.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataSet data = new DataSet();
                    adapter.Fill(data);

                    GenerateExcel2007(file, data);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FormRekapDisposisi rekap = new FormRekapDisposisi();
            rekap.ShowDialog();
        }

        private void radioButtonTanggalTerima_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "tanggal_terima";
            textBoxCari.SendToBack();
            dataGridViewSuratDisposisi.BringToFront();
            getAllSuratDisposisi();
        }
    }
}