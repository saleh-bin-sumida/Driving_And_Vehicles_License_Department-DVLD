using DVLD.ShowInfo_Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.AddUpdate_Screens
{
    public partial class frmAdd_ILapplication : Form
    {
        public frmAdd_ILapplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctrlDriverLicenseCardwithFilter1_OnLicenseSelected(int obj)
        {
            btnIssue.Enabled = true;

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {


            btnIssue.Enabled =false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverIntLicense frm = new frmShowDriverIntLicense(ctrlDriverLicenseCardwithFilter1.LicenseID);
            frm.ShowDialog();
        }
    }
}
