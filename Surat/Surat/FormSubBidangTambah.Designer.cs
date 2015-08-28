namespace Surat
{
    partial class FormSubBidangTambah
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
            this.buttonSubBidangTambahKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonSubBidangTambah = new DevComponents.DotNetBar.ButtonX();
            this.labelBidangTambah = new DevComponents.DotNetBar.LabelX();
            this.textBoxSubBidangTambah = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonSubBidangTambahKembali
            // 
            this.buttonSubBidangTambahKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSubBidangTambahKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSubBidangTambahKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubBidangTambahKembali.Location = new System.Drawing.Point(158, 96);
            this.buttonSubBidangTambahKembali.Name = "buttonSubBidangTambahKembali";
            this.buttonSubBidangTambahKembali.Size = new System.Drawing.Size(126, 42);
            this.buttonSubBidangTambahKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSubBidangTambahKembali.TabIndex = 11;
            this.buttonSubBidangTambahKembali.Text = "Kembali";
            this.buttonSubBidangTambahKembali.Click += new System.EventHandler(this.buttonSubBidangTambahKembali_Click);
            // 
            // buttonSubBidangTambah
            // 
            this.buttonSubBidangTambah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSubBidangTambah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSubBidangTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubBidangTambah.Location = new System.Drawing.Point(10, 96);
            this.buttonSubBidangTambah.Name = "buttonSubBidangTambah";
            this.buttonSubBidangTambah.Size = new System.Drawing.Size(126, 42);
            this.buttonSubBidangTambah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSubBidangTambah.TabIndex = 10;
            this.buttonSubBidangTambah.Text = "Tambah Data";
            this.buttonSubBidangTambah.Click += new System.EventHandler(this.buttonSubBidangTambah_Click);
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
            this.labelBidangTambah.Size = new System.Drawing.Size(158, 23);
            this.labelBidangTambah.TabIndex = 9;
            this.labelBidangTambah.Text = "Sub Bagian/Bidang Baru";
            // 
            // textBoxSubBidangTambah
            // 
            // 
            // 
            // 
            this.textBoxSubBidangTambah.Border.Class = "TextBoxBorder";
            this.textBoxSubBidangTambah.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxSubBidangTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubBidangTambah.Location = new System.Drawing.Point(9, 47);
            this.textBoxSubBidangTambah.MaxLength = 50;
            this.textBoxSubBidangTambah.Name = "textBoxSubBidangTambah";
            this.textBoxSubBidangTambah.Size = new System.Drawing.Size(275, 26);
            this.textBoxSubBidangTambah.TabIndex = 8;
            // 
            // FormSubBidangTambah
            // 
            this.ClientSize = new System.Drawing.Size(293, 156);
            this.Controls.Add(this.buttonSubBidangTambahKembali);
            this.Controls.Add(this.buttonSubBidangTambah);
            this.Controls.Add(this.labelBidangTambah);
            this.Controls.Add(this.textBoxSubBidangTambah);
            this.DoubleBuffered = true;
            this.Name = "FormSubBidangTambah";
            this.Text = "FormSubBidangTambah";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonSubBidangTambahKembali;
        private DevComponents.DotNetBar.ButtonX buttonSubBidangTambah;
        private DevComponents.DotNetBar.LabelX labelBidangTambah;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxSubBidangTambah;
    }
}