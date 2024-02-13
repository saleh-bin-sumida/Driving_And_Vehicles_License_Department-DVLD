using System;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class frmManageApplicationsAndTests : Form
    {
        enum Mode { ShowApplications =1, ShowTests = 2}
        Mode mode;

        public frmManageApplicationsAndTests(string WhatToManage)
        {
            InitializeComponent();
            if (WhatToManage == "ManageApplicationsTypes")
            {
                mode = Mode.ShowApplications;
            }
            else if (WhatToManage == "ManageTestsTypes")
            {
                mode = Mode.ShowTests;
            }
        }

        private void frmManageApplicationsAndTests_Load(object sender, EventArgs e)
        {
            if (mode == Mode.ShowApplications)
            {

                lblHeading.Text = "Manage Applications";
                dataGridView1.DataSource = clsApplicationType.GetAllApplicationsTypes();
                CMSeditApplicationsTests.Items.RemoveAt(1);
         

            }
            else
            {

                lblHeading.Text = "Manage Tests";
                dataGridView1.DataSource = clsTest.GetAllTestsTypes();
                CMSeditApplicationsTests.Items.RemoveAt(0);


            }

            lblTotal.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true; 
                CMSeditApplicationsTests.Show(dataGridView1, e.Location);

            }
        }

        private void manageApplicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = (int)dataGridView1.CurrentRow.Cells[0].Value; 
            frmUpdateApplicationTest frm = new  frmUpdateApplicationTest("UpdatApplicationType",ApplicationTypeID);
            frm.ShowDialog();
        }

        private void managToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmUpdateApplicationTest frm = new frmUpdateApplicationTest("UpdateTestType", TestTypeID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
