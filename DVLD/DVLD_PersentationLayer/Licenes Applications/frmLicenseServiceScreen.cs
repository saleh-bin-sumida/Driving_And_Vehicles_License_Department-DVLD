using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenes_Applications
{
    public partial class frmLicenseServiceScreen : Form
    {
        public frmLicenseServiceScreen()
        {
            InitializeComponent();
        }

     

        public void ShowLicenseHistory(int DriverId)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(DriverId);
            frm.ShowDialog();
        }
 
        public void ShowLocallicenseInfo(int LicenseID)
        {
            frmShowDriverLocalLicense frm = new frmShowDriverLocalLicense(LicenseID);
            frm.ShowDialog();
        }

        public void ShowInternationallicenseInfo(int LicenseID)
        {
            frmShowDriverIntLicense frm = new frmShowDriverIntLicense(LicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
