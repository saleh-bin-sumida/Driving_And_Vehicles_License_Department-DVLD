using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrl_LDLapplicationInfo : UserControl
    {
        public int DLAppID 
        { 
            get { return int.Parse(lbl_LDLappID.Text); } 
            private set { lbl_LDLappID.Text = value.ToString(); }
        }

       
        public ctrl_LDLapplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadData(cls_NewLDLApplication LDLapp)
        {
            DLAppID = LDLapp.LDL_ApplicationID;
            lblAppliedForLicense.Text = LDLapp.GetLicenseClassNameByID();
            lblPassedTests.Text = LDLapp.GetPassedTests().ToString();
        }

    }
}
