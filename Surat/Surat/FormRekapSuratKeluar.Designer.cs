namespace Surat
{
    partial class FormRekapSuratKeluar
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
            this.dateTimeRekapSuratKeluar = new System.Windows.Forms.DateTimePicker();
            this.dataRekapKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.textBoxTotalSurat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeRekapSuratKeluar
            // 
            this.dateTimeRekapSuratKeluar.CustomFormat = "yyyy";
            this.dateTimeRekapSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeRekapSuratKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRekapSuratKeluar.Location = new System.Drawing.Point(172, 12);
            this.dateTimeRekapSuratKeluar.Name = "dateTimeRekapSuratKeluar";
            this.dateTimeRekapSuratKeluar.ShowUpDown = true;
            this.dateTimeRekapSuratKeluar.Size = new System.Drawing.Size(70, 26);
            this.dateTimeRekapSuratKeluar.TabIndex = 0;
            this.dateTimeRekapSuratKeluar.ValueChanged += new System.EventHandler(this.dateTimeRekapSuratKeluar_ValueChanged);
            // 
            // dataRekapKeluar
            // 
            this.dataRekapKeluar.AllowUserToAddRows = false;
            this.dataRekapKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRekapKeluar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataRekapKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataRekapKeluar.Location = new System.Drawing.Point(59, 76);
            this.dataRekapKeluar.Name = "dataRekapKeluar";
            this.dataRekapKeluar.RowHeadersVisible = false;
            this.dataRekapKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRekapKeluar.Size = new System.Drawing.Size(203, 150);
            this.dataRekapKeluar.TabIndex = 1;
            // 
            // textBoxTotalSurat
            // 
            // 
            // 
            // 
            this.textBoxTotalSurat.Border.Class = "TextBoxBorder";
            this.textBoxTotalSurat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTotalSurat.Location = new System.Drawing.Point(139, 232);
            this.textBoxTotalSurat.Name = "textBoxTotalSurat";
            this.textBoxTotalSurat.ReadOnly = true;
            this.textBoxTotalSurat.Size = new System.Drawing.Size(103, 20);
            this.textBoxTotalSurat.TabIndex = 2;
            this.textBoxTotalSurat.TextChanged += new System.EventHandler(this.textBoxTotalSurat_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(71, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Pilih Tahun :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(74, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(168, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Jumlah Surat per Bulan :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(74, 232);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Total :";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(107, 270);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(114, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Kembali";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FormRekapSuratKeluar
            // 
            this.ClientSize = new System.Drawing.Size(312, 307);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxTotalSurat);
            this.Controls.Add(this.dataRekapKeluar);
            this.Controls.Add(this.dateTimeRekapSuratKeluar);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MaximizeBox = false;
            this.Name = "FormRekapSuratKeluar";
            this.Text = "Rekap Surat Masuk";
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapKeluar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeRekapSuratKeluar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataRekapKeluar;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTotalSurat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;

    }
}