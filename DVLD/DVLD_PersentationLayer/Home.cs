using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using DVLD.Manage_Screens;
using DVLD.AddUpdate_Screens;
using DVLD.Licenes_Applications;


namespace DVLD
{
    public partial class Home : Form
    {
        public delegate void ShowFormHandler();
        public ShowFormHandler ShowForm;
        public ShowFormHandler CloseForm;



        public Home()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

     
        private void tsmNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdate_NewLDLApplication frm = new frmAddUpdate_NewLDLApplication(-1);
            frm.ShowDialog();
        }
        private void tsmInternationalLicense_Click(object sender, EventArgs e)
        {
            frm_ILapplication frm = new frm_ILapplication();
            frm.ShowDialog();
        }

      

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tsmShowUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm?.Invoke();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke();
            
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void tsmManageTestsTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void toolStripDetainLicense_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers f = new frmManageDrivers();
            f.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManage_NewLDLApplications frm = new frmManage_NewLDLApplications();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageILApplications frm = new frmManageILApplications();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicenseApp frm = new frmRenewLicenseApp();
            frm.ShowDialog();
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmReplacementDamagedLicenseApp frm = new frmReplacementDamagedLicenseApp();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApp frm = new frmReleaseDetainedLicenseApp();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApp frm = new frmReleaseDetainedLicenseApp();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }
    }
}
