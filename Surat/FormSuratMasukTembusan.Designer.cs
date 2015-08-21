namespace Surat
{
    partial class FormSuratMasukTembusan
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
            this.textBoxTembusanSuratMasuk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonTambahTembusanSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewTembusanSuratMasuk = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnNamaTembusanSuratMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditTembusanSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusTembusanSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonKembaliTembusanSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTembusanSuratMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTembusanSuratMasuk
            // 
            // 
            // 
            // 
            this.textBoxTembusanSuratMasuk.Border.Class = "TextBoxBorder";
            this.textBoxTembusanSuratMasuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTembusanSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTembusanSuratMasuk.Location = new System.Drawing.Point(12, 36);
            this.textBoxTembusanSuratMasuk.MaxLength = 40;
            this.textBoxTembusanSuratMasuk.Name = "textBoxTembusanSuratMasuk";
            this.textBoxTembusanSuratMasuk.Size = new System.Drawing.Size(277, 26);
            this.textBoxTembusanSuratMasuk.TabIndex = 0;
            this.textBoxTembusanSuratMasuk.TextChanged += new System.EventHandler(this.textBoxTembusanSuratMasuk_TextChanged);
            // 
            // buttonTambahTembusanSuratMasuk
            // 
            this.buttonTambahTembusanSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahTembusanSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahTembusanSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahTembusanSuratMasuk.Location = new System.Drawing.Point(295, 36);
            this.buttonTambahTembusanSuratMasuk.Name = "buttonTambahTembusanSuratMasuk";
            this.buttonTambahTembusanSuratMasuk.Size = new System.Drawing.Size(75, 26);
            this.buttonTambahTembusanSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahTembusanSuratMasuk.TabIndex = 1;
            this.buttonTambahTembusanSuratMasuk.Text = "Tambah";
            this.buttonTambahTembusanSuratMasuk.Click += new System.EventHandler(this.buttonTambahTembusanSuratMasuk_Click);
            // 
            // dataGridViewTembusanSuratMasuk
            // 
            this.dataGridViewTembusanSuratMasuk.AllowUserToAddRows = false;
            this.dataGridViewTembusanSuratMasuk.AllowUserToDeleteRows = false;
            this.dataGridViewTembusanSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTembusanSuratMasuk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNamaTembusanSuratMasuk});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTembusanSuratMasuk.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTembusanSuratMasuk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewTembusanSuratMasuk.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewTembusanSuratMasuk.Name = "dataGridViewTembusanSuratMasuk";
            this.dataGridViewTembusanSuratMasuk.ReadOnly = true;
            this.dataGridViewTembusanSuratMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTembusanSuratMasuk.Size = new System.Drawing.Size(277, 219);
            this.dataGridViewTembusanSuratMasuk.TabIndex = 2;
            this.dataGridViewTembusanSuratMasuk.SelectionChanged += new System.EventHandler(this.dataGridViewTembusanSuratMasuk_SelectionChanged);
            // 
            // ColumnNamaTembusanSuratMasuk
            // 
            this.ColumnNamaTembusanSuratMasuk.HeaderText = "Tembusan";
            this.ColumnNamaTembusanSuratMasuk.Name = "ColumnNamaTembusanSuratMasuk";
            this.ColumnNamaTembusanSuratMasuk.ReadOnly = true;
            this.ColumnNamaTembusanSuratMasuk.Width = 230;
            // 
            // buttonEditTembusanSuratMasuk
            // 
            this.buttonEditTembusanSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditTembusanSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditTembusanSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTembusanSuratMasuk.Location = new System.Drawing.Point(295, 68);
            this.buttonEditTembusanSuratMasuk.Name = "buttonEditTembusanSuratMasuk";
            this.buttonEditTembusanSuratMasuk.Size = new System.Drawing.Size(75, 26);
            this.buttonEditTembusanSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditTembusanSuratMasuk.TabIndex = 3;
            this.buttonEditTembusanSuratMasuk.Text = "Edit";
            this.buttonEditTembusanSuratMasuk.Click += new System.EventHandler(this.buttonEditTembusanSuratMasuk_Click);
            // 
            // buttonHapusTembusanSuratMasuk
            // 
            this.buttonHapusTembusanSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusTembusanSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusTembusanSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusTembusanSuratMasuk.Location = new System.Drawing.Point(295, 100);
            this.buttonHapusTembusanSuratMasuk.Name = "buttonHapusTembusanSuratMasuk";
            this.buttonHapusTembusanSuratMasuk.Size = new System.Drawing.Size(75, 26);
            this.buttonHapusTembusanSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusTembusanSuratMasuk.TabIndex = 4;
            this.buttonHapusTembusanSuratMasuk.Text = "Hapus";
            this.buttonHapusTembusanSuratMasuk.Click += new System.EventHandler(this.buttonHapusTembusanSuratMasuk_Click);
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
            // buttonKembaliTembusanSuratMasuk
            // 
            this.buttonKembaliTembusanSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembaliTembusanSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembaliTembusanSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembaliTembusanSuratMasuk.Location = new System.Drawing.Point(295, 255);
            this.buttonKembaliTembusanSuratMasuk.Name = "buttonKembaliTembusanSuratMasuk";
            this.buttonKembaliTembusanSuratMasuk.Size = new System.Drawing.Size(75, 32);
            this.buttonKembaliTembusanSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembaliTembusanSuratMasuk.TabIndex = 7;
            this.buttonKembaliTembusanSuratMasuk.Text = "Kembali";
            this.buttonKembaliTembusanSuratMasuk.Click += new System.EventHandler(this.buttonKembaliTembusanSuratMasuk_Click);
            // 
            // FormSuratMasukTembusan
            // 
            this.ClientSize = new System.Drawing.Size(381, 300);
            this.Controls.Add(this.buttonKembaliTembusanSuratMasuk);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonHapusTembusanSuratMasuk);
            this.Controls.Add(this.buttonEditTembusanSuratMasuk);
            this.Controls.Add(this.dataGridViewTembusanSuratMasuk);
            this.Controls.Add(this.buttonTambahTembusanSuratMasuk);
            this.Controls.Add(this.textBoxTembusanSuratMasuk);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuratMasukTembusan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tembusan";
            this.Load += new System.EventHandler(this.FormTembusanSuratMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTembusanSuratMasuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTembusanSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonTambahTembusanSuratMasuk;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewTembusanSuratMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamaTembusanSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonEditTembusanSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonHapusTembusanSuratMasuk;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonKembaliTembusanSuratMasuk;
    }
}