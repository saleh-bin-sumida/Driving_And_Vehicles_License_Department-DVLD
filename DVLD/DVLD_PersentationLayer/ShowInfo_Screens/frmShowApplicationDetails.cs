using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System;

using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowApplicationDetails : Form
    {
        cls_NewLDLApplication LDLApplication;

        public frmShowApplicationDetails(int LDLAppID)
        {

            InitializeComponent();
            LDLApplication = cls_NewLDLApplication.Find(LDLAppID);
        }


        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            cls_NewLDLApplication s;
            
            this.ctrl_LDLapplicationInfo1.LoadData(LDLApplication.LDL_ApplicationID);
            this.ctrlBasicApplicationInfo1.LoadData(LDLApplication.ApplicationID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
