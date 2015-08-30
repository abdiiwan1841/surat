namespace Surat
{
    partial class FormSuratMasukBidang
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
            this.buttonKembaliLampiranSuratMasuk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonKembaliLampiranSuratMasuk
            // 
            this.buttonKembaliLampiranSuratMasuk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonKembaliLampiranSuratMasuk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonKembaliLampiranSuratMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembaliLampiranSuratMasuk.Location = new System.Drawing.Point(295, 254);
            this.buttonKembaliLampiranSuratMasuk.Name = "buttonKembaliLampiranSuratMasuk";
            this.buttonKembaliLampiranSuratMasuk.Size = new System.Drawing.Size(75, 32);
            this.buttonKembaliLampiranSuratMasuk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonKembaliLampiranSuratMasuk.TabIndex = 21;
            this.buttonKembaliLampiranSuratMasuk.Text = "Kembali";
            // 
            // FormSuratMasukBidang
            // 
            this.ClientSize = new System.Drawing.Size(380, 299);
            this.Controls.Add(this.buttonKembaliLampiranSuratMasuk);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuratMasukBidang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribusi Bidang";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonKembaliLampiranSuratMasuk;
    }
}