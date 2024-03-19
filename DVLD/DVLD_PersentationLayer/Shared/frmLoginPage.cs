using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;

namespace DVLD
{
    public partial class frmLoginPage : Form
    {
        clsUser _User;

        string Username;
        string Password;
        bool RemeberMe;
        public frmLoginPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
                SaveUserCredentials();
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
            this.frmLoginPage_Load(null, null);
        }

        private void frmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void _CloseLoginPage()
        {
            this.Close();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            if (GetUserCredentials())
            {
                if (this.RemeberMe)
                {
                    txtUsername.Text = this.Username;
                    txtPassword.Text = this.Password;
                    this.chkRemeber.Checked = true;
                    return;
                }
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

            this.chkRemeber.Checked = false;

        }


        private bool SaveUserCredentials()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            string strRememberMe = "1";
            _ = (chkRemeber.Checked) ? strRememberMe = "1" : strRememberMe = "0";

            string valueName = "UserCredentials";
            string valueData = $"{txtUsername.Text}/#/{txtPassword.Text}/#/{strRememberMe}";


            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

            }
            catch (Exception e)
            {
                Util.LogError(e.Message);
                return false; 
            }

            return true;
        }

        private bool GetUserCredentials()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            string valueName = "UserCredentials";
            string valueData = "";


            try
            {
                // Write the value to the Registry
                valueData = Registry.GetValue(keyPath, valueName, null) as string;

                if (valueData == null)
                    return false;

                string[] UserInfo = valueData.Split(new string[]{"/#/"},StringSplitOptions.None);
                this.Username = UserInfo[0];
                this.Password = UserInfo[1];
                _ =(UserInfo[2] == "0") ? this.RemeberMe = false : this.RemeberMe = true ;
            }
            catch ( Exception e)
            {
                Util.LogError(e.Message);
                return false;
            }
            return true;

        }


    }
}
