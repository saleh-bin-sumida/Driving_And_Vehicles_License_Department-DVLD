using System;
using System.Data;
using DVLD_BusinessLayer;
using System.Windows.Forms;


namespace DVLD
{
    public partial class frmAddUpdateUser : Form
    {
        enum Mode { AddNew = 1, Update = 2 }
        Mode mode;
        clsUser _User;

        int _UserID;


        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;

            if (_UserID == -1)
            {

                mode = Mode.AddNew;
                lblHeading.Text = "Add New User";
            }
            else
            {
                mode = Mode.Update;
                lblHeading.Text = "Update User Info";
            }

        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {


            if (mode == Mode.AddNew)
            {

                lblUserIDValue.Visible = false;
                lblUserID.Visible = false;
                _User = new clsUser();
                return;

            }

            //------------- update mode

            _User = clsUser.FindUserBy(_UserID);
            ctrlPersonCardwithFilter1._LoadPersonCardwithFilterData(_User._person.PersonID);
            lblUserIDValue.Text = _User.UserID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            _ = (_User.IsActive ? chkIsActive.Checked = true : chkIsActive.Checked = false);

        }


        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool _IsAllFieldValid()
        {
            if (txtConfirmPassword.Text == "" || txtPassword.Text == "" ||
                txtUsername.Text == "" || ctrlPersonCardwithFilter1.PersonID == "")
                return false;
            return true;
        }

        private bool _isPersonLikedwithUser()
        {
            if (mode == Mode.Update && int.Parse(ctrlPersonCardwithFilter1.PersonID) == _User._person.PersonID)
                return false;
            return clsPerson.IsPersonLikedWithUser(int.Parse(ctrlPersonCardwithFilter1.PersonID));
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldValid())
            {
                MessageBox.Show("please fill all the fields.", "Field Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
            if (_isPersonLikedwithUser())
            {
                MessageBox.Show("this Person already liked with other user!", "Defined User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _User._person = clsPerson.FindPersonByID(int.Parse(ctrlPersonCardwithFilter1.PersonID));
            _User.Username = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;


            if (_User.Save())
            {
                MessageBox.Show("User Saved Succesfully", "Saving User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mode = Mode.Update;
                lblHeading.Text = "Update User Info";
                lblUserIDValue.Visible = true;
                lblUserID.Visible = true;
                lblUserIDValue.Text = _User.UserID.ToString();
                return;
            }

            MessageBox.Show("User faild to save!", "Saving User", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void PasswordTextChange(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                pbxInvalidPassword.Visible = true;
                return;
            }
            pbxInvalidPassword.Visible = false;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

   
    }
}
