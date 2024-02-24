using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System;

using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowApplicationDetails : Form
    {
        clsApplication App;
        cls_NewLDLApplication LDLApplication;
        public frmShowApplicationDetails(int LDLAppID)
        {
            InitializeComponent();
            LDLApplication = cls_NewLDLApplication.Find(LDLAppID);
           // App = clsApplication.Find(LDLApplication.ApplicationID);
        }


        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            this.ctrl_LDLapplicationInfo1.LoadData(LDLApplication);
        //    this.ctrlBasicApplicationInfo1.LoadData(App);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
