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
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System.IO;

namespace Surat
{
    public partial class FormSuratKeluar : DevComponents.DotNetBar.OfficeForm
    {
        private string query, strconn, kriteria, cari;
        public static string nomor_surat;
        public static string status;

        public FormSuratKeluar()
        {
            InitializeComponent();
        }

        public void setDataTable(MySqlDataReader reader)
        {
            DataTable jenis_surat = new DataTable();
            jenis_surat.Load(reader);
            jenis_surat.Columns[0].ColumnName = "Nomor Urut";
            jenis_surat.Columns[1].ColumnName = "Nomor Surat";
            jenis_surat.Columns[2].ColumnName = "Tanggal Surat";
            jenis_surat.Columns[3].ColumnName = "Perihal";
            jenis_surat.Columns[4].ColumnName = "Jenis Surat";
            jenis_surat.Columns[5].ColumnName = "Sifat Surat";

            dataGridViewSuratKeluar.ClearSelection();
            dataGridViewSuratKeluar.DataSource = jenis_surat;

            dataGridViewSuratKeluar.AutoResizeColumns();
            labelJumlahSurat.Text = "Jumlah Surat Keluar : "+dataGridViewSuratKeluar.RowCount.ToString();
        }

        public void getSuratID()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            conn.Close();


        }

        public void getAllSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT @s:=@s+1 AS nomor, nomor_surat_Keluar, tanggal_surat,perihal, j.nama_jenis AS jenis_surat, sifat_surat " +
                                "FROM surat_Keluar JOIN jenis_surat AS j USING(id_jenis),(SELECT @s:= 0) AS s ORDER BY tanggal_surat ASC";
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

        private void deleteSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM surat_keluar WHERE nomor_surat_keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                //MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "Sukses");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void deleteTembusanSuratKeluar()
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                string query = "DELETE FROM tembusan_surat_keluar WHERE nomor_surat_keluar = @nomor_surat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomor_surat", nomor_surat);
                //MessageBox.Show(query);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void FormSuratKeluar_Load(object sender, EventArgs e)
        {
            getAllSuratKeluar();
            kriteria = "nomor_surat_keluar";
        }

        private void buttonTambahSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            status = "Tambah";
            FormSuratKeluarTambah form_tambah = new FormSuratKeluarTambah(this);
            form_tambah.ShowDialog();
        }

        private void radioButtonNomorSuratKeluar_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInputSuratKeluar.SendToBack();
            textBoxCariSuratKeluar.BringToFront();
            kriteria = "nomor_surat_keluar";
        }

        private void radioButtonPerihalSuratKeluar_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInputSuratKeluar.SendToBack();
            textBoxCariSuratKeluar.BringToFront();
            kriteria = "perihal";
        }

        private void textBoxCariSuratKeluar_TextChanged(object sender, EventArgs e)
        {
            string cari;
            cari = textBoxCariSuratKeluar.Text;

            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT @s:=@s+1 AS nomor,nomor_surat_keluar, tanggal_surat,perihal,nama_jenis AS jenis_surat, sifat_surat " +
                                "FROM surat_Keluar JOIN jenis_surat AS j USING(id_jenis) , (SELECT @s:= 0) AS s " +
                                "WHERE "+kriteria+" LIKE '%"+cari+"%' ORDER BY nomor ASC";
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

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuratKeluar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form_main = new FormMain();
            form_main.Show();
        }

        private void buttonHapusSuratKeluar_Click(object sender, EventArgs e)
        {
            string title = "Konfirmasi Penghapusan Data";
            string konten = "Apakah Anda yakin ingin menghapus data?";

            DialogResult result = MessageBox.Show(konten, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                deleteTembusanSuratKeluar();
                deleteSuratKeluar();
                getAllSuratKeluar();
            }
        }

        private void dataGridViewSuratKeluar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSuratKeluar.SelectedRows)
            {
                nomor_surat = row.Cells[1].Value.ToString();
            }
        }

        private void buttonEditSuratKeluar_Click(object sender, EventArgs e)
        {
            FormSuratKeluarLampiran form_lampiran = new FormSuratKeluarLampiran();
            status = "Edit";
            FormSuratKeluarEdit form_edit = new FormSuratKeluarEdit(this);
            form_edit.ShowDialog();
        }

        private void radioButtonTanggal_CheckedChanged(object sender, EventArgs e)
        {
            kriteria = "tanggal_surat";
            textBoxCariSuratKeluar.SendToBack();
            dateTimeInputSuratKeluar.BringToFront();
            getAllSuratKeluar();
        }

        private void getSuratKeluar(string cari)
        {
            Database db = new Database();
            strconn = db.getString();
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            try
            {
                query = "SELECT  @s:=@s+1 AS nomor,nomor_surat_keluar, DATE_FORMAT(tanggal_surat, '%d-%m-%Y'), perihal,j.nama_jenis AS jenis_surat " +
                                "FROM surat_keluar JOIN jenis_surat AS j USING(id_jenis),(SELECT @s:= 0) AS s " +
                                "WHERE " + kriteria + " LIKE '%" + cari + "%' ORDER BY nomor ASC";
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

        private void dateTimeInputSuratKeluar_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            cari = dateTimeInputSuratKeluar.Value.Date.ToString("yyyy-MM-dd");
            //MessageBox.Show(cari);
            getSuratKeluar(cari);
        }

        private void buttondetailsuratkeluar_Click(object sender, EventArgs e)
        {
            FormDetailSuratKeluar detail = new FormDetailSuratKeluar();
            detail.Show();
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
                    objWorksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    objWorksheet.Cells.AutoFitColumns();

                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells["A1:J1"])
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

                        objWorksheet.Cells["A1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
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
        private void buttonsimpansuratkeluar_Click(object sender, EventArgs e)
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
                    query = "SELECT nomor_surat_keluar AS 'Nomor Surat', DATE_FORMAT(tanggal_surat, '%d-%m-%Y') AS 'Tanggal Surat', " +
                                    "j.nama_jenis AS 'Jenis Surat', " +
                                    "perihal AS 'Perihal'," +
                                    "penerima AS 'Penerima Surat', tertanda AS 'Tertanda', " +
                                    "jabatan_tertanda AS 'Jabatan Tertanda', isi_singkat AS 'Isi Surat', " +
                                    "distribusi_tanggal AS 'Tanggal Distribusi'," +
                                    "DATE_FORMAT(tanggal_update, '%d-%m-%Y %H:%i:%s') AS 'Waktu Update Terakhir' " +
                            "FROM surat_keluar JOIN jenis_surat AS j USING(id_jenis) ORDER BY tanggal_surat ASC";
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
            FormRekapSuratKeluar rekap = new FormRekapSuratKeluar();
            rekap.ShowDialog();
        }

        //private void radioButtonInstansiPengirim_CheckedChanged(object sender, EventArgs e)
        //{
          //  kriteria = "penerima";
       // }

    }
}