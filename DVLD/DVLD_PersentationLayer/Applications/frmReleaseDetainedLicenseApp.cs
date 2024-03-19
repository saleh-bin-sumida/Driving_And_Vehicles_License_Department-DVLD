using DVLD_BusinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD.Licenes_Applications
{
    public partial class frmReleaseDetainedLicenseApp : frmLicenseServiceScreen
    {
        clsLocalLicense License;
        clsApplication App;
        clsLocalLicense.DetainInfo stDetainInfo;

        public frmReleaseDetainedLicenseApp() : base()
        {
            InitializeComponent();
            App = new clsApplication(5);
        }

        
        private void linklabel_licsneHistroy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory(License.DriverID);
        }

        private void linklabel_NewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocallicenseInfo(License.LocalLicenseID);
        }

        private void LoadData()
        {
            lblApplicationFee.Text = clsApplicationType.GetApplicationTypeFees(5).ToString();

            lblDetainDate.Text = DateTime.Now.Date.ToString();
            lblCreatedBy.Text = GlobalSettings.CurrentUser.UserID.ToString();

           // btn.Enabled = false;
            linklabel_licsneHistroy.Enabled = false;
            linklabel_NewLicense.Enabled = false;

        }
        private void frmReleaseDetainedLicenseApp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrlDriverLicenseCardwithFilter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
            {

                MessageBox.Show("write a license ID to release!");
                License = null;
                return;
            }
            License = clsLocalLicense.Find(obj);
            stDetainInfo = new clsLocalLicense.DetainInfo(License.LocalLicenseID);


            lblDetainID.Text = stDetainInfo.DetainID.ToString();
            lblDetainDate.Text = stDetainInfo.DetainDate.ToString();
            lblLicnseID.Text = License.LocalLicenseID.ToString(); 
            lblCreatedBy.Text = stDetainInfo.DetainedBy.ToString();
            lblFineFees.Text = stDetainInfo.FineFees.ToString();
            decimal TotalFees = clsApplicationType.GetApplicationTypeFees(5) + stDetainInfo.FineFees;
            lblTotalFees.Text = TotalFees.ToString();

            linklabel_licsneHistroy.Enabled = true;
            btn.Enabled = true ;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (License == null)
            {

                MessageBox.Show("write a license ID to release!");
                return;
            }

            if (!License.IsDetained())
            {
                MessageBox.Show("this license isnt Detained!");
                return;
            }

            FillAppData();
            App.Save();

            if (clsLocalLicense.ReleaseLicense(stDetainInfo.DetainID,App.ApplicationID))
            {
                MessageBox.Show("this license Release Succesfully");
                btn.Enabled = false;
                linklabel_NewLicense.Enabled = true;
                lblReleasAppID.Text = App.ApplicationID.ToString();
                return;
            }
                MessageBox.Show("Faild to release this license!");


        }


        private void FillAppData()
        {
            clsDriver dr = clsDriver.Find(License.DriverID);
            App.ApplicantPersonID = dr.Person.PersonID;
            App.ApplicationStatus = 3;
        }
    }

}
