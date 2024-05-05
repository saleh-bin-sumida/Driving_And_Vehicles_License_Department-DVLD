namespace DVLD.Licenes_Applications
{
    partial class frm_ILapplication
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
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreatedbyUser = new System.Windows.Forms.Label();
            this.lblILlicenseID = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblILapplicationID = new System.Windows.Forms.Label();
            this.lblapplicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxApplicatinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklabel_licsneHistroy
            // 
            this.linklabel_licsneHistroy.Location = new System.Drawing.Point(231, 19);
            this.linklabel_licsneHistroy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_licsneHistroy_LinkClicked);
            // 
            // linklabel_NewLicense
            // 
            this.linklabel_NewLicense.Size = new System.Drawing.Size(193, 17);
            this.linklabel_NewLicense.Text = "Show Internatoinal license Info";
            this.linklabel_NewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_NewLicense_LinkClicked);
            // 
            // btn
            // 
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
            this.gbxApplicatinInfo.Controls.Add(this.lblExpirationDate);
            this.gbxApplicatinInfo.Controls.Add(this.lblCreatedbyUser);
            this.gbxApplicatinInfo.Controls.Add(this.lblILlicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.lblLicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.label9);
            this.gbxApplicatinInfo.Controls.Add(this.label10);
            this.gbxApplicatinInfo.Controls.Add(this.label14);
            this.gbxApplicatinInfo.Controls.Add(this.label13);
            this.gbxApplicatinInfo.Controls.Add(this.lblIssueDate);
            this.gbxApplicatinInfo.Controls.Add(this.lblFees);
            this.gbxApplicatinInfo.Controls.Add(this.lblILapplicationID);
            this.gbxApplicatinInfo.Controls.Add(this.lblapplicationDate);
            this.gbxApplicatinInfo.Controls.Add(this.label5);
            this.gbxApplicatinInfo.Controls.Add(this.label4);
            this.gbxApplicatinInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxApplicatinInfo.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxApplicatinInfo.Location = new System.Drawing.Point(0, 535);
            this.gbxApplicatinInfo.Name = "gbxApplicatinInfo";
            this.gbxApplicatinInfo.Size = new System.Drawing.Size(1097, 264);
            this.gbxApplicatinInfo.TabIndex = 33;
            this.gbxApplicatinInfo.TabStop = false;
            this.gbxApplicatinInfo.Text = "Application Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label1.Location = new System.Drawing.Point(628, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Created By : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label2.Location = new System.Drawing.Point(628, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Local License ID : ";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblExpirationDate.Location = new System.Drawing.Point(843, 119);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(37, 22);
            this.lblExpirationDate.TabIndex = 27;
            this.lblExpirationDate.Text = "???";
            // 
            // lblCreatedbyUser
            // 
            this.lblCreatedbyUser.AutoSize = true;
            this.lblCreatedbyUser.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblCreatedbyUser.Location = new System.Drawing.Point(843, 155);
            this.lblCreatedbyUser.Name = "lblCreatedbyUser";
            this.lblCreatedbyUser.Size = new System.Drawing.Size(37, 22);
            this.lblCreatedbyUser.TabIndex = 26;
            this.lblCreatedbyUser.Text = "???";
            // 
            // lblILlicenseID
            // 
            this.lblILlicenseID.AutoSize = true;
            this.lblILlicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblILlicenseID.Location = new System.Drawing.Point(843, 47);
            this.lblILlicenseID.Name = "lblILlicenseID";
            this.lblILlicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblILlicenseID.TabIndex = 25;
            this.lblILlicenseID.Text = "???";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblLicenseID.Location = new System.Drawing.Point(843, 83);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblLicenseID.TabIndex = 24;
            this.lblLicenseID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label9.Location = new System.Drawing.Point(628, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Expiration Date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label10.Location = new System.Drawing.Point(628, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "I.L License ID : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label14.Location = new System.Drawing.Point(29, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Fees : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label13.Location = new System.Drawing.Point(29, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Application Date : ";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblIssueDate.Location = new System.Drawing.Point(250, 119);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(37, 22);
            this.lblIssueDate.TabIndex = 19;
            this.lblIssueDate.Text = "???";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblFees.Location = new System.Drawing.Point(250, 155);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(37, 22);
            this.lblFees.TabIndex = 18;
            this.lblFees.Text = "???";
            // 
            // lblILapplicationID
            // 
            this.lblILapplicationID.AutoSize = true;
            this.lblILapplicationID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblILapplicationID.Location = new System.Drawing.Point(250, 47);
            this.lblILapplicationID.Name = "lblILapplicationID";
            this.lblILapplicationID.Size = new System.Drawing.Size(37, 22);
            this.lblILapplicationID.TabIndex = 17;
            this.lblILapplicationID.Text = "???";
            // 
            // lblapplicationDate
            // 
            this.lblapplicationDate.AutoSize = true;
            this.lblapplicationDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblapplicationDate.Location = new System.Drawing.Point(250, 83);
            this.lblapplicationDate.Name = "lblapplicationDate";
            this.lblapplicationDate.Size = new System.Drawing.Size(37, 22);
            this.lblapplicationDate.TabIndex = 16;
            this.lblapplicationDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label5.Location = new System.Drawing.Point(29, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Issue Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label4.Location = new System.Drawing.Point(29, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "I.L Application ID : ";
            // 
            // frm_ILapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 853);
            this.Controls.Add(this.gbxApplicatinInfo);
            this.Name = "frm_ILapplication";
            this.Text = "frm_ILapplication";
            this.Load += new System.EventHandler(this.frm_ILapplication_Load);
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
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreatedbyUser;
        private System.Windows.Forms.Label lblILlicenseID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblILapplicationID;
        private System.Windows.Forms.Label lblapplicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}