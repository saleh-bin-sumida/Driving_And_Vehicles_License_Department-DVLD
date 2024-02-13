namespace DVLD
{
    partial class frmManageApplicationsAndTests
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CMSeditApplicationsTests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageApplicationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CMSeditApplicationsTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(419, 62);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(60, 36);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.label2.Location = new System.Drawing.Point(27, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Records : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(22, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 326);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(948, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 8.2F);
            this.lblTotal.Location = new System.Drawing.Point(103, 657);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "??";
            // 
            // CMSeditApplicationsTests
            // 
            this.CMSeditApplicationsTests.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSeditApplicationsTests.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSeditApplicationsTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationInfoToolStripMenuItem,
            this.managToolStripMenuItem});
            this.CMSeditApplicationsTests.Name = "CMSeditApplicationsTests";
            this.CMSeditApplicationsTests.Size = new System.Drawing.Size(266, 56);
            // 
            // manageApplicationInfoToolStripMenuItem
            // 
            this.manageApplicationInfoToolStripMenuItem.Name = "manageApplicationInfoToolStripMenuItem";
            this.manageApplicationInfoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.manageApplicationInfoToolStripMenuItem.Text = "Update Application Info";
            this.manageApplicationInfoToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationInfoToolStripMenuItem_Click);
            // 
            // managToolStripMenuItem
            // 
            this.managToolStripMenuItem.Name = "managToolStripMenuItem";
            this.managToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.managToolStripMenuItem.Text = "Update Test Info";
            this.managToolStripMenuItem.Click += new System.EventHandler(this.managToolStripMenuItem_Click);
            // 
            // frmManageApplicationsAndTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 691);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmManageApplicationsAndTests";
            this.Text = "frmManageApplicationsAndTests";
            this.Load += new System.EventHandler(this.frmManageApplicationsAndTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CMSeditApplicationsTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ContextMenuStrip CMSeditApplicationsTests;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managToolStripMenuItem;
    }
}