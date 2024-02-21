namespace DVLD
{
    partial class frmManageApplicationTypes
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
            this.cmsManageApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUpdateApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(426, 37);
            this.lblHeading.Size = new System.Drawing.Size(287, 43);
            this.lblHeading.Text = "Application Types";
            // 
            // cmsManageApplicationTypes
            // 
            this.cmsManageApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdateApplicationType});
            this.cmsManageApplicationTypes.Name = "cmsManageApplicationTypes";
            this.cmsManageApplicationTypes.Size = new System.Drawing.Size(244, 56);
            // 
            // tsmUpdateApplicationType
            // 
            this.tsmUpdateApplicationType.Name = "tsmUpdateApplicationType";
            this.tsmUpdateApplicationType.Size = new System.Drawing.Size(243, 24);
            this.tsmUpdateApplicationType.Text = "Update Application Type";
            this.tsmUpdateApplicationType.Click += new System.EventHandler(this.tsmUpdateApplicationType_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Name = "frmManageApplicationTypes";
            this.Text = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotalMembers, 0);
            this.Controls.SetChildIndex(this.lblFilterBy, 0);
            this.Controls.SetChildIndex(this.txtFilterExpressions, 0);
            this.Controls.SetChildIndex(this.cbxFilter, 0);
            this.cmsManageApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateApplicationType;
    }
}