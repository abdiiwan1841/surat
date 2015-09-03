namespace Surat
{
    partial class FormSuratMasuk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSuratMasuk = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBoxCariSuratMasuk = new System.Windows.Forms.GroupBox();
            this.radioButtonTanggalSurat = new System.Windows.Forms.RadioButton();
            this.textBoxCariSuratMasuk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.radioButtonPerihalSuratMasuk = new System.Windows.Forms.RadioButton();
            this.radioButtonInstansiPengirim = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorSuratMasuk = new System.Windows.Forms.RadioButton();
            this.dateTimeInputTanggalSurat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonTambahSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonDetail = new DevComponents.DotNetBar.ButtonX();
            this.buttonExcel = new DevComponents.DotNetBar.ButtonX();
            this.labelJumlahSurat = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratMasuk)).BeginInit();
            this.groupBoxCariSuratMasuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputTanggalSurat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSuratMasuk
            // 
            this.dataGridViewSuratMasuk.AllowUserToAddRows = false;
            this.dataGridViewSuratMasuk.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuratMasuk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuratMasuk.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSuratMasuk.EnableHeadersVisualStyles = false;
            this.dataGridViewSuratMasuk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSuratMasuk.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewSuratMasuk.Name = "dataGridViewSuratMasuk";
            this.dataGridViewSuratMasuk.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuratMasuk.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSuratMasuk.RowHeadersVisible = false;
            this.dataGridViewSuratMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuratMasuk.Size = new System.Drawing.Size(801, 394);
            this.dataGridViewSuratMasuk.TabIndex = 0;
            this.dataGridViewSuratMasuk.SelectionChanged += new System.EventHandler(this.dataGridViewSuratMasuk_SelectionChanged);
            // 
            // groupBoxCariSuratMasuk
            // 
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonTanggalSurat);
            this.groupBoxCariSuratMasuk.Controls.Add(this.textBoxCariSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.labelX1);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonPerihalSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonInstansiPengirim);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonNomorSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.dateTimeInputTanggalSurat);
            this.groupBoxCariSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCariSuratMasuk.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCariSuratMasuk.Name = "groupBoxCariSuratMasuk";
            this.groupBoxCariSuratMasuk.Size = new System.Drawing.Size(801, 111);
            this.groupBoxCariSuratMasuk.TabIndex = 1;
            this.groupBoxCariSuratMasuk.TabStop = false;
            this.groupBoxCariSuratMasuk.Text = "Pencarian Data Surat Masuk";
            // 
            // radioButtonTanggalSurat
            // 
            this.radioButtonTanggalSurat.AutoSize = true;
            this.radioButtonTanggalSurat.Location = new System.Drawing.Point(418, 43);
            this.radioButtonTanggalSurat.Name = "radioButtonTanggalSurat";
            this.radioButtonTanggalSurat.Size = new System.Drawing.Size(111, 20);
            this.radioButtonTanggalSurat.TabIndex = 5;
            this.radioButtonTanggalSurat.Text = "Tanggal Surat";
            this.radioButtonTanggalSurat.UseVisualStyleBackColor = true;
            this.radioButtonTanggalSurat.CheckedChanged += new System.EventHandler(this.radioButtonTanggalSurat_CheckedChanged);
            // 
            // textBoxCariSuratMasuk
            // 
            // 
            // 
            // 
            this.textBoxCariSuratMasuk.Border.Class = "TextBoxBorder";
            this.textBoxCariSuratMasuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCariSuratMasuk.Location = new System.Drawing.Point(16, 73);
            this.textBoxCariSuratMasuk.Name = "textBoxCariSuratMasuk";
            this.textBoxCariSuratMasuk.Size = new System.Drawing.Size(762, 22);
            this.textBoxCariSuratMasuk.TabIndex = 4;
            this.textBoxCariSuratMasuk.TextChanged += new System.EventHandler(this.textBoxCariSuratMasuk_TextChanged);
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
            // radioButtonPerihalSuratMasuk
            // 
            this.radioButtonPerihalSuratMasuk.AutoSize = true;
            this.radioButtonPerihalSuratMasuk.Location = new System.Drawing.Point(167, 43);
            this.radioButtonPerihalSuratMasuk.Name = "radioButtonPerihalSuratMasuk";
            this.radioButtonPerihalSuratMasuk.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPerihalSuratMasuk.TabIndex = 2;
            this.radioButtonPerihalSuratMasuk.Text = "Perihal";
            this.radioButtonPerihalSuratMasuk.UseVisualStyleBackColor = true;
            this.radioButtonPerihalSuratMasuk.CheckedChanged += new System.EventHandler(this.radioButtonPerihalSuratMasuk_CheckedChanged);
            // 
            // radioButtonInstansiPengirim
            // 
            this.radioButtonInstansiPengirim.AutoSize = true;
            this.radioButtonInstansiPengirim.Location = new System.Drawing.Point(265, 43);
            this.radioButtonInstansiPengirim.Name = "radioButtonInstansiPengirim";
            this.radioButtonInstansiPengirim.Size = new System.Drawing.Size(127, 20);
            this.radioButtonInstansiPengirim.TabIndex = 1;
            this.radioButtonInstansiPengirim.Text = "Instansi Pengirim";
            this.radioButtonInstansiPengirim.UseVisualStyleBackColor = true;
            this.radioButtonInstansiPengirim.CheckedChanged += new System.EventHandler(this.radioButtonInstansiPengirim_CheckedChanged);
            // 
            // radioButtonNomorSuratMasuk
            // 
            this.radioButtonNomorSuratMasuk.AutoSize = true;
            this.radioButtonNomorSuratMasuk.Checked = true;
            this.radioButtonNomorSuratMasuk.Location = new System.Drawing.Point(16, 43);
            this.radioButtonNomorSuratMasuk.Name = "radioButtonNomorSuratMasuk";
            this.radioButtonNomorSuratMasuk.Size = new System.Drawing.Size(101, 20);
            this.radioButtonNomorSuratMasuk.TabIndex = 0;
            this.radioButtonNomorSuratMasuk.TabStop = true;
            this.radioButtonNomorSuratMasuk.Text = "Nomor Surat";
            this.radioButtonNomorSuratMasuk.UseVisualStyleBackColor = true;
            this.radioButtonNomorSuratMasuk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimeInputTanggalSurat
            // 
            // 
            // 
            // 
            this.dateTimeInputTanggalSurat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputTanggalSurat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputTanggalSurat.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputTanggalSurat.ButtonDropDown.Visible = true;
            this.dateTimeInputTanggalSurat.CustomFormat = "dd-MM-yyyy";
            this.dateTimeInputTanggalSurat.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputTanggalSurat.IsPopupCalendarOpen = false;
            this.dateTimeInputTanggalSurat.Location = new System.Drawing.Point(16, 73);
            // 
            // 
            // 
            this.dateTimeInputTanggalSurat.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputTanggalSurat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputTanggalSurat.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputTanggalSurat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputTanggalSurat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputTanggalSurat.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dateTimeInputTanggalSurat.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputTanggalSurat.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputTanggalSurat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputTanggalSurat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputTanggalSurat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputTanggalSurat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputTanggalSurat.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputTanggalSurat.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputTanggalSurat.MonthCalendar.DateChanged += new System.EventHandler(this.dateTimeInput1_MonthCalendar_DateChanged);
            this.dateTimeInputTanggalSurat.Name = "dateTimeInputTanggalSurat";
            this.dateTimeInputTanggalSurat.Size = new System.Drawing.Size(762, 22);
            this.dateTimeInputTanggalSurat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputTanggalSurat.TabIndex = 6;
            // 
            // buttonTambahSuratMasuk
            // 
            this.buttonTambahSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSuratMasuk.Location = new System.Drawing.Point(833, 21);
            this.buttonTambahSuratMasuk.Name = "buttonTambahSuratMasuk";
            this.buttonTambahSuratMasuk.Size = new System.Drawing.Size(106, 45);
            this.buttonTambahSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahSuratMasuk.TabIndex = 2;
            this.buttonTambahSuratMasuk.Text = "Tambah";
            this.buttonTambahSuratMasuk.Click += new System.EventHandler(this.buttonTambahSuratMasuk_Click);
            // 
            // buttonHapusSuratDisposisi
            // 
            this.buttonHapusSuratDisposisi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHapusSuratDisposisi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHapusSuratDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusSuratDisposisi.Location = new System.Drawing.Point(833, 174);
            this.buttonHapusSuratDisposisi.Name = "buttonHapusSuratDisposisi";
            this.buttonHapusSuratDisposisi.Size = new System.Drawing.Size(106, 45);
            this.buttonHapusSuratDisposisi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonHapusSuratDisposisi.TabIndex = 3;
            this.buttonHapusSuratDisposisi.Text = "Hapus";
            this.buttonHapusSuratDisposisi.Click += new System.EventHandler(this.buttonHapusSuratMasuk_Click);
            // 
            // buttonEditSuratDisposisi
            // 
            this.buttonEditSuratDisposisi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSuratDisposisi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSuratDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSuratDisposisi.Location = new System.Drawing.Point(833, 123);
            this.buttonEditSuratDisposisi.Name = "buttonEditSuratDisposisi";
            this.buttonEditSuratDisposisi.Size = new System.Drawing.Size(106, 45);
            this.buttonEditSuratDisposisi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSuratDisposisi.TabIndex = 4;
            this.buttonEditSuratDisposisi.Text = "Edit";
            this.buttonEditSuratDisposisi.Click += new System.EventHandler(this.buttonEditSuratMasuk_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(833, 489);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(106, 45);
            this.buttonKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembali.TabIndex = 5;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.Location = new System.Drawing.Point(833, 72);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(106, 45);
            this.buttonDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonDetail.TabIndex = 6;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Location = new System.Drawing.Point(833, 225);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(106, 61);
            this.buttonExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonExcel.TabIndex = 7;
            this.buttonExcel.Text = "Simpan ke \r\nFile Excel";
            this.buttonExcel.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelJumlahSurat
            // 
            // 
            // 
            // 
            this.labelJumlahSurat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelJumlahSurat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahSurat.Location = new System.Drawing.Point(12, 542);
            this.labelJumlahSurat.Name = "labelJumlahSurat";
            this.labelJumlahSurat.Size = new System.Drawing.Size(235, 23);
            this.labelJumlahSurat.TabIndex = 8;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(833, 292);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 61);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "Rekap Jumlah Surat";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // FormSuratMasuk
            // 
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelJumlahSurat);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonEditSuratDisposisi);
            this.Controls.Add(this.buttonHapusSuratDisposisi);
            this.Controls.Add(this.buttonTambahSuratMasuk);
            this.Controls.Add(this.groupBoxCariSuratMasuk);
            this.Controls.Add(this.dataGridViewSuratMasuk);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormSuratMasuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Surat Masuk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratMasuk_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratMasuk)).EndInit();
            this.groupBoxCariSuratMasuk.ResumeLayout(false);
            this.groupBoxCariSuratMasuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputTanggalSurat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSuratMasuk;
        private System.Windows.Forms.GroupBox groupBoxCariSuratMasuk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCariSuratMasuk;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton radioButtonPerihalSuratMasuk;
        private System.Windows.Forms.RadioButton radioButtonInstansiPengirim;
        private System.Windows.Forms.RadioButton radioButtonNomorSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonTambahSuratMasuk;
        private DevComponents.DotNetBar.ButtonX buttonHapusSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonEditSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonKembali;
        private DevComponents.DotNetBar.ButtonX buttonDetail;
        private System.Windows.Forms.RadioButton radioButtonTanggalSurat;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputTanggalSurat;
        private DevComponents.DotNetBar.ButtonX buttonExcel;
        private DevComponents.DotNetBar.LabelX labelJumlahSurat;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}