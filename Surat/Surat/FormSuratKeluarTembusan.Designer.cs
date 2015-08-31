namespace Surat
{
    partial class FormSuratKeluarTembusan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTembusanSuratKeluar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonTambahTembusanSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewTembusanSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnNamaTembusanSuratKeluar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditTembusanSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusTembusanSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonKembaliTembusanSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTembusanSuratKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTembusanSuratKeluar
            // 
            // 
            // 
            // 
            this.textBoxTembusanSuratKeluar.Border.Class = "TextBoxBorder";
            this.textBoxTembusanSuratKeluar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTembusanSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTembusanSuratKeluar.Location = new System.Drawing.Point(12, 36);
            this.textBoxTembusanSuratKeluar.MaxLength = 40;
            this.textBoxTembusanSuratKeluar.Name = "textBoxTembusanSuratKeluar";
            this.textBoxTembusanSuratKeluar.Size = new System.Drawing.Size(277, 26);
            this.textBoxTembusanSuratKeluar.TabIndex = 0;
            // 
            // buttonTambahTembusanSuratKeluar
            // 
            this.buttonTambahTembusanSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahTembusanSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahTembusanSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahTembusanSuratKeluar.Location = new System.Drawing.Point(295, 36);
            this.buttonTambahTembusanSuratKeluar.Name = "buttonTambahTembusanSuratKeluar";
            this.buttonTambahTembusanSuratKeluar.Size = new System.Drawing.Size(75, 26);
            this.buttonTambahTembusanSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahTembusanSuratKeluar.TabIndex = 1;
            this.buttonTambahTembusanSuratKeluar.Text = "Tambah";
            this.buttonTambahTembusanSuratKeluar.Click += new System.EventHandler(this.buttonTambahTembusanSuratKeluar_Click);
            // 
            // dataGridViewTembusanSuratKeluar
            // 
            this.dataGridViewTembusanSuratKeluar.AllowUserToAddRows = false;
            this.dataGridViewTembusanSuratKeluar.AllowUserToDeleteRows = false;
            this.dataGridViewTembusanSuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTembusanSuratKeluar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNamaTembusanSuratKeluar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTembusanSuratKeluar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTembusanSuratKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewTembusanSuratKeluar.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewTembusanSuratKeluar.MultiSelect = false;
            this.dataGridViewTembusanSuratKeluar.Name = "dataGridViewTembusanSuratKeluar";
            this.dataGridViewTembusanSuratKeluar.ReadOnly = true;
            this.dataGridViewTembusanSuratKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTembusanSuratKeluar.Size = new System.Drawing.Size(277, 219);
            this.dataGridViewTembusanSuratKeluar.TabIndex = 2;
            this.dataGridViewTembusanSuratKeluar.SelectionChanged += new System.EventHandler(this.dataGridViewTembusanSuratKeluar_SelectionChanged);
            // 
            // ColumnNamaTembusanSuratKeluar
            // 
            this.ColumnNamaTembusanSuratKeluar.HeaderText = "Tembusan";
            this.ColumnNamaTembusanSuratKeluar.Name = "ColumnNamaTembusanSuratKeluar";
            this.ColumnNamaTembusanSuratKeluar.ReadOnly = true;
            this.ColumnNamaTembusanSuratKeluar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnNamaTembusanSuratKeluar.Width = 230;
            // 
            // buttonEditTembusanSuratKeluar
            // 
            this.buttonEditTembusanSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditTembusanSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditTembusanSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTembusanSuratKeluar.Location = new System.Drawing.Point(295, 68);
            this.buttonEditTembusanSuratKeluar.Name = "buttonEditTembusanSuratKeluar";
            this.buttonEditTembusanSuratKeluar.Size = new System.Drawing.Size(75, 26);
            this.buttonEditTembusanSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditTembusanSuratKeluar.TabIndex = 3;
            this.buttonEditTembusanSuratKeluar.Text = "Edit";
            this.buttonEditTembusanSuratKeluar.Click += new System.EventHandler(this.buttonEditTembusanSuratKeluar_Click);
            // 
            // buttonHapusTembusanSuratKeluar
            // 
            this.buttonHapusTembusanSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusTembusanSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusTembusanSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusTembusanSuratKeluar.Location = new System.Drawing.Point(295, 100);
            this.buttonHapusTembusanSuratKeluar.Name = "buttonHapusTembusanSuratKeluar";
            this.buttonHapusTembusanSuratKeluar.Size = new System.Drawing.Size(75, 26);
            this.buttonHapusTembusanSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusTembusanSuratKeluar.TabIndex = 4;
            this.buttonHapusTembusanSuratKeluar.Text = "Hapus";
            this.buttonHapusTembusanSuratKeluar.Click += new System.EventHandler(this.buttonHapusTembusanSuratKeluar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Tembusan";
            // 
            // buttonKembaliTembusanSuratKeluar
            // 
            this.buttonKembaliTembusanSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembaliTembusanSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembaliTembusanSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembaliTembusanSuratKeluar.Location = new System.Drawing.Point(295, 255);
            this.buttonKembaliTembusanSuratKeluar.Name = "buttonKembaliTembusanSuratKeluar";
            this.buttonKembaliTembusanSuratKeluar.Size = new System.Drawing.Size(75, 32);
            this.buttonKembaliTembusanSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembaliTembusanSuratKeluar.TabIndex = 7;
            this.buttonKembaliTembusanSuratKeluar.Text = "Kembali";
            this.buttonKembaliTembusanSuratKeluar.Click += new System.EventHandler(this.buttonKembaliTembusanSuratKeluar_Click);
            // 
            // FormSuratKeluarTembusan
            // 
            this.ClientSize = new System.Drawing.Size(381, 300);
            this.Controls.Add(this.buttonKembaliTembusanSuratKeluar);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonHapusTembusanSuratKeluar);
            this.Controls.Add(this.buttonEditTembusanSuratKeluar);
            this.Controls.Add(this.dataGridViewTembusanSuratKeluar);
            this.Controls.Add(this.buttonTambahTembusanSuratKeluar);
            this.Controls.Add(this.textBoxTembusanSuratKeluar);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuratKeluarTembusan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tembusan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratKeluarTembusan_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratKeluarTembusan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTembusanSuratKeluar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTembusanSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonTambahTembusanSuratKeluar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewTembusanSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonEditTembusanSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonHapusTembusanSuratKeluar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonKembaliTembusanSuratKeluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamaTembusanSuratKeluar;
    }
}