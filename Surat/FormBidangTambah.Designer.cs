namespace Surat
{
    partial class FormBidangTambah
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
            this.buttonBidangTambahKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonBidangTambah = new DevComponents.DotNetBar.ButtonX();
            this.labelBidangTambah = new DevComponents.DotNetBar.LabelX();
            this.textBoxBidangTambah = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonBidangTambahKembali
            // 
            this.buttonBidangTambahKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBidangTambahKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBidangTambahKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBidangTambahKembali.Location = new System.Drawing.Point(158, 96);
            this.buttonBidangTambahKembali.Name = "buttonBidangTambahKembali";
            this.buttonBidangTambahKembali.Size = new System.Drawing.Size(126, 42);
            this.buttonBidangTambahKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBidangTambahKembali.TabIndex = 7;
            this.buttonBidangTambahKembali.Text = "Kembali";
            this.buttonBidangTambahKembali.Click += new System.EventHandler(this.buttonBidangTambahKembali_Click);
            // 
            // buttonBidangTambah
            // 
            this.buttonBidangTambah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBidangTambah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBidangTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBidangTambah.Location = new System.Drawing.Point(10, 96);
            this.buttonBidangTambah.Name = "buttonBidangTambah";
            this.buttonBidangTambah.Size = new System.Drawing.Size(126, 42);
            this.buttonBidangTambah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBidangTambah.TabIndex = 6;
            this.buttonBidangTambah.Text = "Tambah Data";
            this.buttonBidangTambah.Click += new System.EventHandler(this.buttonBidangTambah_Click);
            // 
            // labelBidangTambah
            // 
            // 
            // 
            // 
            this.labelBidangTambah.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBidangTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidangTambah.Location = new System.Drawing.Point(10, 18);
            this.labelBidangTambah.Name = "labelBidangTambah";
            this.labelBidangTambah.Size = new System.Drawing.Size(115, 23);
            this.labelBidangTambah.TabIndex = 5;
            this.labelBidangTambah.Text = "Bagian/Bidang Baru";
            // 
            // textBoxBidangTambah
            // 
            // 
            // 
            // 
            this.textBoxBidangTambah.Border.Class = "TextBoxBorder";
            this.textBoxBidangTambah.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxBidangTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidangTambah.Location = new System.Drawing.Point(9, 47);
            this.textBoxBidangTambah.MaxLength = 20;
            this.textBoxBidangTambah.Name = "textBoxBidangTambah";
            this.textBoxBidangTambah.Size = new System.Drawing.Size(275, 26);
            this.textBoxBidangTambah.TabIndex = 4;
            // 
            // FormBidangTambah
            // 
            this.ClientSize = new System.Drawing.Size(293, 156);
            this.Controls.Add(this.buttonBidangTambahKembali);
            this.Controls.Add(this.buttonBidangTambah);
            this.Controls.Add(this.labelBidangTambah);
            this.Controls.Add(this.textBoxBidangTambah);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MaximizeBox = false;
            this.Name = "FormBidangTambah";
            this.ShowIcon = false;
            this.Text = "Tambah Bagian/Bidang";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonBidangTambahKembali;
        private DevComponents.DotNetBar.ButtonX buttonBidangTambah;
        private DevComponents.DotNetBar.LabelX labelBidangTambah;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxBidangTambah;
    }
}