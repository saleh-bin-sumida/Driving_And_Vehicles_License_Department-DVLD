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
            this.gbxPersonFilter = new System.Windows.Forms.GroupBox();
            this.txtLicenseId = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlApplicationInfo1 = new DVLD.MyControls.ctrlApplicationInfo();
            this.ctrlDriverLicenseCard1 = new DVLD.MyControls.ctrlDriverLicenseCard();
            this.gbxPersonFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPersonFilter
            // 
            this.gbxPersonFilter.Controls.Add(this.txtLicenseId);
            this.gbxPersonFilter.Controls.Add(this.btnSelect);
            this.gbxPersonFilter.Controls.Add(this.label2);
            this.gbxPersonFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxPersonFilter.Location = new System.Drawing.Point(0, 0);
            this.gbxPersonFilter.Name = "gbxPersonFilter";
            this.gbxPersonFilter.Size = new System.Drawing.Size(1101, 95);
            this.gbxPersonFilter.TabIndex = 11;
            this.gbxPersonFilter.TabStop = false;
            this.gbxPersonFilter.Text = "Filter";
            // 
            // txtLicenseId
            // 
            this.txtLicenseId.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.txtLicenseId.Location = new System.Drawing.Point(164, 40);
            this.txtLicenseId.Name = "txtLicenseId";
            this.txtLicenseId.Size = new System.Drawing.Size(340, 32);
            this.txtLicenseId.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.btnSelect.Location = new System.Drawing.Point(531, 40);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(67, 32);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "License ID : ";
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(0, 501);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(1101, 235);
            this.ctrlApplicationInfo1.TabIndex = 12;
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlDriverLicenseCard1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(0, 96);
            this.ctrlDriverLicenseCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1101, 405);
            this.ctrlDriverLicenseCard1.TabIndex = 13;
            // 
            // ctrlDriverLicenseCardwithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.gbxPersonFilter);
            this.Name = "ctrlDriverLicenseCardwithFilter";
            this.Size = new System.Drawing.Size(1101, 736);
            this.gbxPersonFilter.ResumeLayout(false);
            this.gbxPersonFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPersonFilter;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicenseId;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
    }
}
