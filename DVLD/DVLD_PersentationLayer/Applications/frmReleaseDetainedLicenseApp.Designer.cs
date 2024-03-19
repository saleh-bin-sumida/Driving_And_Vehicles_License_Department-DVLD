namespace DVLD.Licenes_Applications
{
    partial class frmReleaseDetainedLicenseApp
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
            this.gbxApplicatinInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblReleasAppID = new System.Windows.Forms.Label();
            this.lblLicnseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblApplicationFee = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxApplicatinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Size = new System.Drawing.Size(488, 36);
            this.label3.Text = "Release Detained Licens Application";
            // 
            // linklabel_licsneHistroy
            // 
            this.linklabel_licsneHistroy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_licsneHistroy_LinkClicked);
            // 
            // linklabel_NewLicense
            // 
            this.linklabel_NewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_NewLicense_LinkClicked);
            // 
            // btn
            // 
            this.btn.Text = "Release";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ctrlDriverLicenseCardwithFilter1
            // 
            this.ctrlDriverLicenseCardwithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseCardwithFilter1_OnLicenseSelected);
            // 
            // gbxApplicatinInfo
            // 
            this.gbxApplicatinInfo.Controls.Add(this.label1);
            this.gbxApplicatinInfo.Controls.Add(this.label2);
            this.gbxApplicatinInfo.Controls.Add(this.lblFineFees);
            this.gbxApplicatinInfo.Controls.Add(this.lblReleasAppID);
            this.gbxApplicatinInfo.Controls.Add(this.lblLicnseID);
            this.gbxApplicatinInfo.Controls.Add(this.lblCreatedBy);
            this.gbxApplicatinInfo.Controls.Add(this.label9);
            this.gbxApplicatinInfo.Controls.Add(this.label10);
            this.gbxApplicatinInfo.Controls.Add(this.label14);
            this.gbxApplicatinInfo.Controls.Add(this.label13);
            this.gbxApplicatinInfo.Controls.Add(this.lblApplicationFee);
            this.gbxApplicatinInfo.Controls.Add(this.lblTotalFees);
            this.gbxApplicatinInfo.Controls.Add(this.lblDetainID);
            this.gbxApplicatinInfo.Controls.Add(this.lblDetainDate);
            this.gbxApplicatinInfo.Controls.Add(this.label5);
            this.gbxApplicatinInfo.Controls.Add(this.label4);
            this.gbxApplicatinInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxApplicatinInfo.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxApplicatinInfo.Location = new System.Drawing.Point(0, 538);
            this.gbxApplicatinInfo.Name = "gbxApplicatinInfo";
            this.gbxApplicatinInfo.Size = new System.Drawing.Size(1097, 261);
            this.gbxApplicatinInfo.TabIndex = 34;
            this.gbxApplicatinInfo.TabStop = false;
            this.gbxApplicatinInfo.Text = "Detain Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label1.Location = new System.Drawing.Point(621, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Release App ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label2.Location = new System.Drawing.Point(621, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Created By :";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblFineFees.Location = new System.Drawing.Point(859, 146);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(37, 22);
            this.lblFineFees.TabIndex = 27;
            this.lblFineFees.Text = "???";
            // 
            // lblReleasAppID
            // 
            this.lblReleasAppID.AutoSize = true;
            this.lblReleasAppID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblReleasAppID.Location = new System.Drawing.Point(859, 192);
            this.lblReleasAppID.Name = "lblReleasAppID";
            this.lblReleasAppID.Size = new System.Drawing.Size(37, 22);
            this.lblReleasAppID.TabIndex = 26;
            this.lblReleasAppID.Text = "???";
            // 
            // lblLicnseID
            // 
            this.lblLicnseID.AutoSize = true;
            this.lblLicnseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblLicnseID.Location = new System.Drawing.Point(859, 54);
            this.lblLicnseID.Name = "lblLicnseID";
            this.lblLicnseID.Size = new System.Drawing.Size(37, 22);
            this.lblLicnseID.TabIndex = 25;
            this.lblLicnseID.Text = "???";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblCreatedBy.Location = new System.Drawing.Point(859, 100);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(37, 22);
            this.lblCreatedBy.TabIndex = 24;
            this.lblCreatedBy.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label9.Location = new System.Drawing.Point(621, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fine Fees :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label10.Location = new System.Drawing.Point(621, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "License ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label14.Location = new System.Drawing.Point(29, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total Fees :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label13.Location = new System.Drawing.Point(29, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Detain Date :";
            // 
            // lblApplicationFee
            // 
            this.lblApplicationFee.AutoSize = true;
            this.lblApplicationFee.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblApplicationFee.Location = new System.Drawing.Point(250, 148);
            this.lblApplicationFee.Name = "lblApplicationFee";
            this.lblApplicationFee.Size = new System.Drawing.Size(37, 22);
            this.lblApplicationFee.TabIndex = 19;
            this.lblApplicationFee.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblTotalFees.Location = new System.Drawing.Point(250, 195);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(37, 22);
            this.lblTotalFees.TabIndex = 18;
            this.lblTotalFees.Text = "???";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblDetainID.Location = new System.Drawing.Point(251, 54);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(37, 22);
            this.lblDetainID.TabIndex = 17;
            this.lblDetainID.Text = "???";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblDetainDate.Location = new System.Drawing.Point(250, 101);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(37, 22);
            this.lblDetainDate.TabIndex = 16;
            this.lblDetainDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label5.Location = new System.Drawing.Point(29, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Application Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label4.Location = new System.Drawing.Point(29, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detain ID";
            // 
            // frmReleaseDetainedLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 853);
            this.Controls.Add(this.gbxApplicatinInfo);
            this.Name = "frmReleaseDetainedLicenseApp";
            this.Text = "frmReleaseDetainedLicenseApp";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicenseApp_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ctrlDriverLicenseCardwithFilter1, 0);
            this.Controls.SetChildIndex(this.gbxApplicatinInfo, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxApplicatinInfo.ResumeLayout(false);
            this.gbxApplicatinInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxApplicatinInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblReleasAppID;
        private System.Windows.Forms.Label lblLicnseID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblApplicationFee;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}