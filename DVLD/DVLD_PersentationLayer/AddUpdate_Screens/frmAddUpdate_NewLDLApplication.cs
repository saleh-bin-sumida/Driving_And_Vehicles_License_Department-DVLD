using System;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddUpdate_NewLDLApplication : Form
    {
        enum Mode { Addnew = 1, Update =2};
        Mode mode;

        cls_NewLDLApplication _LDLapp;

        int _LDLappID;
        public frmAddUpdate_NewLDLApplication(int LDLapp)
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
            cbxLicenseClasses.SelectedIndex = _LDLapp.LicenseClassID -1 ;

            if (mode == Mode.Update)
            {
                lblHeading.Text = "Update Local Drving License Application";
                ctrlPersonCardwithFilter1._LoadPersonCardwithFilterData(_LDLapp.ApplicantPersonID);
                btnNext.Enabled = true;

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
                ctrlPersonCardwithFilter1.HideFilter();
                MessageBox.Show("The Application Saved Succesfully", "Saving application");

                return;

            }
            MessageBox.Show("this person already has completed or new  application from this License Type, " +
                "Choose aother License type", "Faild to save application",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void ctrlPersonCardwithFilter1_OnPersonSelected(int obj)
        {
            btnNext.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
