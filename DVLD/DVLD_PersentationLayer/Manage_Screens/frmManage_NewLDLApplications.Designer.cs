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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmMakeCall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageLDLApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "LDL app ID",
            "National No."});
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
            this.tsmCancel,
            this.toolStripSeparator2,
            this.tsmMakeCall,
            this.tsmSendEmail});
            this.cmsManageLDLApplications.Name = "cmsManagePeople";
            this.cmsManageLDLApplications.Size = new System.Drawing.Size(211, 188);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(210, 24);
            this.tsmShowDetails.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(210, 24);
            this.tsmEdit.Text = "Edit";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmMakeCall
            // 
            this.tsmMakeCall.Name = "tsmMakeCall";
            this.tsmMakeCall.Size = new System.Drawing.Size(210, 24);
            this.tsmMakeCall.Text = "Make Call";
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(210, 24);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmCancel
            // 
            this.tsmCancel.Name = "tsmCancel";
            this.tsmCancel.Size = new System.Drawing.Size(210, 24);
            this.tsmCancel.Text = "Cancel";
            this.tsmCancel.Click += new System.EventHandler(this.tsmCancel_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmMakeCall;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
    }
}