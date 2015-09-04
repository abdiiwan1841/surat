namespace Surat
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new DevComponents.DotNetBar.LabelX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.buttonKeluar = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.textBoxUsername.Border.Class = "TextBoxBorder";
            this.textBoxUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxUsername.Location = new System.Drawing.Point(101, 118);
            this.textBoxUsername.MaxLength = 19;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(288, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPassword.Location = new System.Drawing.Point(101, 160);
            this.textBoxPassword.MaxLength = 10;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(288, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            // 
            // 
            // 
            this.labelUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(20, 118);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 23);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            // 
            // 
            // 
            this.labelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(20, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Image = global::Surat.Properties.Resources.Kyo_Tux_Delikate_Close;
            this.buttonKeluar.Location = new System.Drawing.Point(252, 206);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(137, 44);
            this.buttonKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKeluar.TabIndex = 5;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Surat.Properties.Resources.RRI;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Image = global::Surat.Properties.Resources.Everaldo_Crystal_Clear_App_login_manager;
            this.buttonLogin.Location = new System.Drawing.Point(13, 206);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(145, 44);
            this.buttonLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(410, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private DevComponents.DotNetBar.LabelX labelUsername;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.ButtonX buttonLogin;
        private DevComponents.DotNetBar.ButtonX buttonKeluar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}