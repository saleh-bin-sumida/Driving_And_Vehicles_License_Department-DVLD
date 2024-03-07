namespace DVLD.Manage_Screens
{
    partial class frmManageILApplications
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
            this.components = new System.ComponentModel.Container();
            this.cbxExpressions = new System.Windows.Forms.ComboBox();
            this.cmsManageILApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageILApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "Int License ID",
            "Application ID",
            "Driver ID",
            "License ID",
            "Is Active"});
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add IL app";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(337, 27);
            this.lblHeading.Size = new System.Drawing.Size(537, 43);
            this.lblHeading.Text = "International License Applications";
            // 
            // cbxExpressions
            // 
            this.cbxExpressions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExpressions.FormattingEnabled = true;
            this.cbxExpressions.Location = new System.Drawing.Point(400, 182);
            this.cbxExpressions.Name = "cbxExpressions";
            this.cbxExpressions.Size = new System.Drawing.Size(226, 31);
            this.cbxExpressions.TabIndex = 24;
            this.cbxExpressions.SelectedIndexChanged += new System.EventHandler(this.cbxExpressions_SelectedIndexChanged);
            // 
            // cmsManageILApplications
            // 
            this.cmsManageILApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageILApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetails,
            this.tsmShowLicenseDetails,
            this.tsmShowPersonLicenseHistory});
            this.cmsManageILApplications.Name = "cmsManageTestTypes";
            this.cmsManageILApplications.Size = new System.Drawing.Size(265, 76);
            // 
            // tsmShowPersonDetails
            // 
            this.tsmShowPersonDetails.Name = "tsmShowPersonDetails";
            this.tsmShowPersonDetails.Size = new System.Drawing.Size(264, 24);
            this.tsmShowPersonDetails.Text = "Show Person Details";
            // 
            // tsmShowLicenseDetails
            // 
            this.tsmShowLicenseDetails.Name = "tsmShowLicenseDetails";
            this.tsmShowLicenseDetails.Size = new System.Drawing.Size(264, 24);
            this.tsmShowLicenseDetails.Text = "Show License Details";
            this.tsmShowLicenseDetails.Click += new System.EventHandler(this.tsmShowLicenseDetails_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(264, 24);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // frmManageILApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.cbxExpressions);
            this.Name = "frmManageILApplications";
            this.Text = "frmManageILApplications";
            this.Load += new System.EventHandler(this.frmManageILApplications_Load);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotalMembers, 0);
            this.Controls.SetChildIndex(this.lblFilterBy, 0);
            this.Controls.SetChildIndex(this.txtFilterExpressions, 0);
            this.Controls.SetChildIndex(this.cbxFilter, 0);
            this.Controls.SetChildIndex(this.cbxExpressions, 0);
            this.cmsManageILApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxExpressions;
        private System.Windows.Forms.ContextMenuStrip cmsManageILApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}