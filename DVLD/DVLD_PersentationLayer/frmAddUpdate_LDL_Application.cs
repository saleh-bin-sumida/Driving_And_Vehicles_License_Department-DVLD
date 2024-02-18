using System;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddUpdate_LDL_Application : Form
    {
        enum Mode { Addnew = 1, Update =2};
        Mode mode;

        cls_NewLDLApplication _LDLapp;

        int _LDLappID;
        public frmAddUpdate_LDL_Application(int LDLapp)
        {
            InitializeComponent();

            this._LDLappID = LDLapp;

            if (this._LDLappID == -1)
            {
                mode = Mode.Addnew;
                _LDLapp = new cls_NewLDLApplication();
            }
            else
            {
                mode = Mode.Update;
                _LDLapp = cls_NewLDLApplication.Find(this._LDLappID);
            }

        }

        private void frmNewLocalDL_Load(object sender, EventArgs e)
        {
            cbxLicenseClasses.DataSource = clsLicenseClass.GetAllLicenseClasses();
            cbxLicenseClasses.DisplayMember = "ClassName";

            if (mode == Mode.Addnew)
            {
                 _LDLapp = new cls_NewLDLApplication();
                cbxLicenseClasses.SelectedIndex = _LDLapp.LicenseClassID ;

            }
            else
            {
                lblHeading.Text = "Update Local Drving License Application";
                ctrlPersonCardwithFilter1._LoadPersonCardwithFilterData(_LDLapp.ApplicantPersonID);
                _LDLapp = cls_NewLDLApplication.Find(_LDLappID);
                cbxLicenseClasses.SelectedIndex = _LDLapp.LicenseClassID + 1;
                
            }

            ApplicationDate.Text = _LDLapp.ApplicationDate.ToString();
            ApplicationFees.Text = _LDLapp.PaidFees.ToString();
            CreatedBy.Text = clsUser.GetUserFullNameByID(_LDLapp.CreatedByUserID);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardwithFilter1.PersonID == "" || !btnNext.Enabled)
            {
                MessageBox.Show("plese, fill all the feilds.");
                return;
            }


            _LDLapp.ApplicantPersonID = int.Parse(ctrlPersonCardwithFilter1.PersonID);
            _LDLapp.LicenseClassID = cbxLicenseClasses.SelectedIndex +1;

            if (_LDLapp.Save())
            {
                lblHeading.Text = "Update Local Drving License Application"; 
                MessageBox.Show("The Application Saved Succesfully", "saving application");
                return;

            }
            MessageBox.Show("this person already has uncompleted application from this type", "Faild to save application",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void ctrlPersonCardwithFilter1_OnPersonSelected(int obj)
        {
            btnNext.Enabled = true;
        }
    }
}
