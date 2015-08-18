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
    public partial class FormSuratMasuk : DevComponents.DotNetBar.OfficeForm
    {
        public FormSuratMasuk()
        {
            InitializeComponent();
        }

        private void buttonTambahSuratMasuk_Click(object sender, EventArgs e)
        {
            FormTambahSuratMasuk form_tambah = new FormTambahSuratMasuk();
            form_tambah.ShowDialog();
        }
    }
}