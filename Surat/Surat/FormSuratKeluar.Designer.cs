namespace Surat
{
    partial class FormSuratKeluar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCariSuratKeluar = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.radioButtonPerihalSuratKeluar = new System.Windows.Forms.RadioButton();
            this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorSuratKeluar = new System.Windows.Forms.RadioButton();
            this.textBoxCariSuratKeluar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputSuratKeluar = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonTambahSuratKeluar = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttondetailsuratkeluar = new DevComponents.DotNetBar.ButtonX();
            this.buttonsimpansuratkeluar = new DevComponents.DotNetBar.ButtonX();
            this.labelJumlahSurat = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBoxCariSuratKeluar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputSuratKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCariSuratKeluar
            // 
            this.groupBoxCariSuratKeluar.Controls.Add(this.labelX1);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonPerihalSuratKeluar);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonTanggal);
            this.groupBoxCariSuratKeluar.Controls.Add(this.radioButtonNomorSuratKeluar);
            this.groupBoxCariSuratKeluar.Controls.Add(this.textBoxCariSuratKeluar);
            this.groupBoxCariSuratKeluar.Controls.Add(this.dateTimeInputSuratKeluar);
            this.groupBoxCariSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCariSuratKeluar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCariSuratKeluar.Name = "groupBoxCariSuratKeluar";
            this.groupBoxCariSuratKeluar.Size = new System.Drawing.Size(801, 111);
            this.groupBoxCariSuratKeluar.TabIndex = 2;
            this.groupBoxCariSuratKeluar.TabStop = false;
            this.groupBoxCariSuratKeluar.Text = "Pencarian Data Surat Keluar";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(263, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Pencarian Data Surat Masuk Berdasarkan:";
            // 
            // radioButtonPerihalSuratKeluar
            // 
            this.radioButtonPerihalSuratKeluar.AutoSize = true;
            this.radioButtonPerihalSuratKeluar.Location = new System.Drawing.Point(167, 43);
            this.radioButtonPerihalSuratKeluar.Name = "radioButtonPerihalSuratKeluar";
            this.radioButtonPerihalSuratKeluar.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPerihalSuratKeluar.TabIndex = 2;
            this.radioButtonPerihalSuratKeluar.Text = "Perihal";
            this.radioButtonPerihalSuratKeluar.UseVisualStyleBackColor = true;
            this.radioButtonPerihalSuratKeluar.CheckedChanged += new System.EventHandler(this.radioButtonPerihalSuratKeluar_CheckedChanged);
            // 
            // radioButtonTanggal
            // 
            this.radioButtonTanggal.AutoSize = true;
            this.radioButtonTanggal.Location = new System.Drawing.Point(265, 43);
            this.radioButtonTanggal.Name = "radioButtonTanggal";
            this.radioButtonTanggal.Size = new System.Drawing.Size(77, 20);
            this.radioButtonTanggal.TabIndex = 1;
            this.radioButtonTanggal.Text = "Tanggal";
            this.radioButtonTanggal.UseVisualStyleBackColor = true;
            this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
            // 
            // radioButtonNomorSuratKeluar
            // 
            this.radioButtonNomorSuratKeluar.AutoSize = true;
            this.radioButtonNomorSuratKeluar.Checked = true;
            this.radioButtonNomorSuratKeluar.Location = new System.Drawing.Point(16, 43);
            this.radioButtonNomorSuratKeluar.Name = "radioButtonNomorSuratKeluar";
            this.radioButtonNomorSuratKeluar.Size = new System.Drawing.Size(101, 20);
            this.radioButtonNomorSuratKeluar.TabIndex = 0;
            this.radioButtonNomorSuratKeluar.TabStop = true;
            this.radioButtonNomorSuratKeluar.Text = "Nomor Surat";
            this.radioButtonNomorSuratKeluar.UseVisualStyleBackColor = true;
            this.radioButtonNomorSuratKeluar.CheckedChanged += new System.EventHandler(this.radioButtonNomorSuratKeluar_CheckedChanged);
            // 
            // textBoxCariSuratKeluar
            // 
            // 
            // 
            // 
            this.textBoxCariSuratKeluar.Border.Class = "TextBoxBorder";
            this.textBoxCariSuratKeluar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCariSuratKeluar.Location = new System.Drawing.Point(16, 73);
            this.textBoxCariSuratKeluar.Name = "textBoxCariSuratKeluar";
            this.textBoxCariSuratKeluar.Size = new System.Drawing.Size(762, 22);
            this.textBoxCariSuratKeluar.TabIndex = 4;
            this.textBoxCariSuratKeluar.TextChanged += new System.EventHandler(this.textBoxCariSuratKeluar_TextChanged);
            // 
            // dateTimeInputSuratKeluar
            // 
            // 
            // 
            // 
            this.dateTimeInputSuratKeluar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputSuratKeluar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputSuratKeluar.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputSuratKeluar.ButtonDropDown.Visible = true;
            this.dateTimeInputSuratKeluar.IsPopupCalendarOpen = false;
            this.dateTimeInputSuratKeluar.Location = new System.Drawing.Point(16, 73);
            // 
            // 
            // 
            this.dateTimeInputSuratKeluar.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputSuratKeluar.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputSuratKeluar.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputSuratKeluar.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputSuratKeluar.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputSuratKeluar.MonthCalendar.DisplayMonth = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dateTimeInputSuratKeluar.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimeInputSuratKeluar.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputSuratKeluar.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputSuratKeluar.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputSuratKeluar.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputSuratKeluar.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputSuratKeluar.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputSuratKeluar.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputSuratKeluar.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputSuratKeluar.MonthCalendar.DateChanged += new System.EventHandler(this.dateTimeInputSuratKeluar_MonthCalendar_DateChanged);
            this.dateTimeInputSuratKeluar.Name = "dateTimeInputSuratKeluar";
            this.dateTimeInputSuratKeluar.Size = new System.Drawing.Size(761, 22);
            this.dateTimeInputSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputSuratKeluar.TabIndex = 5;
            // 
            // buttonKembali
            // 
            this.buttonKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(830, 482);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(106, 45);
            this.buttonKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembali.TabIndex = 10;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonEditSuratKeluar
            // 
            this.buttonEditSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSuratKeluar.Location = new System.Drawing.Point(830, 115);
            this.buttonEditSuratKeluar.Name = "buttonEditSuratKeluar";
            this.buttonEditSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonEditSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSuratKeluar.TabIndex = 9;
            this.buttonEditSuratKeluar.Text = "Edit";
            this.buttonEditSuratKeluar.Click += new System.EventHandler(this.buttonEditSuratKeluar_Click);
            // 
            // buttonHapusSuratKeluar
            // 
            this.buttonHapusSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusSuratKeluar.Location = new System.Drawing.Point(830, 166);
            this.buttonHapusSuratKeluar.Name = "buttonHapusSuratKeluar";
            this.buttonHapusSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonHapusSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusSuratKeluar.TabIndex = 8;
            this.buttonHapusSuratKeluar.Text = "Hapus";
            this.buttonHapusSuratKeluar.Click += new System.EventHandler(this.buttonHapusSuratKeluar_Click);
            // 
            // buttonTambahSuratKeluar
            // 
            this.buttonTambahSuratKeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahSuratKeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahSuratKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSuratKeluar.Location = new System.Drawing.Point(830, 14);
            this.buttonTambahSuratKeluar.Name = "buttonTambahSuratKeluar";
            this.buttonTambahSuratKeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonTambahSuratKeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahSuratKeluar.TabIndex = 7;
            this.buttonTambahSuratKeluar.Text = "Tambah";
            this.buttonTambahSuratKeluar.Click += new System.EventHandler(this.buttonTambahSuratKeluar_Click);
            // 
            // dataGridViewSuratKeluar
            // 
            this.dataGridViewSuratKeluar.AllowUserToAddRows = false;
            this.dataGridViewSuratKeluar.AllowUserToDeleteRows = false;
            this.dataGridViewSuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuratKeluar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSuratKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSuratKeluar.Location = new System.Drawing.Point(9, 133);
            this.dataGridViewSuratKeluar.Name = "dataGridViewSuratKeluar";
            this.dataGridViewSuratKeluar.ReadOnly = true;
            this.dataGridViewSuratKeluar.RowHeadersVisible = false;
            this.dataGridViewSuratKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuratKeluar.Size = new System.Drawing.Size(801, 394);
            this.dataGridViewSuratKeluar.TabIndex = 6;
            this.dataGridViewSuratKeluar.SelectionChanged += new System.EventHandler(this.dataGridViewSuratKeluar_SelectionChanged);
            // 
            // buttondetailsuratkeluar
            // 
            this.buttondetailsuratkeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttondetailsuratkeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttondetailsuratkeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondetailsuratkeluar.Location = new System.Drawing.Point(830, 65);
            this.buttondetailsuratkeluar.Name = "buttondetailsuratkeluar";
            this.buttondetailsuratkeluar.Size = new System.Drawing.Size(106, 45);
            this.buttondetailsuratkeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttondetailsuratkeluar.TabIndex = 11;
            this.buttondetailsuratkeluar.Text = "Detail";
            this.buttondetailsuratkeluar.Click += new System.EventHandler(this.buttondetailsuratkeluar_Click);
            // 
            // buttonsimpansuratkeluar
            // 
            this.buttonsimpansuratkeluar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonsimpansuratkeluar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonsimpansuratkeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsimpansuratkeluar.Location = new System.Drawing.Point(830, 218);
            this.buttonsimpansuratkeluar.Name = "buttonsimpansuratkeluar";
            this.buttonsimpansuratkeluar.Size = new System.Drawing.Size(106, 45);
            this.buttonsimpansuratkeluar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonsimpansuratkeluar.TabIndex = 12;
            this.buttonsimpansuratkeluar.Text = "Simpan ke\r\nFile Excel";
            this.buttonsimpansuratkeluar.Click += new System.EventHandler(this.buttonsimpansuratkeluar_Click);
            // 
            // labelJumlahSurat
            // 
            // 
            // 
            // 
            this.labelJumlahSurat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelJumlahSurat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahSurat.Location = new System.Drawing.Point(9, 533);
            this.labelJumlahSurat.Name = "labelJumlahSurat";
            this.labelJumlahSurat.Size = new System.Drawing.Size(170, 23);
            this.labelJumlahSurat.TabIndex = 13;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(830, 269);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 14;
            this.buttonX1.Text = "Rekap Jumlah Surat";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FormSuratKeluar
            // 
            this.ClientSize = new System.Drawing.Size(945, 565);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelJumlahSurat);
            this.Controls.Add(this.buttonsimpansuratkeluar);
            this.Controls.Add(this.buttondetailsuratkeluar);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonEditSuratKeluar);
            this.Controls.Add(this.buttonHapusSuratKeluar);
            this.Controls.Add(this.buttonTambahSuratKeluar);
            this.Controls.Add(this.dataGridViewSuratKeluar);
            this.Controls.Add(this.groupBoxCariSuratKeluar);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormSuratKeluar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Keluar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratKeluar_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratKeluar_Load);
            this.groupBoxCariSuratKeluar.ResumeLayout(false);
            this.groupBoxCariSuratKeluar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputSuratKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratKeluar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCariSuratKeluar;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCariSuratKeluar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton radioButtonPerihalSuratKeluar;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.RadioButton radioButtonNomorSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonKembali;
        private DevComponents.DotNetBar.ButtonX buttonEditSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonHapusSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonTambahSuratKeluar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttondetailsuratkeluar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputSuratKeluar;
        private DevComponents.DotNetBar.ButtonX buttonsimpansuratkeluar;
        private DevComponents.DotNetBar.LabelX labelJumlahSurat;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}