using DVLD.Licenes_Applications;
using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRenewLicenseApp : frmLicenseServiceScreen
    {
        clsLocalLicense OldLicense;
        clsLocalLicense NewLicense;
        clsApplication RenewApplication;
        public frmRenewLicenseApp() : base()
        {
            InitializeComponent();
        }

        private void frmRenewLicenseApp_Load(object sender, System.EventArgs e)
        {

            btn.Enabled = false;
            linklabel_NewLicense.Enabled = false;
            linklabel_licsneHistroy.Enabled = false;

            RenewApplication = new clsApplication(2);



            lblapplicationDate.Text = RenewApplication.ApplicationDate.ToString();
            lblIssueDate.Text = lblapplicationDate.Text;
            lblapplicationFees.Text = RenewApplication.PaidFees.ToString();
            lblCreatedbyUser.Text = RenewApplication.CreatedByUserID.ToString();
        }

        private void ctrlDriverLicenseCardwithFilter1_OnLicenseSelected(int obj)
        {
            OldLicense = clsLocalLicense.Find(obj);


            clsApplication Oldapp = clsApplication.Find(OldLicense.ApplicationID);
            RenewApplication.ApplicantPersonID = Oldapp.ApplicantPersonID;





            lblLicenseFees.Text = OldLicense.PaidFees.ToString();
            lblOldLicenseID.Text = OldLicense.LocalLicenseID.ToString();
            decimal TotalFees = RenewApplication.PaidFees + OldLicense.PaidFees;
            lblTotalFees.Text = TotalFees.ToString();
            lblExpirationDate.Text = DateTime.Now.Date.AddYears(clsLocalLicense.GetDefaultValidityLength(OldLicense.LicenseClassID)).ToString();

            btn.Enabled = true;
            linklabel_licsneHistroy.Enabled = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (OldLicense.IsActive)
            {
                MessageBox.Show("this license still active, not allowed to issue tow active licenses");
                return;
            }

            if (clsDriver.HasActiveLocalLicense(OldLicense.DriverID, OldLicense.LicenseClassID))
            {
                MessageBox.Show("this driver has active license from this class!");
                return;
            }

            if (RenewApplication.Save())
            {

                NewLicense = new clsLocalLicense(-1, OldLicense.LicenseClassID, txtNotes.Text, OldLicense.PaidFees, 2,
                 RenewApplication.ApplicationID, OldLicense.DriverID, DateTime.Now.Date,
                  DateTime.Now.Date.AddYears(clsLocalLicense.GetDefaultValidityLength(OldLicense.LicenseClassID)), true,
                  GlobalSettings.CurrentUser.UserID);

                if (NewLicense.Save())
                {
                    lbl_RenewApplicationID.Text = RenewApplication.ApplicationID.ToString();
                    lblRenewdLicenseID.Text = NewLicense.LocalLicenseID.ToString();
                    btn.Enabled = false;
                    linklabel_NewLicense.Enabled = true;
                    MessageBox.Show("License renewed succesfully");
                    return;
                }
                MessageBox.Show("falid to renew this License!");

            }

        }

        private void linklabel_NewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocallicenseInfo(NewLicense.LocalLicenseID);
        }

        private void linklabel_licsneHistroy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory(OldLicense.DriverID);
        }
    }
}
