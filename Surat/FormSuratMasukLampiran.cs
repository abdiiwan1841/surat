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
    public partial class FormSuratMasukLampiran : DevComponents.DotNetBar.OfficeForm
    {
        public FormSuratMasukLampiran()
        {
            InitializeComponent();
        }

        public static List<string> list_lampiran = new List<string>();
        private string lampiran;
        private int index_lampiran;

        private void tampil_lampiran()
        {
            dataGridViewLampiranSuratMasuk.Rows.Clear();
            foreach (var tembusan in list_lampiran)
            {
                dataGridViewLampiranSuratMasuk.Rows.Add(tembusan);
            }
        }

        private void FormSuratMasukLampiran_Load(object sender, EventArgs e)
        {
            tampil_lampiran();
            if (list_lampiran.Count == 0)
            {
                buttonEditLampiranSuratMasuk.Enabled = false;
                buttonHapusLampiranSuratMasuk.Enabled = false;
            }
            if (textBoxLampiranSuratMasuk.Text == "")
            {
                buttonEditLampiranSuratMasuk.Enabled = false;
                buttonTambahLampiranSuratMasuk.Enabled = false;
            }
        }

        private void buttonKembaliLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLampiranSuratMasuk_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLampiranSuratMasuk.SelectedRows)
            {
                textBoxLampiranSuratMasuk.Text = row.Cells[0].Value.ToString();
            }
            index_lampiran = dataGridViewLampiranSuratMasuk.CurrentCell.RowIndex;
        }

        private void buttonTambahLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            lampiran = textBoxLampiranSuratMasuk.Text;
            dataGridViewLampiranSuratMasuk.Rows.Add(lampiran);
            list_lampiran.Add(lampiran);
            textBoxLampiranSuratMasuk.Clear();
            textBoxLampiranSuratMasuk.Focus();
        }

        private void buttonEditLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            list_lampiran[index_lampiran] = textBoxLampiranSuratMasuk.Text;
            tampil_lampiran();
        }

        private void buttonHapusLampiranSuratMasuk_Click(object sender, EventArgs e)
        {
            list_lampiran.RemoveAt(index_lampiran);
            tampil_lampiran();
        }

        private void textBoxLampiranSuratMasuk_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLampiranSuratMasuk.Text == "")
            {
                buttonTambahLampiranSuratMasuk.Enabled = false;
                buttonEditLampiranSuratMasuk.Enabled = false;
            }
            else
            {
                buttonTambahLampiranSuratMasuk.Enabled = true;
                if (list_lampiran.Count == 0)
                {
                    buttonEditLampiranSuratMasuk.Enabled = false;
                }
                else
                {
                    buttonEditLampiranSuratMasuk.Enabled = true;
                }
            }
        }
    }
}