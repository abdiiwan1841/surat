namespace Surat
{
    partial class FormSuratKeluar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCariSuratKeluar = new System.Windows.Forms.GroupBox();
            this.textBoxCariSuratKeluar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.radioButtonPerihalSuratKeluar = new System.Windows.Forms.RadioButton();
            this.radioButtonInstansiPengirim = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorSuratKeluar = new System.Windows.Forms.RadioButton();
            this.buttonKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonTambahSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBoxCariSuratKeluar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCariSuratKeluar
            // 
            this.groupBoxCariSuratKeluar.Controls.Add(this.textBoxCariSuratKeluar);
            this.groupBoxCariSuratKeluar.Controls.Add(this.labelX1);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonPerihalSuratKeluar);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonInstansiPengirim);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonNomorSuratKeluar);
            this.groupBoxCariSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCariSuratKeluar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCariSuratKeluar.Name = "groupBoxCariSuratKeluar";
            this.groupBoxCariSuratKeluar.Size = new System.Drawing.Size(801, 111);
            this.groupBoxCariSuratKeluar.TabIndex = 2;
            this.groupBoxCariSuratKeluar.TabStop = false;
            this.groupBoxCariSuratKeluar.Text = "Pencarian Data Surat Keluar";
            // 
            // textBoxCariSuratKeluar
            // 
            // 
            // 
            // 
            this.textBoxCariSuratKeluar.Border.Class = "TextBoxBorder";
            this.textBoxCariSuratKeluar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCariSuratKeluar.Location = new System.Drawing.Point(16, 73);
            this.textBoxCariSuratKeluar.Name = "textBoxCariSuratKeluar";
            this.textBoxCariSuratKeluar.Size = new System.Drawing.Size(762, 22);
            this.textBoxCariSuratKeluar.TabIndex = 4;
            this.textBoxCariSuratKeluar.TextChanged += new System.EventHandler(this.textBoxCariSuratKeluar_TextChanged);
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
            // radioButtonPerihalSuratKeluar
            // 
            this.radioButtonPerihalSuratKeluar.AutoSize = true;
            this.radioButtonPerihalSuratKeluar.Location = new System.Drawing.Point(167, 43);
            this.radioButtonPerihalSuratKeluar.Name = "radioButtonPerihalSuratKeluar";
            this.radioButtonPerihalSuratKeluar.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPerihalSuratKeluar.TabIndex = 2;
            this.radioButtonPerihalSuratKeluar.Text = "Perihal";
            this.radioButtonPerihalSuratKeluar.UseVisualStyleBackColor = true;
            this.radioButtonPerihalSuratKeluar.CheckedChanged += new System.EventHandler(this.radioButtonPerihalSuratKeluar_CheckedChanged);
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
            // 
            // radioButtonNomorSuratKeluar
            // 
            this.radioButtonNomorSuratKeluar.AutoSize = true;
            this.radioButtonNomorSuratKeluar.Checked = true;
            this.radioButtonNomorSuratKeluar.Location = new System.Drawing.Point(16, 43);
            this.radioButtonNomorSuratKeluar.Name = "radioButtonNomorSuratKeluar";
            this.radioButtonNomorSuratKeluar.Size = new System.Drawing.Size(101, 20);
            this.radioButtonNomorSuratKeluar.TabIndex = 0;
            this.radioButtonNomorSuratKeluar.TabStop = true;
            this.radioButtonNomorSuratKeluar.Text = "Nomor Surat";
            this.radioButtonNomorSuratKeluar.UseVisualStyleBackColor = true;
            this.radioButtonNomorSuratKeluar.CheckedChanged += new System.EventHandler(this.radioButtonNomorSuratKeluar_CheckedChanged);
            // 
            // buttonKembali
            // 
            this.buttonKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(830, 482);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(106, 45);
            this.buttonKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembali.TabIndex = 10;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonEditSuratKeluar
            // 
            this.buttonEditSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSuratKeluar.Location = new System.Drawing.Point(830, 65);
            this.buttonEditSuratKeluar.Name = "buttonEditSuratKeluar";
            this.buttonEditSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonEditSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSuratKeluar.TabIndex = 9;
            this.buttonEditSuratKeluar.Text = "Edit";
            this.buttonEditSuratKeluar.Click += new System.EventHandler(this.buttonEditSuratKeluar_Click);
            // 
            // buttonHapusSuratKeluar
            // 
            this.buttonHapusSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusSuratKeluar.Location = new System.Drawing.Point(830, 116);
            this.buttonHapusSuratKeluar.Name = "buttonHapusSuratKeluar";
            this.buttonHapusSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonHapusSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusSuratKeluar.TabIndex = 8;
            this.buttonHapusSuratKeluar.Text = "Hapus";
            this.buttonHapusSuratKeluar.Click += new System.EventHandler(this.buttonHapusSuratKeluar_Click);
            // 
            // buttonTambahSuratKeluar
            // 
            this.buttonTambahSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSuratKeluar.Location = new System.Drawing.Point(830, 14);
            this.buttonTambahSuratKeluar.Name = "buttonTambahSuratKeluar";
            this.buttonTambahSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonTambahSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahSuratKeluar.TabIndex = 7;
            this.buttonTambahSuratKeluar.Text = "Tambah";
            this.buttonTambahSuratKeluar.Click += new System.EventHandler(this.buttonTambahSuratKeluar_Click);
            // 
            // dataGridViewSuratKeluar
            // 
            this.dataGridViewSuratKeluar.AllowUserToAddRows = false;
            this.dataGridViewSuratKeluar.AllowUserToDeleteRows = false;
            this.dataGridViewSuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuratKeluar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSuratKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSuratKeluar.Location = new System.Drawing.Point(9, 133);
            this.dataGridViewSuratKeluar.Name = "dataGridViewSuratKeluar";
            this.dataGridViewSuratKeluar.ReadOnly = true;
            this.dataGridViewSuratKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuratKeluar.Size = new System.Drawing.Size(801, 394);
            this.dataGridViewSuratKeluar.TabIndex = 6;
            this.dataGridViewSuratKeluar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuratKeluar_CellContentClick);
            this.dataGridViewSuratKeluar.SelectionChanged += new System.EventHandler(this.dataGridViewSuratKeluar_SelectionChanged);
            // 
            // FormSuratKeluar
            // 
            this.ClientSize = new System.Drawing.Size(945, 541);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonEditSuratKeluar);
            this.Controls.Add(this.buttonHapusSuratKeluar);
            this.Controls.Add(this.buttonTambahSuratKeluar);
            this.Controls.Add(this.dataGridViewSuratKeluar);
            this.Controls.Add(this.groupBoxCariSuratKeluar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormSuratKeluar";
            this.ShowIcon = false;
            this.Text = "Surat Keluar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratKeluar_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratKeluar_Load);
            this.groupBoxCariSuratKeluar.ResumeLayout(false);
            this.groupBoxCariSuratKeluar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratKeluar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCariSuratKeluar;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCariSuratKeluar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton radioButtonPerihalSuratKeluar;
        private System.Windows.Forms.RadioButton radioButtonInstansiPengirim;
        private System.Windows.Forms.RadioButton radioButtonNomorSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonKembali;
        private DevComponents.DotNetBar.ButtonX buttonEditSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonHapusSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonTambahSuratKeluar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSuratKeluar;
    }
}