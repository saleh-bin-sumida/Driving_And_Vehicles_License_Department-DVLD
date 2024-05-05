namespace DVLD.ShowInfo_Screens
{
    partial class frmShowApplicationDetails
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
            this.ctrl_LDLapplicationInfo1 = new DVLD.ctrl_LDLapplicationInfo();
            this.ctrlBasicApplicationInfo1 = new DVLD.MyControls.ctrlBasicApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Application Info";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(905, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrl_LDLapplicationInfo1
            // 
            this.ctrl_LDLapplicationInfo1.Location = new System.Drawing.Point(1, 84);
            this.ctrl_LDLapplicationInfo1.Name = "ctrl_LDLapplicationInfo1";
            this.ctrl_LDLapplicationInfo1.Size = new System.Drawing.Size(1015, 158);
            this.ctrl_LDLapplicationInfo1.TabIndex = 3;
            // 
            // ctrlBasicApplicationInfo1
            // 
            this.ctrlBasicApplicationInfo1.Location = new System.Drawing.Point(1, 248);
            this.ctrlBasicApplicationInfo1.Name = "ctrlBasicApplicationInfo1";
            this.ctrlBasicApplicationInfo1.Size = new System.Drawing.Size(1015, 273);
            this.ctrlBasicApplicationInfo1.TabIndex = 4;
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 577);
            this.Controls.Add(this.ctrlBasicApplicationInfo1);
            this.Controls.Add(this.ctrl_LDLapplicationInfo1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowApplicationDetails";
            this.Text = "frmShowApplicationDetails";
            this.Load += new System.EventHandler(this.frmShowApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ctrl_LDLapplicationInfo ctrl_LDLapplicationInfo1;
        private MyControls.ctrlBasicApplicationInfo ctrlBasicApplicationInfo1;
    }
}