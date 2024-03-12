using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenes_Applications
{
    public partial class frmReplacementDamagedLicenseApp : frmLicenseServiceScreen
    {
        clsApplication App;
        clsLocalLicense OldLicense;
        clsLocalLicense NewLicense;
        public frmReplacementDamagedLicenseApp() :  base()
        {
            InitializeComponent();
            App = new clsApplication(3);

        }

        private new void LoadData()
        {
            lblapplicationDate.Text = App.ApplicationDate.ToString();
            lblapplicationFees.Text = App.PaidFees.ToString();
            lblCreatedbyUser.Text = App.CreatedByUserID.ToString();
            rbxDamagedLicense.Checked = true;

            btn.Enabled = false;
            linklabel_licsneHistroy.Enabled = false;
            linklabel_NewLicense.Enabled = false;

        }

        private void frmReplacementDamagedLicenseApp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrlDriverLicenseCardwithFilter1_OnLicenseSelected(int obj)
        {

            linklabel_licsneHistroy.Enabled = true;
            btn.Enabled = true;

            OldLicense = clsLocalLicense.Find(obj);
            lblOldLicenseID.Text = OldLicense.LocalLicenseID.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (!OldLicense.IsLicenseActive())
            {
                MessageBox.Show("this licenes isnt active, apply for Renew license application!");
                return;
            }

            OldLicense.Deactivate();
            FillAppData();
            App.Save();

            byte IssueReason = 0;
            _ = (rbxDamagedLicense.Checked) ? IssueReason = 3 : IssueReason = 4;

            NewLicense = new clsLocalLicense(-1, OldLicense.LicenseClassID, OldLicense.Notes, OldLicense.PaidFees, IssueReason,
                App.ApplicationID, OldLicense.DriverID, DateTime.Now.Date,
                DateTime.Now.Date.AddYears(clsLocalLicense.GetDefaultValidityLength(OldLicense.LicenseClassID)), true, App.CreatedByUserID);
            if (NewLicense.Save())
            {
                linklabel_NewLicense.Enabled = true;

                lbl_ReplacementApplicationID.Text = App.ApplicationID.ToString();
                lblReplacedLicenseID.Text = OldLicense.LocalLicenseID.ToString();

                MessageBox.Show($"Licsens Replaced Succesfully the license new id is '{NewLicense.LocalLicenseID}'");
                return;
            }
            MessageBox.Show("Faild to replace this license!");
        }

        private void FillAppData()
        {
            clsApplication OldApp = clsApplication.Find(OldLicense.ApplicationID);
            App.ApplicantPersonID = OldApp.ApplicantPersonID;
            App.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
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
