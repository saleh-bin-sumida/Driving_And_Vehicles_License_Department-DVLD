namespace DVLD.MyControls
{
    partial class ctrlDriverLicenseCardwithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlDriverLicenseCard1 = new DVLD.MyControls.ctrlDriverLicenseCard();
            this.gbxPersonFilter = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.gbxPersonFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(0, 118);
            this.ctrlDriverLicenseCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1072, 401);
            this.ctrlDriverLicenseCard1.TabIndex = 0;
            // 
            // gbxPersonFilter
            // 
            this.gbxPersonFilter.Controls.Add(this.btnSelect);
            this.gbxPersonFilter.Controls.Add(this.label2);
            this.gbxPersonFilter.Controls.Add(this.cbxFilter);
            this.gbxPersonFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxPersonFilter.Location = new System.Drawing.Point(0, 0);
            this.gbxPersonFilter.Name = "gbxPersonFilter";
            this.gbxPersonFilter.Size = new System.Drawing.Size(1078, 112);
            this.gbxPersonFilter.TabIndex = 11;
            this.gbxPersonFilter.TabStop = false;
            this.gbxPersonFilter.Text = "Filter";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.btnSelect.Location = new System.Drawing.Point(531, 40);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(67, 31);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "License ID : ";
            // 
            // cbxFilter
            // 
            this.cbxFilter.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(171, 43);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(340, 28);
            this.cbxFilter.TabIndex = 9;
            // 
            // ctrlDriverLicenseCardwithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxPersonFilter);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Name = "ctrlDriverLicenseCardwithFilter";
            this.Size = new System.Drawing.Size(1078, 820);
            this.Load += new System.EventHandler(this.ctrlDriverLicenseCardwithFilter_Load);
            this.gbxPersonFilter.ResumeLayout(false);
            this.gbxPersonFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private System.Windows.Forms.GroupBox gbxPersonFilter;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilter;
    }
}
