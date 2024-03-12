namespace DVLD
{
    partial class frmRenewLicenseApp
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
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreatedbyUser = new System.Windows.Forms.Label();
            this.lblRenewdLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblapplicationFees = new System.Windows.Forms.Label();
            this.lbl_RenewApplicationID = new System.Windows.Forms.Label();
            this.lblapplicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxApplicatinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(351, 9);
            this.label3.Size = new System.Drawing.Size(363, 36);
            this.label3.Text = "Renew License Application";
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
            this.btn.Text = "Renew";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ctrlDriverLicenseCardwithFilter1
            // 
            this.ctrlDriverLicenseCardwithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseCardwithFilter1_OnLicenseSelected);
            // 
            // gbxApplicatinInfo
            // 
            this.gbxApplicatinInfo.Controls.Add(this.txtNotes);
            this.gbxApplicatinInfo.Controls.Add(this.label12);
            this.gbxApplicatinInfo.Controls.Add(this.label8);
            this.gbxApplicatinInfo.Controls.Add(this.lblTotalFees);
            this.gbxApplicatinInfo.Controls.Add(this.label6);
            this.gbxApplicatinInfo.Controls.Add(this.lblLicenseFees);
            this.gbxApplicatinInfo.Controls.Add(this.label1);
            this.gbxApplicatinInfo.Controls.Add(this.label2);
            this.gbxApplicatinInfo.Controls.Add(this.lblExpirationDate);
            this.gbxApplicatinInfo.Controls.Add(this.lblCreatedbyUser);
            this.gbxApplicatinInfo.Controls.Add(this.lblRenewdLicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.lblOldLicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.label9);
            this.gbxApplicatinInfo.Controls.Add(this.label10);
            this.gbxApplicatinInfo.Controls.Add(this.label14);
            this.gbxApplicatinInfo.Controls.Add(this.label13);
            this.gbxApplicatinInfo.Controls.Add(this.lblIssueDate);
            this.gbxApplicatinInfo.Controls.Add(this.lblapplicationFees);
            this.gbxApplicatinInfo.Controls.Add(this.lbl_RenewApplicationID);
            this.gbxApplicatinInfo.Controls.Add(this.lblapplicationDate);
            this.gbxApplicatinInfo.Controls.Add(this.label5);
            this.gbxApplicatinInfo.Controls.Add(this.label4);
            this.gbxApplicatinInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxApplicatinInfo.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxApplicatinInfo.Location = new System.Drawing.Point(0, 538);
            this.gbxApplicatinInfo.Name = "gbxApplicatinInfo";
            this.gbxApplicatinInfo.Size = new System.Drawing.Size(1097, 261);
            this.gbxApplicatinInfo.TabIndex = 33;
            this.gbxApplicatinInfo.TabStop = false;
            this.gbxApplicatinInfo.Text = "Application New License Info";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Location = new System.Drawing.Point(255, 204);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(405, 52);
            this.txtNotes.TabIndex = 37;
            this.txtNotes.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label12.Location = new System.Drawing.Point(30, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Notes : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label8.Location = new System.Drawing.Point(621, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total Fees : ";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblTotalFees.Location = new System.Drawing.Point(859, 169);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(37, 22);
            this.lblTotalFees.TabIndex = 33;
            this.lblTotalFees.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label6.Location = new System.Drawing.Point(29, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "License Fees : ";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblLicenseFees.Location = new System.Drawing.Point(250, 169);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(37, 22);
            this.lblLicenseFees.TabIndex = 31;
            this.lblLicenseFees.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label1.Location = new System.Drawing.Point(621, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Created By : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label2.Location = new System.Drawing.Point(621, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Old License ID : ";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblExpirationDate.Location = new System.Drawing.Point(859, 99);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(37, 22);
            this.lblExpirationDate.TabIndex = 27;
            this.lblExpirationDate.Text = "???";
            // 
            // lblCreatedbyUser
            // 
            this.lblCreatedbyUser.AutoSize = true;
            this.lblCreatedbyUser.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblCreatedbyUser.Location = new System.Drawing.Point(859, 134);
            this.lblCreatedbyUser.Name = "lblCreatedbyUser";
            this.lblCreatedbyUser.Size = new System.Drawing.Size(37, 22);
            this.lblCreatedbyUser.TabIndex = 26;
            this.lblCreatedbyUser.Text = "???";
            // 
            // lblRenewdLicenseID
            // 
            this.lblRenewdLicenseID.AutoSize = true;
            this.lblRenewdLicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblRenewdLicenseID.Location = new System.Drawing.Point(859, 29);
            this.lblRenewdLicenseID.Name = "lblRenewdLicenseID";
            this.lblRenewdLicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblRenewdLicenseID.TabIndex = 25;
            this.lblRenewdLicenseID.Text = "???";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblOldLicenseID.Location = new System.Drawing.Point(859, 64);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblOldLicenseID.TabIndex = 24;
            this.lblOldLicenseID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label9.Location = new System.Drawing.Point(621, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Expiration Date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label10.Location = new System.Drawing.Point(621, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Renewed License ID : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label14.Location = new System.Drawing.Point(29, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Application Fees : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label13.Location = new System.Drawing.Point(29, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Application Date : ";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblIssueDate.Location = new System.Drawing.Point(250, 101);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(37, 22);
            this.lblIssueDate.TabIndex = 19;
            this.lblIssueDate.Text = "???";
            // 
            // lblapplicationFees
            // 
            this.lblapplicationFees.AutoSize = true;
            this.lblapplicationFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblapplicationFees.Location = new System.Drawing.Point(250, 137);
            this.lblapplicationFees.Name = "lblapplicationFees";
            this.lblapplicationFees.Size = new System.Drawing.Size(37, 22);
            this.lblapplicationFees.TabIndex = 18;
            this.lblapplicationFees.Text = "???";
            // 
            // lbl_RenewApplicationID
            // 
            this.lbl_RenewApplicationID.AutoSize = true;
            this.lbl_RenewApplicationID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lbl_RenewApplicationID.Location = new System.Drawing.Point(251, 29);
            this.lbl_RenewApplicationID.Name = "lbl_RenewApplicationID";
            this.lbl_RenewApplicationID.Size = new System.Drawing.Size(37, 22);
            this.lbl_RenewApplicationID.TabIndex = 17;
            this.lbl_RenewApplicationID.Text = "???";
            // 
            // lblapplicationDate
            // 
            this.lblapplicationDate.AutoSize = true;
            this.lblapplicationDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblapplicationDate.Location = new System.Drawing.Point(250, 65);
            this.lblapplicationDate.Name = "lblapplicationDate";
            this.lblapplicationDate.Size = new System.Drawing.Size(37, 22);
            this.lblapplicationDate.TabIndex = 16;
            this.lblapplicationDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label5.Location = new System.Drawing.Point(29, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Issue Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "R.L Application ID : ";
            // 
            // frmRenewLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 853);
            this.Controls.Add(this.gbxApplicatinInfo);
            this.Name = "frmRenewLicenseApp";
            this.Text = "frmRenewLicenseApp";
            this.Load += new System.EventHandler(this.frmRenewLicenseApp_Load);
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
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreatedbyUser;
        private System.Windows.Forms.Label lblRenewdLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblapplicationFees;
        private System.Windows.Forms.Label lbl_RenewApplicationID;
        private System.Windows.Forms.Label lblapplicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}