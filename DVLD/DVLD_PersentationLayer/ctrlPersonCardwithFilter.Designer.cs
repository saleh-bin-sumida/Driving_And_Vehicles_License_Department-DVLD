namespace DVLD
{
    partial class ctrlPersonCardwithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxUsersFilter = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilterExpressions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.gbxUsersFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUsersFilter
            // 
            this.gbxUsersFilter.Controls.Add(this.btnSelect);
            this.gbxUsersFilter.Controls.Add(this.button2);
            this.gbxUsersFilter.Controls.Add(this.txtFilterExpressions);
            this.gbxUsersFilter.Controls.Add(this.label2);
            this.gbxUsersFilter.Controls.Add(this.cbxFilter);
            this.gbxUsersFilter.Location = new System.Drawing.Point(3, 3);
            this.gbxUsersFilter.Name = "gbxUsersFilter";
            this.gbxUsersFilter.Size = new System.Drawing.Size(985, 74);
            this.gbxUsersFilter.TabIndex = 10;
            this.gbxUsersFilter.TabStop = false;
            this.gbxUsersFilter.Text = "Filter";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.btnSelect.Location = new System.Drawing.Point(730, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(67, 29);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.button2.Location = new System.Drawing.Point(803, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddnewPerson_Click);
            // 
            // txtFilterExpressions
            // 
            this.txtFilterExpressions.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.txtFilterExpressions.Location = new System.Drawing.Point(408, 26);
            this.txtFilterExpressions.Name = "txtFilterExpressions";
            this.txtFilterExpressions.Size = new System.Drawing.Size(277, 35);
            this.txtFilterExpressions.TabIndex = 11;
            this.txtFilterExpressions.TextChanged += new System.EventHandler(this.txtFilterExpressions_TextChanged);
            this.txtFilterExpressions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterExpressions_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter by : ";
            // 
            // cbxFilter
            // 
            this.cbxFilter.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(165, 28);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(237, 30);
            this.cbxFilter.TabIndex = 9;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 105);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(988, 330);
            this.ctrlPersonCard1.TabIndex = 11;
            // 
            // ctrlPersonCardwithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbxUsersFilter);
            this.Name = "ctrlPersonCardwithFilter";
            this.Size = new System.Drawing.Size(993, 446);
            this.Load += new System.EventHandler(this.ctrlPersonCardwithFilter_Load);
            this.gbxUsersFilter.ResumeLayout(false);
            this.gbxUsersFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsersFilter;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFilterExpressions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilter;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
