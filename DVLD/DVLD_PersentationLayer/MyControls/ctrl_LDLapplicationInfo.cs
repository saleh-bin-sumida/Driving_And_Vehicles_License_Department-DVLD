using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrl_LDLapplicationInfo : UserControl
    {
        cls_NewLDLApplication _LDLapp;
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
            _LDLapp = cls_NewLDLApplication.Find(LDLappID);

            if (!_LDLapp.LinkedwithLicense())
            {
                linkLabelShowLicenseInfo.Enabled = false;
            }
            DLAppID = _LDLapp.LDL_ApplicationID;
            lblAppliedForLicense.Text = clsLicense.LicenseClassName(_LDLapp.LicenseClassID);
            lblPassedTests.Text = _LDLapp.GetPassedTests().ToString();
        }

    }
}
