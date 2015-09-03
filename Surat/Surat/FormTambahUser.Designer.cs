namespace Surat
{
    partial class FormTambahUser
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
            this.LabelNamaLengkap = new DevComponents.DotNetBar.LabelX();
            this.txtBoxnama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBoxusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBoxpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ButtonSimpanTambah = new DevComponents.DotNetBar.ButtonX();
            this.ButtonKembaliTambahUser = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPasswordLagi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // LabelNamaLengkap
            // 
            // 
            // 
            // 
            this.LabelNamaLengkap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelNamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNamaLengkap.Location = new System.Drawing.Point(12, 22);
            this.LabelNamaLengkap.Name = "LabelNamaLengkap";
            this.LabelNamaLengkap.Size = new System.Drawing.Size(122, 23);
            this.LabelNamaLengkap.TabIndex = 0;
            this.LabelNamaLengkap.Text = "Nama Lengkap";
            // 
            // txtBoxnama
            // 
            // 
            // 
            // 
            this.txtBoxnama.Border.Class = "TextBoxBorder";
            this.txtBoxnama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBoxnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBoxnama.Location = new System.Drawing.Point(175, 23);
            this.txtBoxnama.MaxLength = 40;
            this.txtBoxnama.Name = "txtBoxnama";
            this.txtBoxnama.Size = new System.Drawing.Size(275, 22);
            this.txtBoxnama.TabIndex = 1;
            // 
            // txtBoxusername
            // 
            // 
            // 
            // 
            this.txtBoxusername.Border.Class = "TextBoxBorder";
            this.txtBoxusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBoxusername.Location = new System.Drawing.Point(175, 64);
            this.txtBoxusername.MaxLength = 19;
            this.txtBoxusername.Name = "txtBoxusername";
            this.txtBoxusername.Size = new System.Drawing.Size(275, 22);
            this.txtBoxusername.TabIndex = 2;
            // 
            // txtBoxpassword
            // 
            // 
            // 
            // 
            this.txtBoxpassword.Border.Class = "TextBoxBorder";
            this.txtBoxpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBoxpassword.Location = new System.Drawing.Point(175, 122);
            this.txtBoxpassword.MaxLength = 10;
            this.txtBoxpassword.Name = "txtBoxpassword";
            this.txtBoxpassword.PasswordChar = '*';
            this.txtBoxpassword.Size = new System.Drawing.Size(275, 22);
            this.txtBoxpassword.TabIndex = 3;
            // 
            // labelUsername
            // 
            // 
            // 
            // 
            this.labelUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(12, 62);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 120);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Password";
            // 
            // ButtonSimpanTambah
            // 
            this.ButtonSimpanTambah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSimpanTambah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSimpanTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSimpanTambah.Location = new System.Drawing.Point(76, 219);
            this.ButtonSimpanTambah.Name = "ButtonSimpanTambah";
            this.ButtonSimpanTambah.Size = new System.Drawing.Size(126, 42);
            this.ButtonSimpanTambah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSimpanTambah.TabIndex = 6;
            this.ButtonSimpanTambah.Text = "Tambah Data";
            this.ButtonSimpanTambah.Click += new System.EventHandler(this.ButtonSimpanTambah_Click);
            // 
            // ButtonKembaliTambahUser
            // 
            this.ButtonKembaliTambahUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonKembaliTambahUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonKembaliTambahUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonKembaliTambahUser.Location = new System.Drawing.Point(254, 219);
            this.ButtonKembaliTambahUser.Name = "ButtonKembaliTambahUser";
            this.ButtonKembaliTambahUser.Size = new System.Drawing.Size(126, 42);
            this.ButtonKembaliTambahUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonKembaliTambahUser.TabIndex = 7;
            this.ButtonKembaliTambahUser.Text = "Kembali";
            this.ButtonKembaliTambahUser.Click += new System.EventHandler(this.ButtonKembaliTambahUser_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(12, 157);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(157, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Masukkan Password Lagi";
            // 
            // textBoxPasswordLagi
            // 
            // 
            // 
            // 
            this.textBoxPasswordLagi.Border.Class = "TextBoxBorder";
            this.textBoxPasswordLagi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPasswordLagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxPasswordLagi.Location = new System.Drawing.Point(175, 159);
            this.textBoxPasswordLagi.MaxLength = 10;
            this.textBoxPasswordLagi.Name = "textBoxPasswordLagi";
            this.textBoxPasswordLagi.PasswordChar = '*';
            this.textBoxPasswordLagi.Size = new System.Drawing.Size(275, 22);
            this.textBoxPasswordLagi.TabIndex = 8;
            // 
            // FormTambahUser
            // 
            this.ClientSize = new System.Drawing.Size(462, 290);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxPasswordLagi);
            this.Controls.Add(this.ButtonKembaliTambahUser);
            this.Controls.Add(this.ButtonSimpanTambah);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtBoxpassword);
            this.Controls.Add(this.txtBoxusername);
            this.Controls.Add(this.txtBoxnama);
            this.Controls.Add(this.LabelNamaLengkap);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormTambahUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah User Baru";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LabelNamaLengkap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBoxnama;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBoxusername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBoxpassword;
        private DevComponents.DotNetBar.LabelX labelUsername;
        private DevComponents.DotNetBar.ButtonX ButtonSimpanTambah;
        private DevComponents.DotNetBar.ButtonX ButtonKembaliTambahUser;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPasswordLagi;
    }
}