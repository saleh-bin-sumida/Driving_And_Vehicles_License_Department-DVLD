﻿using System;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;
using DVLD.ShowInfo_Screens;
using DVLD.Manage_Screens;
using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class frmManage_LDLApplications : frmManageScreen
    {
       // private DataTable _dt;
        public frmManage_LDLApplications() : base()
        {
            InitializeComponent();
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;

        }

        private void frmManage_NewLDLApplications_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
            
        }

        protected override void RefreshDataGridView()
        {
            _dt = cls_LDLapplication.GetAll_NewLDLApplications();
            base.RefreshDataGridView();
        }
  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdate_LDLApplication frm = new frmAddUpdate_LDLApplication(-1);
            frm.ShowDialog();

            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        { 
            base.cbxFilter_SelectedIndexChanged();
        }

        private void tsmCancel_Click(object sender, EventArgs e)
        {
     

            RefreshDataGridView();

        }

        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) // Check if right mouse button is clicked
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
                {
                    DataGridView.CurrentCell = DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Select the cell that was right-clicked
                    DataGridView.Rows[e.RowIndex].Selected = true;

                    // Display the context menu strip at the mouse pointer position

                    int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
                    cls_LDLapplication lDLApplication = cls_LDLapplication.Find(ID);

                    ResetToolstripMeuseItems();
                    InitializeContextMenueStrip(lDLApplication);

                    cmsManageLDLApplications.Show(Cursor.Position);

                }
            }
        }

        private void ResetToolstripMeuseItems()
        {
            tsmIssueDrivingLicense.Enabled = true;
            tsmShowLicense.Enabled = true;
            tsmShowPersonLicenseHistory.Enabled = true;
            tsmEdit.Enabled = true;
            tsmDelete.Enabled = true;
            tsmCancel.Enabled = true;
            tsmSechduleTests.Enabled = true;
            tsmShowPersonLicenseHistory.Enabled = true;
            tsmIssueDrivingLicense.Enabled = true;
            tsmScheduleWrittenTest.Enabled = true;
            tsmScheduleStreetTest.Enabled = true;
            tsmScheduleVisionTest.Enabled = true;

        }

        private void InitializeScheduleTestContextMenu()
        {
            if (((int)DataGridView.CurrentRow.Cells[6].Value) == 0)
            {
                tsmScheduleWrittenTest.Enabled = false;
                tsmScheduleStreetTest.Enabled = false;
            }
            else if (((int)DataGridView.CurrentRow.Cells[6].Value) == 1)
            {
                tsmScheduleVisionTest.Enabled = false; 
                tsmScheduleStreetTest.Enabled = false;
            }
            else if (((int)DataGridView.CurrentRow.Cells[6].Value) == 2)
            {
                tsmScheduleVisionTest.Enabled = false;
                tsmScheduleWrittenTest.Enabled = false;
            }
        }

        private void InitializeContextMenueStrip(cls_LDLapplication lDLApplication)
        {

            if (lDLApplication.Status() == "New")
            {
                tsmIssueDrivingLicense.Enabled = false;
                tsmShowLicense.Enabled = false;
                tsmShowPersonLicenseHistory.Enabled = false;

                if ( ((int) DataGridView.CurrentRow.Cells[6].Value) > 0)
                {
                    tsmEdit.Enabled = false;
                    tsmDelete.Enabled = false;
                }
                InitializeScheduleTestContextMenu();


            }
            else if (lDLApplication.Status() == "Completed")
            {
                tsmEdit.Enabled = false;
                tsmDelete.Enabled = false;
                tsmCancel.Enabled = false;
                tsmSechduleTests.Enabled = false;

                if (lDLApplication.LinkedwithLicense())
                {
                    tsmIssueDrivingLicense.Enabled = false;
                }
                else
                {
                    tsmShowLicense.Enabled = false;
                    tsmShowPersonLicenseHistory.Enabled = false;
                }
            }
            else
            {
                tsmCancel.Enabled = false;
                tsmIssueDrivingLicense.Enabled = false;
                tsmEdit.Enabled = false;
                tsmShowLicense.Enabled = false;
                tsmSechduleTests.Enabled = false;
                tsmShowPersonLicenseHistory.Enabled = false;

            }

        }



        private void toolStripMeune_Clicked(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            cls_LDLapplication lDLApplication = cls_LDLapplication.Find(ID);

            switch (((ToolStripMenuItem)sender).Name.ToString())
            {
                case "tsmShowDetails":
                    frmShowApplicationDetails ShowForm = new frmShowApplicationDetails(ID);
                    ShowForm.ShowDialog();
                    break;

                case "tsmCancel":
                    cls_LDLapplication.Cancel(ID);
                    break;

                case "tsmEdit":
                    frmAddUpdate_LDLApplication EditForm = new frmAddUpdate_LDLApplication(ID);
                    EditForm.ShowDialog();
                    break;
                case "tsmScheduleVisionTest":
                    frmManageTestAppointments VisionTestForm = new frmManageTestAppointments(ID,1);
                    VisionTestForm.ShowDialog();
                    break;

                case "tsmScheduleWrittenTest":
                    frmManageTestAppointments WrittenTestForm = new frmManageTestAppointments(ID, 2);
                    WrittenTestForm.ShowDialog();
                    break;

                case "tsmScheduleStreetTest":
                    frmManageTestAppointments StreetTestForm = new frmManageTestAppointments(ID, 3);
                    StreetTestForm.ShowDialog();
                    break;

                case "tsmDelete":

                    if (MessageBox.Show("R U sure To delete this Application?", "Deleting Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (cls_LDLapplication.Delete(ID))
                            MessageBox.Show("LDL Application Deleted Succesfully");
                        else
                            MessageBox.Show("this Application Liked with License on this system, Cant be deleted");
                    }
                    break;
                case "tsmIssueDrivingLicense":
                    frmIssueDriverLicense frmDriverLicense = new frmIssueDriverLicense(ID);
                    frmDriverLicense.ShowDialog();
                    break;
                case "tsmShowLicense":
                    int licenseID = clsLocalLicense.GetLicenseIDbyLDLappID(ID);
                    frmShowDriverLocalLicense frmShowLicense = new frmShowDriverLocalLicense(licenseID);
                    frmShowLicense.ShowDialog();
                    break;
                case "tsmShowPersonLicenseHistory":
                    frmShowLicenseHistory frmSowLicenseHistory = new frmShowLicenseHistory(clsDriver.GetDriverIDby(lDLApplication.ApplicantPersonID));
                    frmSowLicenseHistory.ShowDialog();
                    break;
            }

            RefreshDataGridView();
        }



    }
}
