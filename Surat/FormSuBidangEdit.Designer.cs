namespace Surat
{
    partial class FormSuBidangEdit
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
            this.buttonEditSubBidangKembali = new DevComponents.DotNetBar.ButtonX();
            this.buttonEditSubBidang = new DevComponents.DotNetBar.ButtonX();
            this.labelBidangEdit = new DevComponents.DotNetBar.LabelX();
            this.textBoxEditSubBidang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonEditSubBidangKembali
            // 
            this.buttonEditSubBidangKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSubBidangKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSubBidangKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSubBidangKembali.Location = new System.Drawing.Point(162, 85);
            this.buttonEditSubBidangKembali.Name = "buttonEditSubBidangKembali";
            this.buttonEditSubBidangKembali.Size = new System.Drawing.Size(122, 43);
            this.buttonEditSubBidangKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSubBidangKembali.TabIndex = 11;
            this.buttonEditSubBidangKembali.Text = "Kembali";
            this.buttonEditSubBidangKembali.Click += new System.EventHandler(this.buttonEditSubBidangKembali_Click);
            // 
            // buttonEditSubBidang
            // 
            this.buttonEditSubBidang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEditSubBidang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEditSubBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSubBidang.Location = new System.Drawing.Point(10, 85);
            this.buttonEditSubBidang.Name = "buttonEditSubBidang";
            this.buttonEditSubBidang.Size = new System.Drawing.Size(122, 43);
            this.buttonEditSubBidang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEditSubBidang.TabIndex = 10;
            this.buttonEditSubBidang.Text = "Edit Data";
            this.buttonEditSubBidang.Click += new System.EventHandler(this.buttonEditSubBidang_Click);
            // 
            // labelBidangEdit
            // 
            // 
            // 
            // 
            this.labelBidangEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBidangEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidangEdit.Location = new System.Drawing.Point(10, 14);
            this.labelBidangEdit.Name = "labelBidangEdit";
            this.labelBidangEdit.Size = new System.Drawing.Size(103, 23);
            this.labelBidangEdit.TabIndex = 9;
            this.labelBidangEdit.Text = "Edit Sub Bagian";
            // 
            // textBoxEditSubBidang
            // 
            // 
            // 
            // 
            this.textBoxEditSubBidang.Border.Class = "TextBoxBorder";
            this.textBoxEditSubBidang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEditSubBidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditSubBidang.Location = new System.Drawing.Point(9, 43);
            this.textBoxEditSubBidang.Name = "textBoxEditSubBidang";
            this.textBoxEditSubBidang.Size = new System.Drawing.Size(275, 26);
            this.textBoxEditSubBidang.TabIndex = 8;
            // 
            // FormSuBidangEdit
            // 
            this.ClientSize = new System.Drawing.Size(293, 142);
            this.Controls.Add(this.buttonEditSubBidangKembali);
            this.Controls.Add(this.buttonEditSubBidang);
            this.Controls.Add(this.labelBidangEdit);
            this.Controls.Add(this.textBoxEditSubBidang);
            this.DoubleBuffered = true;
            this.Name = "FormSuBidangEdit";
            this.Text = "FormSuBidangEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonEditSubBidangKembali;
        private DevComponents.DotNetBar.ButtonX buttonEditSubBidang;
        private DevComponents.DotNetBar.LabelX labelBidangEdit;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxEditSubBidang;
    }
}