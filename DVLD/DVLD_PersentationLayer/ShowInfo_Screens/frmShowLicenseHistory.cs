using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowLicenseHistory : Form
    {
        clsDriver Driver;
        DataGridView dgv;
        public frmShowLicenseHistory(int DriverID)
        {
            InitializeComponent();
            Driver = clsDriver.Find(DriverID);
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonCardwithFilter1._LoadPersonCardwithFilterData(Driver.Person.PersonID);
            ctrlPersonCardwithFilter1.DisableFilter();
            Load_LocalLicenses();
            Load_InternationalLicenses();
           
            
        }

        private void Load_LocalLicenses()
        {
            dgvLocalLicenses.DataSource = Driver.GetLocalLicenses();
            lblTotalLocalLicenses.Text = dgvLocalLicenses.Rows.Count.ToString();
        }

        private void Load_InternationalLicenses()
        {
            dgvIntLicenses.DataSource = Driver.GetInternationalLicenses();
            lblTotalIntLicenses.Text = dgvIntLicenses.Rows.Count.ToString();
        }

        private void dgvMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Check if right mouse button is clicked
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
                {
                    dgv = ((DataGridView)sender);
                    dgv.CurrentCell = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex]; // Select the cell that was right-clicked
                    dgv.Rows[e.RowIndex].Selected = true;

                    // Display the context menu strip at the mouse pointer position
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            if (dgv.Columns[0].Name == "License ID")
            {
                frmShowDriverLocalLicense frm = new frmShowDriverLocalLicense(ID);
                frm.ShowDialog();
                return;
            }
            frmShowDriverIntLicense frmInt = new frmShowDriverIntLicense(ID);
            frmInt.ShowDialog();

        }
    }
}
