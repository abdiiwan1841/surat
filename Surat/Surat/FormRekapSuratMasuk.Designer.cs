namespace Surat
{
    partial class FormRekapSuratMasuk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxTotalSurat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataRekapMasuk = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dateTimeRekapSuratMasuk = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(108, 266);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(114, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Kembali";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(75, 228);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Total :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(75, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(168, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Jumlah Surat per Bulan :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(72, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Pilih Tahun :";
            // 
            // textBoxTotalSurat
            // 
            // 
            // 
            // 
            this.textBoxTotalSurat.Border.Class = "TextBoxBorder";
            this.textBoxTotalSurat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTotalSurat.Location = new System.Drawing.Point(140, 228);
            this.textBoxTotalSurat.Name = "textBoxTotalSurat";
            this.textBoxTotalSurat.ReadOnly = true;
            this.textBoxTotalSurat.Size = new System.Drawing.Size(103, 20);
            this.textBoxTotalSurat.TabIndex = 9;
            // 
            // dataRekapMasuk
            // 
            this.dataRekapMasuk.AllowUserToAddRows = false;
            this.dataRekapMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRekapMasuk.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataRekapMasuk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataRekapMasuk.Location = new System.Drawing.Point(60, 72);
            this.dataRekapMasuk.Name = "dataRekapMasuk";
            this.dataRekapMasuk.RowHeadersVisible = false;
            this.dataRekapMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRekapMasuk.Size = new System.Drawing.Size(203, 150);
            this.dataRekapMasuk.TabIndex = 8;
            // 
            // dateTimeRekapSuratMasuk
            // 
            this.dateTimeRekapSuratMasuk.CustomFormat = "yyyy";
            this.dateTimeRekapSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeRekapSuratMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRekapSuratMasuk.Location = new System.Drawing.Point(173, 8);
            this.dateTimeRekapSuratMasuk.Name = "dateTimeRekapSuratMasuk";
            this.dateTimeRekapSuratMasuk.ShowUpDown = true;
            this.dateTimeRekapSuratMasuk.Size = new System.Drawing.Size(70, 26);
            this.dateTimeRekapSuratMasuk.TabIndex = 7;
            this.dateTimeRekapSuratMasuk.ValueChanged += new System.EventHandler(this.dateTimeRekapSuratMasuk_ValueChanged);
            // 
            // FormRekapSuratMasuk
            // 
            this.ClientSize = new System.Drawing.Size(326, 307);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxTotalSurat);
            this.Controls.Add(this.dataRekapMasuk);
            this.Controls.Add(this.dateTimeRekapSuratMasuk);
            this.DoubleBuffered = true;
            this.Name = "FormRekapSuratMasuk";
            this.Text = "Rekap Backup Surat Masuk";
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapMasuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTotalSurat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataRekapMasuk;
        private System.Windows.Forms.DateTimePicker dateTimeRekapSuratMasuk;
    }
}