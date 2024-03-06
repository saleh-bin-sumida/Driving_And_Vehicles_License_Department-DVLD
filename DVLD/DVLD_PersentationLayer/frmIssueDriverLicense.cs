using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using DVLD_BusinessLayer.Application;

namespace DVLD
{
    public partial class frmIssueDriverLicense : Form
    {
        cls_NewLDLApplication LDLapp;
        public frmIssueDriverLicense(int LDLappID)
        {
            InitializeComponent();
            this.LDLapp = cls_NewLDLApplication.Find(LDLappID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLicense license = new clsLicense(LDLapp);
            license.Notes = richTextBox1.Text;

            if (license.Save())
            {
                MessageBox.Show("License Saved Succefully");
                btnIssue.Enabled = false;
                return;
            }
            MessageBox.Show("Faild to save this license!");

        }

        private void frmIssueDriverLicense_Load(object sender, EventArgs e)
        {
            ctrl_LDLapplicationInfo1.LoadData(LDLapp.LDL_ApplicationID);
            ctrlBasicApplicationInfo1.LoadData(LDLapp.ApplicationID); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
