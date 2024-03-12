using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateApplicationTestTypes : Form
    {

        enum Mode { UpdateApplication = 1, UpdateTest = 2 };
        Mode mode;

        int _ID;

        dynamic _obj; // could be Application or test [will be initialized in runtime]
        public frmUpdateApplicationTestTypes(string WhatToUpdate, int ID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _ID = ID;

            if (WhatToUpdate == "UpdatApplicationType")
                mode = Mode.UpdateApplication;
            else if (WhatToUpdate == "UpdateTestType")
                mode = Mode.UpdateTest;
        }


        private void frmUpdateApplicationTest_Load(object sender, EventArgs e)
        {
            if (mode == Mode.UpdateApplication)
            {
                lblDescription.Visible = false;
                txtDescription.Visible = false;

                lblHeading.Text = "Update Application";
                _obj = clsApplicationType.GetApplicationTypeInfoByID(_ID);
                txtTitle.Text = _obj.ApplicationTypeTitle;
                txtFees.Text = _obj.ApplicationTypeFees.ToString();
            }
            else
            {
                lblHeading.Text = "Update Test";
                _obj = clsTestType.GetTestTypeInfoByID(_ID);
                txtTitle.Text = _obj.TestTypeTitle;
                txtFees.Text = _obj.TestTypeFees.ToString();
                txtDescription.Text = _obj.TestTypeDescription;
                

            }


            lblIDValue.Text = _ID.ToString();
        }


        private bool _IsAllFieldsValid()
        {
            if (txtTitle.Text == "" || txtFees.Text == "")
            {
                return false;
            }
            if (mode == Mode.UpdateTest && txtDescription.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldsValid())
            {
                MessageBox.Show("plese fill all the fields", "Invalid Field Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ObjectType;
            if (mode == Mode.UpdateApplication)
            {
                ObjectType = "Application";
                _obj.ApplicationTypeTitle = txtTitle.Text;
                _obj.ApplicationTypeFees = decimal.Parse( txtFees.Text);
            }
            else
            {
                ObjectType = "Test";
                _obj.TestTypeTitle = txtTitle.Text;
                _obj.TestTypeFees = decimal.Parse(txtFees.Text);
                _obj.TestTypeDescription = txtDescription.Text;

            }

            if (_obj.Update())
            {
                MessageBox.Show($"{ObjectType} Type updated Succesfully", $"Updating {ObjectType} Type");
                return;
            }
            MessageBox.Show("somthing went wrong");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
