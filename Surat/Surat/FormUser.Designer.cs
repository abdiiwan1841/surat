namespace Surat
{
    partial class FormUser
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtboxsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonTambahUser = new DevComponents.DotNetBar.ButtonX();
            this.dataGridUser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ButtonEditUser = new DevComponents.DotNetBar.ButtonX();
            this.ButtonHapusUser = new DevComponents.DotNetBar.ButtonX();
            this.ButtonKembaliUser = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Cari User";
            // 
            // txtboxsearch
            // 
            // 
            // 
            // 
            this.txtboxsearch.Border.Class = "TextBoxBorder";
            this.txtboxsearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtboxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxsearch.Location = new System.Drawing.Point(12, 41);
            this.txtboxsearch.MaxLength = 40;
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(301, 26);
            this.txtboxsearch.TabIndex = 2;
            // 
            // ButtonTambahUser
            // 
            this.ButtonTambahUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonTambahUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonTambahUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonTambahUser.Location = new System.Drawing.Point(351, 29);
            this.ButtonTambahUser.Name = "ButtonTambahUser";
            this.ButtonTambahUser.Size = new System.Drawing.Size(186, 54);
            this.ButtonTambahUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonTambahUser.TabIndex = 3;
            this.ButtonTambahUser.Text = "Tambah";
            this.ButtonTambahUser.Click += new System.EventHandler(this.ButtonTambahUser_Click);
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridUser.Location = new System.Drawing.Point(12, 84);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUser.Size = new System.Drawing.Size(301, 255);
            this.dataGridUser.TabIndex = 4;
            this.dataGridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellContentClick);
            this.dataGridUser.SelectionChanged += new System.EventHandler(this.dataGridUser_SelectionChanged);
            // 
            // ButtonEditUser
            // 
            this.ButtonEditUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonEditUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonEditUser.Location = new System.Drawing.Point(351, 100);
            this.ButtonEditUser.Name = "ButtonEditUser";
            this.ButtonEditUser.Size = new System.Drawing.Size(186, 54);
            this.ButtonEditUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonEditUser.TabIndex = 5;
            this.ButtonEditUser.Text = "Edit";
            this.ButtonEditUser.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // ButtonHapusUser
            // 
            this.ButtonHapusUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonHapusUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonHapusUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHapusUser.Location = new System.Drawing.Point(351, 170);
            this.ButtonHapusUser.Name = "ButtonHapusUser";
            this.ButtonHapusUser.Size = new System.Drawing.Size(186, 54);
            this.ButtonHapusUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonHapusUser.TabIndex = 6;
            this.ButtonHapusUser.Text = "Hapus Data";
            this.ButtonHapusUser.Click += new System.EventHandler(this.ButtonHapusUser_Click);
            // 
            // ButtonKembaliUser
            // 
            this.ButtonKembaliUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonKembaliUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonKembaliUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonKembaliUser.Location = new System.Drawing.Point(351, 285);
            this.ButtonKembaliUser.Name = "ButtonKembaliUser";
            this.ButtonKembaliUser.Size = new System.Drawing.Size(186, 54);
            this.ButtonKembaliUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonKembaliUser.TabIndex = 7;
            this.ButtonKembaliUser.Text = "Kembali";
            this.ButtonKembaliUser.Click += new System.EventHandler(this.ButtonKembaliUser_Click);
            // 
            // FormUser
            // 
            this.ClientSize = new System.Drawing.Size(543, 351);
            this.Controls.Add(this.ButtonKembaliUser);
            this.Controls.Add(this.ButtonHapusUser);
            this.Controls.Add(this.ButtonEditUser);
            this.Controls.Add(this.dataGridUser);
            this.Controls.Add(this.ButtonTambahUser);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.ShowIcon = false;
            this.Text = "Manajemen User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtboxsearch;
        private DevComponents.DotNetBar.ButtonX ButtonTambahUser;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridUser;
        private DevComponents.DotNetBar.ButtonX ButtonEditUser;
        private DevComponents.DotNetBar.ButtonX ButtonHapusUser;
        private DevComponents.DotNetBar.ButtonX ButtonKembaliUser;


    }
}