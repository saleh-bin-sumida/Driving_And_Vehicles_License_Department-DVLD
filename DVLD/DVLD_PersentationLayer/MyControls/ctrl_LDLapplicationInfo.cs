using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrl_LDLapplicationInfo : UserControl
    {
        cls_LDLapplication _LDLapp;
        public int DLAppID 
        { 
            get { return int.Parse(lbl_LDLappID.Text); } 
            private set { lbl_LDLappID.Text = value.ToString(); }
        }

       
        public ctrl_LDLapplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int LDLappID)
        {
            _LDLapp = cls_LDLapplication.Find(LDLappID);

            if (!_LDLapp.LinkedwithLicense())
            {
                linkLabelShowLicenseInfo.Enabled = false;
            }
            DLAppID = _LDLapp.LDL_ApplicationID;
            lblAppliedForLicense.Text = clsLocalLicense.LicenseClassName(_LDLapp.LicenseClassID);
            lblPassedTests.Text = _LDLapp.GetPassedTests().ToString();
        }

        private void linkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLocalLicense frm = new frmShowDriverLocalLicense(clsLocalLicense.GetLicenseIDbyLDLappID(_LDLapp.LDL_ApplicationID));
            frm.ShowDialog();
        }
    }
}
