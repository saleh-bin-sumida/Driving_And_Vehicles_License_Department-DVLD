using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {

        public event Action<int> OnTestsPassed;
        protected virtual void TestPassed(int LDLappID)
        {
            Action<int> handler = OnTestsPassed;
            if (handler != null)
            {
                handler(LDLappID);
            }
        }

        clsTest _Test;
        clsTestAppointment _TestAppointment;
        cls_NewLDLApplication _LDLapp;
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            _LDLapp = cls_NewLDLApplication.Find(_TestAppointment.LDL_ApplicationID);
            _Test = new clsTest(TestAppointmentID);

        }


        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            gbx.Text = _TestAppointment.TypeName();
            lbl_LDLappID.Text = _TestAppointment.LDL_ApplicationID.ToString() ;
            lblDClass.Text = _LDLapp.TypeTitle();
            lblName.Text = _LDLapp.ApplicantName();
            lblTrial.Text = _LDLapp.Trial(_TestAppointment.TestTypeID).ToString();
            lblTestDate.Text = _TestAppointment.AppointmentDate.ToString();
            lblFees.Text = _TestAppointment.Fees().ToString();
            if (_Test.TestID == -1)
            {
                lblTestID.Text = "Not Taken Yet";
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = (rdPass.Checked) ? _Test.isPassed = true : _Test.isPassed = false;

            _Test.Notes = txtTestNotes.Text;

            if (_Test.Save())
            {
                _TestAppointment.TakeTest();
                lblTestID.Text = _Test.TestID.ToString();
                btnSave.Enabled = false;
                MessageBox.Show("Test Saved Succsefully", "Saving Test");

                if (_TestAppointment.TestTypeID == 3 && _Test.isPassed)
                    _LDLapp.MakeComplete();

                return;
            }
            MessageBox.Show("Faild to save this Test!", "Saving Test");

        }

        private void btnClsoe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
