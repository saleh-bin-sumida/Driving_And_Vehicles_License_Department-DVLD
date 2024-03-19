using System.Threading;

namespace DVLD
{
    partial class frmManagePeople
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
            this.cmsManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmMakeCall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManagePeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThridName",
            "LastName",
            "Gender",
            "CountryName",
            "Address"});
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // txtFilterExpressions
            // 
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add Person";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(446, 30);
            this.lblHeading.Size = new System.Drawing.Size(253, 43);
            this.lblHeading.Text = "Manage People";
            // 
            // cbxExpressions
            // 
            this.cbxExpressions.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.cbxExpressions.FormattingEnabled = true;
            this.cbxExpressions.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbxExpressions.Location = new System.Drawing.Point(400, 182);
            this.cbxExpressions.Name = "cbxExpressions";
            this.cbxExpressions.Size = new System.Drawing.Size(249, 30);
            this.cbxExpressions.TabIndex = 24;
            this.cbxExpressions.Visible = false;
            this.cbxExpressions.SelectedIndexChanged += new System.EventHandler(this.cbxExpressions_SelectedIndexChanged);
            // 
            // cmsManagePeople
            // 
            this.cmsManagePeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripSeparator1,
            this.tsmAdd,
            this.tsmEdit,
            this.tsmDelete,
            this.toolStripSeparator2,
            this.tsmMakeCall,
            this.tsmSendEmail});
            this.cmsManagePeople.Name = "cmsManagePeople";
            this.cmsManagePeople.Size = new System.Drawing.Size(165, 160);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(210, 24);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(210, 24);
            this.tsmAdd.Text = "Add Person";
            this.tsmAdd.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(210, 24);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmMakeCall
            // 
            this.tsmMakeCall.Name = "tsmMakeCall";
            this.tsmMakeCall.Size = new System.Drawing.Size(210, 24);
            this.tsmMakeCall.Text = "Make Call";
            this.tsmMakeCall.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(164, 24);
            this.tsmSendEmail.Text = "Send Email";
            this.tsmSendEmail.Click += new System.EventHandler(this.toolStripMeune_Clicked);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.cbxExpressions);
            this.Name = "frmManagePeople";
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load_2);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotalMembers, 0);
            this.Controls.SetChildIndex(this.lblFilterBy, 0);
            this.Controls.SetChildIndex(this.txtFilterExpressions, 0);
            this.Controls.SetChildIndex(this.cbxFilter, 0);
            this.Controls.SetChildIndex(this.cbxExpressions, 0);
            this.cmsManagePeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxExpressions;
        private System.Windows.Forms.ContextMenuStrip cmsManagePeople;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmMakeCall;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
    }
}