namespace Surat
{
    partial class FormSuratMasuk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSuratMasuk = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBoxCariSuratMasuk = new System.Windows.Forms.GroupBox();
            this.textBoxCariSuratMasuk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.radioButtonPerihalSuratMasuk = new System.Windows.Forms.RadioButton();
            this.radioButtonInstansiPengirim = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorSuratMasuk = new System.Windows.Forms.RadioButton();
            this.buttonTambahSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonKembali = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratMasuk)).BeginInit();
            this.groupBoxCariSuratMasuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSuratMasuk
            // 
            this.dataGridViewSuratMasuk.AllowUserToAddRows = false;
            this.dataGridViewSuratMasuk.AllowUserToDeleteRows = false;
            this.dataGridViewSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuratMasuk.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuratMasuk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSuratMasuk.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewSuratMasuk.Name = "dataGridViewSuratMasuk";
            this.dataGridViewSuratMasuk.ReadOnly = true;
            this.dataGridViewSuratMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuratMasuk.Size = new System.Drawing.Size(801, 394);
            this.dataGridViewSuratMasuk.TabIndex = 0;
            this.dataGridViewSuratMasuk.SelectionChanged += new System.EventHandler(this.dataGridViewSuratMasuk_SelectionChanged);
            // 
            // groupBoxCariSuratMasuk
            // 
            this.groupBoxCariSuratMasuk.Controls.Add(this.textBoxCariSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.labelX1);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonPerihalSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonInstansiPengirim);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonNomorSuratMasuk);
            this.groupBoxCariSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCariSuratMasuk.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCariSuratMasuk.Name = "groupBoxCariSuratMasuk";
            this.groupBoxCariSuratMasuk.Size = new System.Drawing.Size(801, 111);
            this.groupBoxCariSuratMasuk.TabIndex = 1;
            this.groupBoxCariSuratMasuk.TabStop = false;
            this.groupBoxCariSuratMasuk.Text = "Pencarian Data Surat Masuk";
            // 
            // textBoxCariSuratMasuk
            // 
            // 
            // 
            // 
            this.textBoxCariSuratMasuk.Border.Class = "TextBoxBorder";
            this.textBoxCariSuratMasuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCariSuratMasuk.Location = new System.Drawing.Point(16, 73);
            this.textBoxCariSuratMasuk.Name = "textBoxCariSuratMasuk";
            this.textBoxCariSuratMasuk.Size = new System.Drawing.Size(762, 22);
            this.textBoxCariSuratMasuk.TabIndex = 4;
            this.textBoxCariSuratMasuk.TextChanged += new System.EventHandler(this.textBoxCariSuratMasuk_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(263, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Pencarian Data Surat Masuk Berdasarkan:";
            // 
            // radioButtonPerihalSuratMasuk
            // 
            this.radioButtonPerihalSuratMasuk.AutoSize = true;
            this.radioButtonPerihalSuratMasuk.Location = new System.Drawing.Point(167, 43);
            this.radioButtonPerihalSuratMasuk.Name = "radioButtonPerihalSuratMasuk";
            this.radioButtonPerihalSuratMasuk.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPerihalSuratMasuk.TabIndex = 2;
            this.radioButtonPerihalSuratMasuk.Text = "Perihal";
            this.radioButtonPerihalSuratMasuk.UseVisualStyleBackColor = true;
            this.radioButtonPerihalSuratMasuk.CheckedChanged += new System.EventHandler(this.radioButtonPerihalSuratMasuk_CheckedChanged);
            // 
            // radioButtonInstansiPengirim
            // 
            this.radioButtonInstansiPengirim.AutoSize = true;
            this.radioButtonInstansiPengirim.Location = new System.Drawing.Point(265, 43);
            this.radioButtonInstansiPengirim.Name = "radioButtonInstansiPengirim";
            this.radioButtonInstansiPengirim.Size = new System.Drawing.Size(127, 20);
            this.radioButtonInstansiPengirim.TabIndex = 1;
            this.radioButtonInstansiPengirim.Text = "Instansi Pengirim";
            this.radioButtonInstansiPengirim.UseVisualStyleBackColor = true;
            this.radioButtonInstansiPengirim.CheckedChanged += new System.EventHandler(this.radioButtonInstansiPengirim_CheckedChanged);
            // 
            // radioButtonNomorSuratMasuk
            // 
            this.radioButtonNomorSuratMasuk.AutoSize = true;
            this.radioButtonNomorSuratMasuk.Checked = true;
            this.radioButtonNomorSuratMasuk.Location = new System.Drawing.Point(16, 43);
            this.radioButtonNomorSuratMasuk.Name = "radioButtonNomorSuratMasuk";
            this.radioButtonNomorSuratMasuk.Size = new System.Drawing.Size(101, 20);
            this.radioButtonNomorSuratMasuk.TabIndex = 0;
            this.radioButtonNomorSuratMasuk.TabStop = true;
            this.radioButtonNomorSuratMasuk.Text = "Nomor Surat";
            this.radioButtonNomorSuratMasuk.UseVisualStyleBackColor = true;
            this.radioButtonNomorSuratMasuk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonTambahSuratMasuk
            // 
            this.buttonTambahSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSuratMasuk.Location = new System.Drawing.Point(833, 21);
            this.buttonTambahSuratMasuk.Name = "buttonTambahSuratMasuk";
            this.buttonTambahSuratMasuk.Size = new System.Drawing.Size(106, 45);
            this.buttonTambahSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahSuratMasuk.TabIndex = 2;
            this.buttonTambahSuratMasuk.Text = "Tambah";
            this.buttonTambahSuratMasuk.Click += new System.EventHandler(this.buttonTambahSuratMasuk_Click);
            // 
            // buttonHapusSuratDisposisi
            // 
            this.buttonHapusSuratDisposisi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusSuratDisposisi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusSuratDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusSuratDisposisi.Location = new System.Drawing.Point(833, 123);
            this.buttonHapusSuratDisposisi.Name = "buttonHapusSuratDisposisi";
            this.buttonHapusSuratDisposisi.Size = new System.Drawing.Size(106, 45);
            this.buttonHapusSuratDisposisi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusSuratDisposisi.TabIndex = 3;
            this.buttonHapusSuratDisposisi.Text = "Hapus";
            this.buttonHapusSuratDisposisi.Click += new System.EventHandler(this.buttonHapusSuratMasuk_Click);
            // 
            // buttonEditSuratDisposisi
            // 
            this.buttonEditSuratDisposisi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSuratDisposisi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSuratDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSuratDisposisi.Location = new System.Drawing.Point(833, 72);
            this.buttonEditSuratDisposisi.Name = "buttonEditSuratDisposisi";
            this.buttonEditSuratDisposisi.Size = new System.Drawing.Size(106, 45);
            this.buttonEditSuratDisposisi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSuratDisposisi.TabIndex = 4;
            this.buttonEditSuratDisposisi.Text = "Edit";
            this.buttonEditSuratDisposisi.Click += new System.EventHandler(this.buttonEditSuratMasuk_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(833, 489);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(106, 45);
            this.buttonKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembali.TabIndex = 5;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // FormSuratMasuk
            // 
            this.ClientSize = new System.Drawing.Size(951, 547);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonEditSuratDisposisi);
            this.Controls.Add(this.buttonHapusSuratDisposisi);
            this.Controls.Add(this.buttonTambahSuratMasuk);
            this.Controls.Add(this.groupBoxCariSuratMasuk);
            this.Controls.Add(this.dataGridViewSuratMasuk);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormSuratMasuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Surat Masuk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratMasuk_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratMasuk)).EndInit();
            this.groupBoxCariSuratMasuk.ResumeLayout(false);
            this.groupBoxCariSuratMasuk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSuratMasuk;
        private System.Windows.Forms.GroupBox groupBoxCariSuratMasuk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCariSuratMasuk;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton radioButtonPerihalSuratMasuk;
        private System.Windows.Forms.RadioButton radioButtonInstansiPengirim;
        private System.Windows.Forms.RadioButton radioButtonNomorSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonTambahSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonHapusSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonEditSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonKembali;
    }
}