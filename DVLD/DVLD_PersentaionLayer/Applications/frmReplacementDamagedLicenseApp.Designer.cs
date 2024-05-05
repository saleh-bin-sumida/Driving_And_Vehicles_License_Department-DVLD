namespace DVLD.Licenes_Applications
{
    partial class frmReplacementDamagedLicenseApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbxLostLicense = new System.Windows.Forms.RadioButton();
            this.rbxDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gbxApplicatinInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedbyUser = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblapplicationFees = new System.Windows.Forms.Label();
            this.lbl_ReplacementApplicationID = new System.Windows.Forms.Label();
            this.lblapplicationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxApplicatinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(298, 9);
            this.label3.Size = new System.Drawing.Size(444, 36);
            this.label3.Text = "License Replacement Application";
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
            this.btn.Text = "Issue";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ctrlDriverLicenseCardwithFilter1
            // 
            this.ctrlDriverLicenseCardwithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseCardwithFilter1_OnLicenseSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbxLostLicense);
            this.groupBox1.Controls.Add(this.rbxDamagedLicense);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(884, 605);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 193);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For :";
            // 
            // rbxLostLicense
            // 
            this.rbxLostLicense.AutoSize = true;
            this.rbxLostLicense.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.rbxLostLicense.Location = new System.Drawing.Point(32, 97);
            this.rbxLostLicense.Name = "rbxLostLicense";
            this.rbxLostLicense.Size = new System.Drawing.Size(140, 26);
            this.rbxLostLicense.TabIndex = 32;
            this.rbxLostLicense.TabStop = true;
            this.rbxLostLicense.Text = "Loast License";
            this.rbxLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbxDamagedLicense
            // 
            this.rbxDamagedLicense.AutoSize = true;
            this.rbxDamagedLicense.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.rbxDamagedLicense.Location = new System.Drawing.Point(32, 50);
            this.rbxDamagedLicense.Name = "rbxDamagedLicense";
            this.rbxDamagedLicense.Size = new System.Drawing.Size(170, 26);
            this.rbxDamagedLicense.TabIndex = 33;
            this.rbxDamagedLicense.TabStop = true;
            this.rbxDamagedLicense.Text = "Damaged License";
            this.rbxDamagedLicense.UseVisualStyleBackColor = true;
            // 
            // gbxApplicatinInfo
            // 
            this.gbxApplicatinInfo.Controls.Add(this.label1);
            this.gbxApplicatinInfo.Controls.Add(this.label2);
            this.gbxApplicatinInfo.Controls.Add(this.lblCreatedbyUser);
            this.gbxApplicatinInfo.Controls.Add(this.lblReplacedLicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.lblOldLicenseID);
            this.gbxApplicatinInfo.Controls.Add(this.label10);
            this.gbxApplicatinInfo.Controls.Add(this.label14);
            this.gbxApplicatinInfo.Controls.Add(this.label13);
            this.gbxApplicatinInfo.Controls.Add(this.lblapplicationFees);
            this.gbxApplicatinInfo.Controls.Add(this.lbl_ReplacementApplicationID);
            this.gbxApplicatinInfo.Controls.Add(this.lblapplicationDate);
            this.gbxApplicatinInfo.Controls.Add(this.label4);
            this.gbxApplicatinInfo.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxApplicatinInfo.Location = new System.Drawing.Point(1, 605);
            this.gbxApplicatinInfo.Name = "gbxApplicatinInfo";
            this.gbxApplicatinInfo.Size = new System.Drawing.Size(869, 193);
            this.gbxApplicatinInfo.TabIndex = 33;
            this.gbxApplicatinInfo.TabStop = false;
            this.gbxApplicatinInfo.Text = "Application Info Fro License Replacement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label1.Location = new System.Drawing.Point(508, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Created By : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label2.Location = new System.Drawing.Point(508, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Old License ID : ";
            // 
            // lblCreatedbyUser
            // 
            this.lblCreatedbyUser.AutoSize = true;
            this.lblCreatedbyUser.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblCreatedbyUser.Location = new System.Drawing.Point(695, 133);
            this.lblCreatedbyUser.Name = "lblCreatedbyUser";
            this.lblCreatedbyUser.Size = new System.Drawing.Size(37, 22);
            this.lblCreatedbyUser.TabIndex = 26;
            this.lblCreatedbyUser.Text = "???";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(695, 29);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblReplacedLicenseID.TabIndex = 25;
            this.lblReplacedLicenseID.Text = "???";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblOldLicenseID.Location = new System.Drawing.Point(695, 81);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(37, 22);
            this.lblOldLicenseID.TabIndex = 24;
            this.lblOldLicenseID.Text = "???";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label10.Location = new System.Drawing.Point(508, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Replaced License ID : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label14.Location = new System.Drawing.Point(29, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Application Fees : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label13.Location = new System.Drawing.Point(29, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Application Date : ";
            // 
            // lblapplicationFees
            // 
            this.lblapplicationFees.AutoSize = true;
            this.lblapplicationFees.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblapplicationFees.Location = new System.Drawing.Point(226, 137);
            this.lblapplicationFees.Name = "lblapplicationFees";
            this.lblapplicationFees.Size = new System.Drawing.Size(37, 22);
            this.lblapplicationFees.TabIndex = 18;
            this.lblapplicationFees.Text = "???";
            // 
            // lbl_ReplacementApplicationID
            // 
            this.lbl_ReplacementApplicationID.AutoSize = true;
            this.lbl_ReplacementApplicationID.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lbl_ReplacementApplicationID.Location = new System.Drawing.Point(227, 29);
            this.lbl_ReplacementApplicationID.Name = "lbl_ReplacementApplicationID";
            this.lbl_ReplacementApplicationID.Size = new System.Drawing.Size(37, 22);
            this.lbl_ReplacementApplicationID.TabIndex = 17;
            this.lbl_ReplacementApplicationID.Text = "???";
            // 
            // lblapplicationDate
            // 
            this.lblapplicationDate.AutoSize = true;
            this.lblapplicationDate.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.lblapplicationDate.Location = new System.Drawing.Point(226, 83);
            this.lblapplicationDate.Name = "lblapplicationDate";
            this.lblapplicationDate.Size = new System.Drawing.Size(37, 22);
            this.lblapplicationDate.TabIndex = 16;
            this.lblapplicationDate.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.8F);
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "L.R Application ID : ";
            // 
            // frmReplacementDamagedLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 853);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxApplicatinInfo);
            this.Name = "frmReplacementDamagedLicenseApp";
            this.Text = "frmReplacementDamagedLicenseApp";
            this.Load += new System.EventHandler(this.frmReplacementDamagedLicenseApp_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ctrlDriverLicenseCardwithFilter1, 0);
            this.Controls.SetChildIndex(this.gbxApplicatinInfo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxApplicatinInfo.ResumeLayout(false);
            this.gbxApplicatinInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbxLostLicense;
        private System.Windows.Forms.RadioButton rbxDamagedLicense;
        private System.Windows.Forms.GroupBox gbxApplicatinInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedbyUser;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblapplicationFees;
        private System.Windows.Forms.Label lbl_ReplacementApplicationID;
        private System.Windows.Forms.Label lblapplicationDate;
        private System.Windows.Forms.Label label4;
    }
}