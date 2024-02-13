namespace DVLD
{
    partial class frmManage_LDL_Applications
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
            this.SuspendLayout();
            // 
            // cbxExpressions
            // 
            // cbxFilter
            // 
            this.cbxFilter.Location = new System.Drawing.Point(136, 231);
            // 
            // txtFilterExpressions
            // 
            this.txtFilterExpressions.Location = new System.Drawing.Point(391, 231);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 232);
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Location = new System.Drawing.Point(136, 621);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 619);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1060, 609);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1026, 225);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmManage_LDL_Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Name = "frmManage_LDL_Applications";
            this.Text = "frmManage_LDL_Applications";
            this.Load += new System.EventHandler(this.frmManage_LDL_Applications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}