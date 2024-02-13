using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangeUserPassword : Form
    {
        int _UserID;
        clsUser _User;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.FindUserBy(_UserID);
            ctrlPersonCard1.LoadData(_User._person);
            ctrlLoginInfo1.LoadData(_User);
            pbxInvalidPassword.Visible = false;
            txtOldPassword.Text = _User.Password;
        }

        private void PasswordTextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                pbxInvalidPassword.Visible = true;
                return;
            }
            pbxInvalidPassword.Visible = false;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (pbxInvalidPassword.Visible  || txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("Incorrect new password, Write New Password and confirm it", "invalid Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Your Password Update Succesfully", "Updating Password",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MessageBox.Show("Faild to update Your Password", "Updating Password",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
