namespace DVLD
{
    partial class ctrlLoginInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._IsActive = new System.Windows.Forms.Label();
            this._UserID = new System.Windows.Forms.Label();
            this._Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._IsActive);
            this.groupBox1.Controls.Add(this._UserID);
            this.groupBox1.Controls.Add(this._Username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 7.2F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // _IsActive
            // 
            this._IsActive.AutoSize = true;
            this._IsActive.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this._IsActive.Location = new System.Drawing.Point(641, 44);
            this._IsActive.Name = "_IsActive";
            this._IsActive.Size = new System.Drawing.Size(37, 22);
            this._IsActive.TabIndex = 5;
            this._IsActive.Text = "???";
            // 
            // _UserID
            // 
            this._UserID.AutoSize = true;
            this._UserID.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this._UserID.Location = new System.Drawing.Point(94, 44);
            this._UserID.Name = "_UserID";
            this._UserID.Size = new System.Drawing.Size(37, 22);
            this._UserID.TabIndex = 4;
            this._UserID.Text = "???";
            // 
            // _Username
            // 
            this._Username.AutoSize = true;
            this._Username.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this._Username.Location = new System.Drawing.Point(365, 44);
            this._Username.Name = "_Username";
            this._Username.Size = new System.Drawing.Size(37, 22);
            this._Username.TabIndex = 3;
            this._Username.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Active : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(18, 44);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(80, 22);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "UserID : ";
            // 
            // ctrlLoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlLoginInfo";
            this.Size = new System.Drawing.Size(919, 100);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label _IsActive;
        private System.Windows.Forms.Label _UserID;
        private System.Windows.Forms.Label _Username;
    }
}
