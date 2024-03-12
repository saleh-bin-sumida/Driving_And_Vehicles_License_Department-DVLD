namespace DVLD.Licenes_Applications
{
    partial class frmLicenseServiceScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklabel_licsneHistroy = new System.Windows.Forms.LinkLabel();
            this.linklabel_NewLicense = new System.Windows.Forms.LinkLabel();
            this.btn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlDriverLicenseCardwithFilter1 = new DVLD.MyControls.ctrlDriverLicenseCardwithFilter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "???";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linklabel_licsneHistroy);
            this.panel1.Controls.Add(this.linklabel_NewLicense);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 799);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 54);
            this.panel1.TabIndex = 31;
            // 
            // linklabel_licsneHistroy
            // 
            this.linklabel_licsneHistroy.AutoSize = true;
            this.linklabel_licsneHistroy.Location = new System.Drawing.Point(198, 19);
            this.linklabel_licsneHistroy.Name = "linklabel_licsneHistroy";
            this.linklabel_licsneHistroy.Size = new System.Drawing.Size(137, 17);
            this.linklabel_licsneHistroy.TabIndex = 9;
            this.linklabel_licsneHistroy.TabStop = true;
            this.linklabel_licsneHistroy.Text = "Show License History";
            // 
            // linklabel_NewLicense
            // 
            this.linklabel_NewLicense.AutoSize = true;
            this.linklabel_NewLicense.Location = new System.Drawing.Point(22, 19);
            this.linklabel_NewLicense.Name = "linklabel_NewLicense";
            this.linklabel_NewLicense.Size = new System.Drawing.Size(143, 17);
            this.linklabel_NewLicense.TabIndex = 8;
            this.linklabel_NewLicense.TabStop = true;
            this.linklabel_NewLicense.Text = "Show New license Info";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(960, 8);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(110, 38);
            this.btn.TabIndex = 6;
            this.btn.Text = "???";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(844, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // ctrlDriverLicenseCardwithFilter1
            // 
            this.ctrlDriverLicenseCardwithFilter1.Location = new System.Drawing.Point(-4, 48);
            this.ctrlDriverLicenseCardwithFilter1.Name = "ctrlDriverLicenseCardwithFilter1";
            this.ctrlDriverLicenseCardwithFilter1.Size = new System.Drawing.Size(1101, 492);
            this.ctrlDriverLicenseCardwithFilter1.TabIndex = 32;
            // 
            // frmLicenseServiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 853);
            this.Controls.Add(this.ctrlDriverLicenseCardwithFilter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "frmLicenseServiceScreen";
            this.Text = "frmLicenseServiceScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      public System.Windows.Forms.Label label3;
      public System.Windows.Forms.Panel panel1;
      public System.Windows.Forms.LinkLabel linklabel_licsneHistroy;
      public System.Windows.Forms.LinkLabel linklabel_NewLicense;
      public System.Windows.Forms.Button btn;
      public System.Windows.Forms.Button btnClose;
      public MyControls.ctrlDriverLicenseCardwithFilter ctrlDriverLicenseCardwithFilter1;
    }
}