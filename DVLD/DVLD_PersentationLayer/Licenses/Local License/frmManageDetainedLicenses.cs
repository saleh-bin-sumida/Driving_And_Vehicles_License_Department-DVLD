using DVLD.Licenes_Applications;
using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System;

using System.Windows.Forms;

namespace DVLD.Manage_Screens
{
    public partial class frmManageDetainedLicenses : frmManageScreen
    {
        public frmManageDetainedLicenses() : base()
        {
            InitializeComponent();
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;
        }


        protected override void RefreshDataGridView()
        {
            this._dt = clsLocalLicense.GetAllDetainedLicenses();
            base.RefreshDataGridView();

        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void ReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApp frm = new frmReleaseDetainedLicenseApp();
            frm.ShowDialog();
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


                    bool isReleased = (bool)DataGridView.CurrentRow.Cells[3].Value;
                    if (isReleased)
                        tsmReleaseDetainedLicense.Enabled = false;
                    else
                        tsmReleaseDetainedLicense.Enabled = true;

                    cmsManageDetainedLicenses.Show(Cursor.Position);


                }
            }

        }

        private void toolStripMeune_Clicked(object sender, EventArgs e)
        {
            clsLocalLicense license = clsLocalLicense.Find((int)DataGridView.CurrentRow.Cells[1].Value); 


            switch (((ToolStripMenuItem)sender).Name.ToString())
            {
                case "tsmShowPersonDetails":
                    clsDriver dr = clsDriver.Find(license.DriverID);

                    frmShowPersonInfo ShowForm = new frmShowPersonInfo(dr.Person.PersonID);
                    ShowForm.ShowDialog();
                    break;

                case "tsmShowLicenseDetails":
                    frmShowDriverLocalLicense frm = new frmShowDriverLocalLicense(license.LocalLicenseID);
                    frm.ShowDialog();
                    break;

                case "tsmShowPersonLicenseHistory":
                    frmShowLicenseHistory HistoryForm = new frmShowLicenseHistory(license.DriverID);
                    HistoryForm.ShowDialog();
                    break;

                case "tsmReleaseDetainedLicense":
                    frmReleaseDetainedLicenseApp frmRelease = new frmReleaseDetainedLicenseApp();
                    frmRelease.ctrlDriverLicenseCardwithFilter1.Select(license.LocalLicenseID);
                    frmRelease.ctrlDriverLicenseCardwithFilter1.DisableFilter();
                    frmRelease.ShowDialog();
                    break;
            }

            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.cbxFilter_SelectedIndexChanged();
        }
    }
}
