namespace Surat
{
    partial class FormRekapDisposisi
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxDisposisi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataRekapDisposisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dateTimeRekapDisposisi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapDisposisi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(105, 266);
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
            this.labelX3.Location = new System.Drawing.Point(72, 228);
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
            this.labelX2.Location = new System.Drawing.Point(72, 43);
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
            this.labelX1.Location = new System.Drawing.Point(69, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Pilih Tahun :";
            // 
            // textBoxDisposisi
            // 
            // 
            // 
            // 
            this.textBoxDisposisi.Border.Class = "TextBoxBorder";
            this.textBoxDisposisi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDisposisi.Location = new System.Drawing.Point(137, 228);
            this.textBoxDisposisi.Name = "textBoxDisposisi";
            this.textBoxDisposisi.ReadOnly = true;
            this.textBoxDisposisi.Size = new System.Drawing.Size(103, 20);
            this.textBoxDisposisi.TabIndex = 9;
            // 
            // dataRekapDisposisi
            // 
            this.dataRekapDisposisi.AllowUserToAddRows = false;
            this.dataRekapDisposisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRekapDisposisi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataRekapDisposisi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataRekapDisposisi.Location = new System.Drawing.Point(57, 72);
            this.dataRekapDisposisi.Name = "dataRekapDisposisi";
            this.dataRekapDisposisi.RowHeadersVisible = false;
            this.dataRekapDisposisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRekapDisposisi.Size = new System.Drawing.Size(203, 150);
            this.dataRekapDisposisi.TabIndex = 8;
            // 
            // dateTimeRekapDisposisi
            // 
            this.dateTimeRekapDisposisi.CustomFormat = "yyyy";
            this.dateTimeRekapDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeRekapDisposisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRekapDisposisi.Location = new System.Drawing.Point(170, 8);
            this.dateTimeRekapDisposisi.Name = "dateTimeRekapDisposisi";
            this.dateTimeRekapDisposisi.ShowUpDown = true;
            this.dateTimeRekapDisposisi.Size = new System.Drawing.Size(70, 26);
            this.dateTimeRekapDisposisi.TabIndex = 7;
            this.dateTimeRekapDisposisi.ValueChanged += new System.EventHandler(this.dateTimeRekapDisposisi_ValueChanged);
            // 
            // FormRekapDisposisi
            // 
            this.ClientSize = new System.Drawing.Size(318, 305);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxDisposisi);
            this.Controls.Add(this.dataRekapDisposisi);
            this.Controls.Add(this.dateTimeRekapDisposisi);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MaximizeBox = false;
            this.Name = "FormRekapDisposisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRekapDisposisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataRekapDisposisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDisposisi;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataRekapDisposisi;
        private System.Windows.Forms.DateTimePicker dateTimeRekapDisposisi;
    }
}