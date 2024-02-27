namespace DVLD.Manage_Screens
{
    partial class frmManageTestAppointments
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.ctrlBasicApplicationInfo1 = new DVLD.MyControls.ctrlBasicApplicationInfo();
            this.ctrl_LDLapplicationInfo1 = new DVLD.ctrl_LDLapplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.GridColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView.Location = new System.Drawing.Point(22, 522);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 26;
            this.DataGridView.Size = new System.Drawing.Size(1022, 213);
            this.DataGridView.TabIndex = 32;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(116, 753);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(0, 17);
            this.lblTotalMembers.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "#Records : ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.btnClose.Location = new System.Drawing.Point(947, 743);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 31);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(906, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 31);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add Appointment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(265, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(70, 43);
            this.lblHeading.TabIndex = 28;
            this.lblHeading.Text = "???";
            // 
            // ctrlBasicApplicationInfo1
            // 
            this.ctrlBasicApplicationInfo1.Location = new System.Drawing.Point(12, 223);
            this.ctrlBasicApplicationInfo1.Name = "ctrlBasicApplicationInfo1";
            this.ctrlBasicApplicationInfo1.Size = new System.Drawing.Size(1032, 256);
            this.ctrlBasicApplicationInfo1.TabIndex = 34;
            // 
            // ctrl_LDLapplicationInfo1
            // 
            this.ctrl_LDLapplicationInfo1.Location = new System.Drawing.Point(12, 67);
            this.ctrl_LDLapplicationInfo1.Name = "ctrl_LDLapplicationInfo1";
            this.ctrl_LDLapplicationInfo1.Size = new System.Drawing.Size(1032, 150);
            this.ctrl_LDLapplicationInfo1.TabIndex = 33;
            // 
            // frmManageTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 781);
            this.Controls.Add(this.ctrlBasicApplicationInfo1);
            this.Controls.Add(this.ctrl_LDLapplicationInfo1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmManageTestAppointments";
            this.Text = "frmManageTestAppointments";
            this.Load += new System.EventHandler(this.frmManageTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView DataGridView;
        protected System.Windows.Forms.Label lblTotalMembers;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Label lblHeading;
        private ctrl_LDLapplicationInfo ctrl_LDLapplicationInfo1;
        private MyControls.ctrlBasicApplicationInfo ctrlBasicApplicationInfo1;
    }
}