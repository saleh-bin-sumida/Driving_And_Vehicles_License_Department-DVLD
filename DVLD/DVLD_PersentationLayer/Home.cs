using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;


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
        }

     
        private void tsmNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdate_NewLDLApplication frm = new frmAddUpdate_NewLDLApplication(-1);
            frm.ShowDialog();
        }
        private void tsmInternationalLicense_Click(object sender, EventArgs e)
        {

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
            frmManageApplicationsAndTests frm = new frmManageApplicationsAndTests("ManageApplicationsTypes");
            frm.ShowDialog();
        }

        private void tsmManageTestsTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationsAndTests frm = new frmManageApplicationsAndTests("ManageTestsTypes");
            frm.ShowDialog();
        }

        private void toolStripDetainLicense_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople f = new frmManagePeople();
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
    }
}
