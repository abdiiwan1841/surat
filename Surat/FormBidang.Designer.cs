namespace Surat
{
    partial class FormBidang
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
            this.dataGridViewBidang = new System.Windows.Forms.DataGridView();
            this.buttonTambahBidang = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditBidang = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusBidang = new DevComponents.DotNetBar.ButtonX();
            this.buttonCallFormSub = new DevComponents.DotNetBar.ButtonX();
            this.buttonBidangKembali = new DevComponents.DotNetBar.ButtonX();
            this.labelCariBidang = new DevComponents.DotNetBar.LabelX();
            this.textBoxCariBidang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBidang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBidang
            // 
            this.dataGridViewBidang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBidang.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewBidang.MultiSelect = false;
            this.dataGridViewBidang.Name = "dataGridViewBidang";
            this.dataGridViewBidang.ReadOnly = true;
            this.dataGridViewBidang.Size = new System.Drawing.Size(301, 255);
            this.dataGridViewBidang.TabIndex = 0;
            this.dataGridViewBidang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBidang_CellContentClick);
            this.dataGridViewBidang.SelectionChanged += new System.EventHandler(this.dataGridViewBidang_SelectionChanged);
            // 
            // buttonTambahBidang
            // 
            this.buttonTambahBidang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahBidang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahBidang.Location = new System.Drawing.Point(351, 29);
            this.buttonTambahBidang.Name = "buttonTambahBidang";
            this.buttonTambahBidang.Size = new System.Drawing.Size(186, 54);
            this.buttonTambahBidang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahBidang.TabIndex = 1;
            this.buttonTambahBidang.Text = "Tambah Data";
            this.buttonTambahBidang.Click += new System.EventHandler(this.buttonTambahBidang_Click);
            // 
            // buttonEditBidang
            // 
            this.buttonEditBidang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditBidang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBidang.Location = new System.Drawing.Point(351, 101);
            this.buttonEditBidang.Name = "buttonEditBidang";
            this.buttonEditBidang.Size = new System.Drawing.Size(186, 54);
            this.buttonEditBidang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditBidang.TabIndex = 2;
            this.buttonEditBidang.Text = "Edit Data";
            this.buttonEditBidang.Click += new System.EventHandler(this.buttonEditBidang_Click);
            // 
            // buttonHapusBidang
            // 
            this.buttonHapusBidang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusBidang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusBidang.Location = new System.Drawing.Point(351, 177);
            this.buttonHapusBidang.Name = "buttonHapusBidang";
            this.buttonHapusBidang.Size = new System.Drawing.Size(186, 54);
            this.buttonHapusBidang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusBidang.TabIndex = 3;
            this.buttonHapusBidang.Text = "Hapus Data";
            this.buttonHapusBidang.Click += new System.EventHandler(this.buttonHapusBidang_Click);
            // 
            // buttonCallFormSub
            // 
            this.buttonCallFormSub.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCallFormSub.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCallFormSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCallFormSub.Location = new System.Drawing.Point(351, 252);
            this.buttonCallFormSub.Name = "buttonCallFormSub";
            this.buttonCallFormSub.Size = new System.Drawing.Size(186, 54);
            this.buttonCallFormSub.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCallFormSub.TabIndex = 4;
            this.buttonCallFormSub.Text = "Tambah Sub Bidang/Bagian";
            // 
            // buttonBidangKembali
            // 
            this.buttonBidangKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBidangKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBidangKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBidangKembali.Location = new System.Drawing.Point(351, 323);
            this.buttonBidangKembali.Name = "buttonBidangKembali";
            this.buttonBidangKembali.Size = new System.Drawing.Size(186, 54);
            this.buttonBidangKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBidangKembali.TabIndex = 5;
            this.buttonBidangKembali.Text = "Kembali";
            this.buttonBidangKembali.Click += new System.EventHandler(this.buttonBidangKembali_Click);
            // 
            // labelCariBidang
            // 
            // 
            // 
            // 
            this.labelCariBidang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelCariBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBidang.Location = new System.Drawing.Point(12, 12);
            this.labelCariBidang.Name = "labelCariBidang";
            this.labelCariBidang.Size = new System.Drawing.Size(136, 23);
            this.labelCariBidang.TabIndex = 7;
            this.labelCariBidang.Text = "Cari Bidang/Bagian";
            // 
            // textBoxCariBidang
            // 
            // 
            // 
            // 
            this.textBoxCariBidang.Border.Class = "TextBoxBorder";
            this.textBoxCariBidang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCariBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCariBidang.Location = new System.Drawing.Point(12, 41);
            this.textBoxCariBidang.Name = "textBoxCariBidang";
            this.textBoxCariBidang.Size = new System.Drawing.Size(301, 26);
            this.textBoxCariBidang.TabIndex = 6;
            this.textBoxCariBidang.TextChanged += new System.EventHandler(this.textBoxCariBidang_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // FormBidang
            // 
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCariBidang);
            this.Controls.Add(this.textBoxCariBidang);
            this.Controls.Add(this.buttonBidangKembali);
            this.Controls.Add(this.buttonCallFormSub);
            this.Controls.Add(this.buttonHapusBidang);
            this.Controls.Add(this.buttonEditBidang);
            this.Controls.Add(this.buttonTambahBidang);
            this.Controls.Add(this.dataGridViewBidang);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormBidang";
            this.ShowIcon = false;
            this.Text = "Form Bidang & Sub";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBidang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBidang;
        private DevComponents.DotNetBar.ButtonX buttonTambahBidang;
        private DevComponents.DotNetBar.ButtonX buttonEditBidang;
        private DevComponents.DotNetBar.ButtonX buttonHapusBidang;
        private DevComponents.DotNetBar.ButtonX buttonCallFormSub;
        private DevComponents.DotNetBar.ButtonX buttonBidangKembali;
        private DevComponents.DotNetBar.LabelX labelCariBidang;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCariBidang;
        private System.Windows.Forms.TextBox textBox1;
    }
}