using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System;

using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowApplicationDetails : Form
    {
        cls_LDLapplication LDLApplication;

        public frmShowApplicationDetails(int LDLAppID)
        {

            InitializeComponent();
            LDLApplication = cls_LDLapplication.Find(LDLAppID);
        }


        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            
            this.ctrl_LDLapplicationInfo1.LoadData(LDLApplication.LDL_ApplicationID);
            this.ctrlBasicApplicationInfo1.LoadData(LDLApplication.ApplicationID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
