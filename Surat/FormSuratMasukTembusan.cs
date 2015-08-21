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
    public partial class FormSuratMasukTembusan : DevComponents.DotNetBar.OfficeForm
    {
        public static List<string> list_tembusan = new List<string>();
        private string tembusan;
        private int index_tembusan;

        public FormSuratMasukTembusan()
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
            if (list_tembusan.Count == 0)
            {
                buttonEditTembusanSuratMasuk.Enabled = false;
                buttonHapusTembusanSuratMasuk.Enabled = false;
            }
            if (textBoxTembusanSuratMasuk.Text == "")
            {
                buttonEditTembusanSuratMasuk.Enabled = false;
                buttonTambahTembusanSuratMasuk.Enabled = false;
            }
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

        private void textBoxTembusanSuratMasuk_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTembusanSuratMasuk.Text == "")
            {
                buttonTambahTembusanSuratMasuk.Enabled = false;
                buttonEditTembusanSuratMasuk.Enabled = false;
            }
            else
            {
                buttonTambahTembusanSuratMasuk.Enabled = true;
                if (list_tembusan.Count == 0)
                {
                    buttonEditTembusanSuratMasuk.Enabled = false;
                }
                else
                {
                    buttonEditTembusanSuratMasuk.Enabled = true;
                }
            }
        }
    }
}