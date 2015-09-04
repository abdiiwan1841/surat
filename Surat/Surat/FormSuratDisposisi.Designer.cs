namespace Surat
{
    partial class FormSuratDisposisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuratDisposisi));
            this.buttonKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonHapusSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.groupBoxCariSuratMasuk = new System.Windows.Forms.GroupBox();
            this.radioButtonTanggalSurat = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorAgenda = new System.Windows.Forms.RadioButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.radioButtonPerihalSuratMasuk = new System.Windows.Forms.RadioButton();
            this.radioButtonAsalSurat = new System.Windows.Forms.RadioButton();
            this.radioButtonNomorSurat = new System.Windows.Forms.RadioButton();
            this.textBoxCari = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputTanggalSurat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dataGridViewSuratDisposisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonTambahSuratDisposisi = new DevComponents.DotNetBar.ButtonX();
            this.buttonDetail = new DevComponents.DotNetBar.ButtonX();
            this.buttonExcel = new DevComponents.DotNetBar.ButtonX();
            this.labelJumlahSurat = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.radioButtonTanggalTerima = new System.Windows.Forms.RadioButton();
            this.groupBoxCariSuratMasuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputTanggalSurat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratDisposisi)).BeginInit();
            this.SuspendLayout();
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
            this.buttonKembali.TabIndex = 10;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
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
            this.buttonEditSuratDisposisi.TabIndex = 9;
            this.buttonEditSuratDisposisi.Text = "Edit";
            this.buttonEditSuratDisposisi.Click += new System.EventHandler(this.buttonEditSuratDisposisi_Click);
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
            this.buttonHapusSuratDisposisi.TabIndex = 8;
            this.buttonHapusSuratDisposisi.Text = "Hapus";
            this.buttonHapusSuratDisposisi.Click += new System.EventHandler(this.buttonHapusSuratDisposisi_Click);
            // 
            // groupBoxCariSuratMasuk
            // 
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonTanggalTerima);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonTanggalSurat);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonNomorAgenda);
            this.groupBoxCariSuratMasuk.Controls.Add(this.labelX1);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonPerihalSuratMasuk);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonAsalSurat);
            this.groupBoxCariSuratMasuk.Controls.Add(this.radioButtonNomorSurat);
            this.groupBoxCariSuratMasuk.Controls.Add(this.textBoxCari);
            this.groupBoxCariSuratMasuk.Controls.Add(this.dateTimeInputTanggalSurat);
            this.groupBoxCariSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCariSuratMasuk.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCariSuratMasuk.Name = "groupBoxCariSuratMasuk";
            this.groupBoxCariSuratMasuk.Size = new System.Drawing.Size(801, 111);
            this.groupBoxCariSuratMasuk.TabIndex = 7;
            this.groupBoxCariSuratMasuk.TabStop = false;
            this.groupBoxCariSuratMasuk.Text = "Pencarian Data Surat Disposisi";
            // 
            // radioButtonTanggalSurat
            // 
            this.radioButtonTanggalSurat.AutoSize = true;
            this.radioButtonTanggalSurat.Location = new System.Drawing.Point(468, 43);
            this.radioButtonTanggalSurat.Name = "radioButtonTanggalSurat";
            this.radioButtonTanggalSurat.Size = new System.Drawing.Size(111, 20);
            this.radioButtonTanggalSurat.TabIndex = 6;
            this.radioButtonTanggalSurat.TabStop = true;
            this.radioButtonTanggalSurat.Text = "Tanggal Surat";
            this.radioButtonTanggalSurat.UseVisualStyleBackColor = true;
            this.radioButtonTanggalSurat.CheckedChanged += new System.EventHandler(this.radioButtonTanggalSurat_CheckedChanged);
            // 
            // radioButtonNomorAgenda
            // 
            this.radioButtonNomorAgenda.AutoSize = true;
            this.radioButtonNomorAgenda.Location = new System.Drawing.Point(133, 43);
            this.radioButtonNomorAgenda.Name = "radioButtonNomorAgenda";
            this.radioButtonNomorAgenda.Size = new System.Drawing.Size(118, 20);
            this.radioButtonNomorAgenda.TabIndex = 5;
            this.radioButtonNomorAgenda.TabStop = true;
            this.radioButtonNomorAgenda.Text = "Nomor Agenda";
            this.radioButtonNomorAgenda.UseVisualStyleBackColor = true;
            this.radioButtonNomorAgenda.CheckedChanged += new System.EventHandler(this.radioButtonNomorAgenda_CheckedChanged);
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
            this.radioButtonPerihalSuratMasuk.Location = new System.Drawing.Point(376, 43);
            this.radioButtonPerihalSuratMasuk.Name = "radioButtonPerihalSuratMasuk";
            this.radioButtonPerihalSuratMasuk.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPerihalSuratMasuk.TabIndex = 2;
            this.radioButtonPerihalSuratMasuk.Text = "Perihal";
            this.radioButtonPerihalSuratMasuk.UseVisualStyleBackColor = true;
            this.radioButtonPerihalSuratMasuk.CheckedChanged += new System.EventHandler(this.radioButtonPerihalSuratMasuk_CheckedChanged);
            // 
            // radioButtonAsalSurat
            // 
            this.radioButtonAsalSurat.AutoSize = true;
            this.radioButtonAsalSurat.Location = new System.Drawing.Point(268, 43);
            this.radioButtonAsalSurat.Name = "radioButtonAsalSurat";
            this.radioButtonAsalSurat.Size = new System.Drawing.Size(87, 20);
            this.radioButtonAsalSurat.TabIndex = 1;
            this.radioButtonAsalSurat.Text = "Asal Surat";
            this.radioButtonAsalSurat.UseVisualStyleBackColor = true;
            this.radioButtonAsalSurat.CheckedChanged += new System.EventHandler(this.radioButtonAsalSurat_CheckedChanged);
            // 
            // radioButtonNomorSurat
            // 
            this.radioButtonNomorSurat.AutoSize = true;
            this.radioButtonNomorSurat.Checked = true;
            this.radioButtonNomorSurat.Location = new System.Drawing.Point(16, 43);
            this.radioButtonNomorSurat.Name = "radioButtonNomorSurat";
            this.radioButtonNomorSurat.Size = new System.Drawing.Size(101, 20);
            this.radioButtonNomorSurat.TabIndex = 0;
            this.radioButtonNomorSurat.TabStop = true;
            this.radioButtonNomorSurat.Text = "Nomor Surat";
            this.radioButtonNomorSurat.UseVisualStyleBackColor = true;
            this.radioButtonNomorSurat.CheckedChanged += new System.EventHandler(this.radioButtonNomorSurat_CheckedChanged);
            // 
            // textBoxCari
            // 
            // 
            // 
            // 
            this.textBoxCari.Border.Class = "TextBoxBorder";
            this.textBoxCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCari.Location = new System.Drawing.Point(16, 73);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(762, 22);
            this.textBoxCari.TabIndex = 4;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
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
            this.dateTimeInputTanggalSurat.MonthCalendar.DateChanged += new System.EventHandler(this.dateTimeInputTanggalSurat_MonthCalendar_DateChanged);
            this.dateTimeInputTanggalSurat.Name = "dateTimeInputTanggalSurat";
            this.dateTimeInputTanggalSurat.Size = new System.Drawing.Size(762, 22);
            this.dateTimeInputTanggalSurat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputTanggalSurat.TabIndex = 7;
            // 
            // dataGridViewSuratDisposisi
            // 
            this.dataGridViewSuratDisposisi.AllowUserToAddRows = false;
            this.dataGridViewSuratDisposisi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuratDisposisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSuratDisposisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuratDisposisi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSuratDisposisi.EnableHeadersVisualStyles = false;
            this.dataGridViewSuratDisposisi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSuratDisposisi.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewSuratDisposisi.MultiSelect = false;
            this.dataGridViewSuratDisposisi.Name = "dataGridViewSuratDisposisi";
            this.dataGridViewSuratDisposisi.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuratDisposisi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSuratDisposisi.RowHeadersVisible = false;
            this.dataGridViewSuratDisposisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuratDisposisi.Size = new System.Drawing.Size(801, 348);
            this.dataGridViewSuratDisposisi.TabIndex = 6;
            this.dataGridViewSuratDisposisi.SelectionChanged += new System.EventHandler(this.dataGridViewSuratDisposisi_SelectionChanged);
            // 
            // buttonTambahSuratDisposisi
            // 
            this.buttonTambahSuratDisposisi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTambahSuratDisposisi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTambahSuratDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSuratDisposisi.Location = new System.Drawing.Point(833, 21);
            this.buttonTambahSuratDisposisi.Name = "buttonTambahSuratDisposisi";
            this.buttonTambahSuratDisposisi.Size = new System.Drawing.Size(106, 45);
            this.buttonTambahSuratDisposisi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTambahSuratDisposisi.TabIndex = 11;
            this.buttonTambahSuratDisposisi.Text = "Tambah";
            this.buttonTambahSuratDisposisi.Click += new System.EventHandler(this.buttonTambahSuratDisposisi_Click);
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
            this.buttonDetail.TabIndex = 12;
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
            this.buttonExcel.Size = new System.Drawing.Size(106, 51);
            this.buttonExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonExcel.TabIndex = 13;
            this.buttonExcel.Text = "Simpan ke\r\nFile Excel";
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // labelJumlahSurat
            // 
            // 
            // 
            // 
            this.labelJumlahSurat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelJumlahSurat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahSurat.Location = new System.Drawing.Point(12, 494);
            this.labelJumlahSurat.Name = "labelJumlahSurat";
            this.labelJumlahSurat.Size = new System.Drawing.Size(313, 23);
            this.labelJumlahSurat.TabIndex = 14;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(833, 282);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 51);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 15;
            this.buttonX1.Text = "Rekap Jumlah Surat";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // radioButtonTanggalTerima
            // 
            this.radioButtonTanggalTerima.AutoSize = true;
            this.radioButtonTanggalTerima.Location = new System.Drawing.Point(597, 43);
            this.radioButtonTanggalTerima.Name = "radioButtonTanggalTerima";
            this.radioButtonTanggalTerima.Size = new System.Drawing.Size(164, 20);
            this.radioButtonTanggalTerima.TabIndex = 8;
            this.radioButtonTanggalTerima.TabStop = true;
            this.radioButtonTanggalTerima.Text = "Tanggal DIterima Surat";
            this.radioButtonTanggalTerima.UseVisualStyleBackColor = true;
            this.radioButtonTanggalTerima.CheckedChanged += new System.EventHandler(this.radioButtonTanggalTerima_CheckedChanged);
            // 
            // FormSuratDisposisi
            // 
            this.ClientSize = new System.Drawing.Size(951, 541);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelJumlahSurat);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonTambahSuratDisposisi);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonEditSuratDisposisi);
            this.Controls.Add(this.buttonHapusSuratDisposisi);
            this.Controls.Add(this.groupBoxCariSuratMasuk);
            this.Controls.Add(this.dataGridViewSuratDisposisi);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSuratDisposisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Disposisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuratDisposisi_FormClosed);
            this.Load += new System.EventHandler(this.FormSuratDisposisi_Load);
            this.groupBoxCariSuratMasuk.ResumeLayout(false);
            this.groupBoxCariSuratMasuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputTanggalSurat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuratDisposisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonKembali;
        private DevComponents.DotNetBar.ButtonX buttonEditSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonHapusSuratDisposisi;
        private System.Windows.Forms.GroupBox groupBoxCariSuratMasuk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCari;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton radioButtonPerihalSuratMasuk;
        private System.Windows.Forms.RadioButton radioButtonAsalSurat;
        private System.Windows.Forms.RadioButton radioButtonNomorSurat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSuratDisposisi;
        private DevComponents.DotNetBar.ButtonX buttonTambahSuratDisposisi;
        private System.Windows.Forms.RadioButton radioButtonNomorAgenda;
        private System.Windows.Forms.RadioButton radioButtonTanggalSurat;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputTanggalSurat;
        private DevComponents.DotNetBar.ButtonX buttonDetail;
        private DevComponents.DotNetBar.ButtonX buttonExcel;
        private DevComponents.DotNetBar.LabelX labelJumlahSurat;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.RadioButton radioButtonTanggalTerima;
    }
}