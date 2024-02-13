using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLoginPage : Form
    {
        clsUser _User;
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == ""|| txtUsername.Text == "")
            {
                MessageBox.Show("please write ur username and ur password");
                return;
            }

            _User = clsUser.FindUserBy(txtUsername.Text, txtPassword.Text);

            if (_User != null)
            {
                if (!_User.IsActive)
                {
                    MessageBox.Show("This User Is Not Aactive, Contact Ur Admin To Activate it", "InActive User",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                GlobalSettings.CurrentUser = _User;
                Home frmHome = new Home();
                frmHome.ShowForm += _ShowLoginPage;
                frmHome.CloseForm += _CloseLoginPage;
                this.Hide();
                frmHome.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or password, try again", "Incorrect Username or password",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkRemeber_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void _ShowLoginPage()
        {
            this.Show();
        }

        private void frmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void _CloseLoginPage()
        {
            this.Close();
        }
    }
}
