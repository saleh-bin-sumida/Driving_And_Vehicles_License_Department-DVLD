namespace DVLD
{
    partial class frmManage_NewLDLApplications
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
            this.cmsManageLDLApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageLDLApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "LDL app ID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add LDL app";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(258, 27);
            this.lblHeading.Size = new System.Drawing.Size(673, 43);
            this.lblHeading.Text = "Manage Local Driving License Applications";
            // 
            // cmsManageLDLApplications
            // 
            this.cmsManageLDLApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageLDLApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripSeparator1,
            this.tsmEdit,
            this.tsmDelete,
            this.toolStripSeparator3,
            this.tsmCancel,
            this.toolStripSeparator2,
            this.tsmSechduleTests,
            this.toolStripSeparator4,
            this.tsmIssueDrivingLicense,
            this.toolStripSeparator5,
            this.tsmShowLicense,
            this.toolStripSeparator6,
            this.tsmShowPersonLicenseHistory});
            this.cmsManageLDLApplications.Name = "cmsManagePeople";
            this.cmsManageLDLApplications.Size = new System.Drawing.Size(293, 232);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(292, 24);
            this.tsmShowDetails.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(292, 24);
            this.tsmEdit.Text = "Edit Application";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(292, 24);
            this.tsmDelete.Text = "Delete Application";
            // 
            // tsmCancel
            // 
            this.tsmCancel.Name = "tsmCancel";
            this.tsmCancel.Size = new System.Drawing.Size(292, 24);
            this.tsmCancel.Text = "Cancel Application";
            this.tsmCancel.Click += new System.EventHandler(this.tsmCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmSechduleTests
            // 
            this.tsmSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleWrittenTest,
            this.tsmScheduleStreetTest});
            this.tsmSechduleTests.Name = "tsmSechduleTests";
            this.tsmSechduleTests.Size = new System.Drawing.Size(292, 24);
            this.tsmSechduleTests.Text = "Sechdule Tests";
            // 
            // tsmIssueDrivingLicense
            // 
            this.tsmIssueDrivingLicense.Name = "tsmIssueDrivingLicense";
            this.tsmIssueDrivingLicense.Size = new System.Drawing.Size(292, 24);
            this.tsmIssueDrivingLicense.Text = "Issue Driving License (First Time)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(289, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(289, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(292, 24);
            this.tsmShowLicense.Text = "Show License";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(292, 24);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // tsmScheduleVisionTest
            // 
            this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
            this.tsmScheduleVisionTest.Size = new System.Drawing.Size(235, 26);
            this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
            // 
            // tsmScheduleWrittenTest
            // 
            this.tsmScheduleWrittenTest.Name = "tsmScheduleWrittenTest";
            this.tsmScheduleWrittenTest.Size = new System.Drawing.Size(235, 26);
            this.tsmScheduleWrittenTest.Text = "Schedule Written Test";
            // 
            // tsmScheduleStreetTest
            // 
            this.tsmScheduleStreetTest.Name = "tsmScheduleStreetTest";
            this.tsmScheduleStreetTest.Size = new System.Drawing.Size(235, 26);
            this.tsmScheduleStreetTest.Text = "Schedule Street Test";
            // 
            // frmManage_NewLDLApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Name = "frmManage_NewLDLApplications";
            this.Text = "frmManage_LDL_Applications";
            this.Load += new System.EventHandler(this.frmManage_NewLDLApplications_Load);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotalMembers, 0);
            this.Controls.SetChildIndex(this.lblFilterBy, 0);
            this.Controls.SetChildIndex(this.txtFilterExpressions, 0);
            this.Controls.SetChildIndex(this.cbxFilter, 0);
            this.cmsManageLDLApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsManageLDLApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSechduleTests;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleStreetTest;
    }
}