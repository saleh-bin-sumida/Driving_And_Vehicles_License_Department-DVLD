namespace DVLD.ShowInfo_Screens
{
    partial class frmShowDriverIntLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlDriverInternationalLicenseCard1 = new DVLD.MyControls.ctrlDriverInternationalLicenseCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show Driver Inernational License Info";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 8F);
            this.button1.Location = new System.Drawing.Point(949, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlDriverInternationalLicenseCard1
            // 
            this.ctrlDriverInternationalLicenseCard1.Location = new System.Drawing.Point(6, 73);
            this.ctrlDriverInternationalLicenseCard1.Name = "ctrlDriverInternationalLicenseCard1";
            this.ctrlDriverInternationalLicenseCard1.Size = new System.Drawing.Size(1072, 330);
            this.ctrlDriverInternationalLicenseCard1.TabIndex = 5;
            // 
            // frmShowDriverIntLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 444);
            this.Controls.Add(this.ctrlDriverInternationalLicenseCard1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowDriverIntLicense";
            this.Text = "frmShowDriverIntLicense";
            this.Load += new System.EventHandler(this.frmShowDriverIntLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private MyControls.ctrlDriverInternationalLicenseCard ctrlDriverInternationalLicenseCard1;
    }
}