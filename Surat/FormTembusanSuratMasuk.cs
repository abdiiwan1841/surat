using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Surat
{
    public partial class FormTembusanSuratMasuk : DevComponents.DotNetBar.OfficeForm
    {
        public static List<string> list_tembusan = new List<string>();
        private string tembusan;
        private int index_tembusan;

        public FormTembusanSuratMasuk()
        {
            InitializeComponent();
        }

        private void tampil_tembusan()
        {
            dataGridViewTembusanSuratMasuk.Rows.Clear();
            foreach (var tembusan in list_tembusan)
            {
                dataGridViewTembusanSuratMasuk.Rows.Add(tembusan);
            }
        }

        private void buttonKembaliTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambahTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            tembusan = textBoxTembusanSuratMasuk.Text;
            dataGridViewTembusanSuratMasuk.Rows.Add(tembusan);
            list_tembusan.Add(tembusan);
            textBoxTembusanSuratMasuk.Clear();
            textBoxTembusanSuratMasuk.Focus();
        }

        private void FormTembusanSuratMasuk_Load(object sender, EventArgs e)
        {
            tampil_tembusan();
        }

        private void dataGridViewTembusanSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewTembusanSuratMasuk.SelectedRows)
            {
                textBoxTembusanSuratMasuk.Text = row.Cells[0].Value.ToString();
            }
            index_tembusan = dataGridViewTembusanSuratMasuk.CurrentCell.RowIndex;
        }

        private void buttonEditTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            list_tembusan[index_tembusan] = textBoxTembusanSuratMasuk.Text;
            //MessageBox.Show("Tembusan berhasil diedit", "Sukses", MessageBoxButtons.OK);
            tampil_tembusan();
        }

        private void buttonHapusTembusanSuratMasuk_Click(object sender, EventArgs e)
        {
            list_tembusan.RemoveAt(index_tembusan);
            tampil_tembusan();
        }
    }
}