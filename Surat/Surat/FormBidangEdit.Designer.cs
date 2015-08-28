namespace Surat
{
    partial class FormBidangEdit
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
            this.buttonEditBidangKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditBidang = new DevComponents.DotNetBar.ButtonX();
            this.labelBidangEdit = new DevComponents.DotNetBar.LabelX();
            this.textBoxEditBidang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonEditBidangKembali
            // 
            this.buttonEditBidangKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditBidangKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditBidangKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBidangKembali.Location = new System.Drawing.Point(157, 83);
            this.buttonEditBidangKembali.Name = "buttonEditBidangKembali";
            this.buttonEditBidangKembali.Size = new System.Drawing.Size(122, 43);
            this.buttonEditBidangKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditBidangKembali.TabIndex = 7;
            this.buttonEditBidangKembali.Text = "Kembali";
            this.buttonEditBidangKembali.Click += new System.EventHandler(this.buttonEditBidangKembali_Click_1);
            // 
            // buttonEditBidang
            // 
            this.buttonEditBidang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditBidang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBidang.Location = new System.Drawing.Point(5, 83);
            this.buttonEditBidang.Name = "buttonEditBidang";
            this.buttonEditBidang.Size = new System.Drawing.Size(122, 43);
            this.buttonEditBidang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditBidang.TabIndex = 6;
            this.buttonEditBidang.Text = "Edit Data";
            this.buttonEditBidang.Click += new System.EventHandler(this.buttonEditBidang_Click);
            // 
            // labelBidangEdit
            // 
            // 
            // 
            // 
            this.labelBidangEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBidangEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidangEdit.Location = new System.Drawing.Point(5, 12);
            this.labelBidangEdit.Name = "labelBidangEdit";
            this.labelBidangEdit.Size = new System.Drawing.Size(103, 23);
            this.labelBidangEdit.TabIndex = 5;
            this.labelBidangEdit.Text = "Edit Bidang";
            // 
            // textBoxEditBidang
            // 
            // 
            // 
            // 
            this.textBoxEditBidang.Border.Class = "TextBoxBorder";
            this.textBoxEditBidang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEditBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditBidang.Location = new System.Drawing.Point(4, 41);
            this.textBoxEditBidang.MaxLength = 50;
            this.textBoxEditBidang.Name = "textBoxEditBidang";
            this.textBoxEditBidang.Size = new System.Drawing.Size(275, 26);
            this.textBoxEditBidang.TabIndex = 4;
            // 
            // FormBidangEdit
            // 
            this.ClientSize = new System.Drawing.Size(293, 142);
            this.Controls.Add(this.buttonEditBidangKembali);
            this.Controls.Add(this.buttonEditBidang);
            this.Controls.Add(this.labelBidangEdit);
            this.Controls.Add(this.textBoxEditBidang);
            this.DoubleBuffered = true;
            this.Name = "FormBidangEdit";
            this.Text = "FormBidangEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonEditBidangKembali;
        private DevComponents.DotNetBar.ButtonX buttonEditBidang;
        private DevComponents.DotNetBar.LabelX labelBidangEdit;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxEditBidang;
    }
}