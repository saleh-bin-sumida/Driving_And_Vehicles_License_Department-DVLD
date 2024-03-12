using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System;

using System.Windows.Forms;

namespace DVLD.AddUpdate_Screens
{
    public partial class frmAddUpdateTestAppointment : Form
    {
        //enum Mode { AddnewAppointment, UpdateAppointment, RetakeTestApp};
        //Mode mode;


        cls_LDLapplication _LDLapp;
        clsTestAppointment _TestAppointment;

        public frmAddUpdateTestAppointment(int TestAppointmentID , int LDLappID, int TestTypeID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;


            _LDLapp = cls_LDLapplication.Find(LDLappID);
        

            if (TestAppointmentID == -1)
            {
               // mode = Mode.AddnewAppointment;
                _TestAppointment = new clsTestAppointment(LDLappID, TestTypeID);
                return;
            }

            //mode = Mode.UpdateAppointment;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);


        }

        private void LoadData()
        {
            gbx.Text = _TestAppointment.TypeName();
            lbl_LDLappID.Text = _LDLapp.LDL_ApplicationID.ToString();
            lblDClass.Text = _LDLapp.TypeTitle();
            lblName.Text = _LDLapp.ApplicantName();
            lblTrial.Text = _LDLapp.Trial(_TestAppointment.TestTypeID).ToString();
            dtpAppointmentDate.MinDate = _TestAppointment.AppointmentDate;
            lblFees.Text = _TestAppointment.Fees().ToString();

        }

        

        private void frmAddUpdateTestAppointment_Load(object sender, EventArgs e)
        {
            LoadData();
            if (_LDLapp.Trial(_TestAppointment.TestTypeID) >= 1) 
            {
                clsRetakeTestApplication RetakeTestApp = new clsRetakeTestApplication(_LDLapp.LDL_ApplicationID, _TestAppointment.TestTypeID);
                lblTotalFees.Text = (_TestAppointment.Fees() + clsRetakeTestApplication.RetakeTestFees).ToString() ;
                lblR_appFees.Text = clsRetakeTestApplication.RetakeTestFees.ToString();


            }
            else
                gbxRetakeTestInfo.Enabled = false;

            if (_TestAppointment.IsLocked)
            {
                lblSatForTest.Text = "perosn already sat for the test, appointment locked";
                lblHeading.Text = "Schdule Retake Test";
                dtpAppointmentDate.Enabled = false;
                gbxRetakeTestInfo.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;




            if (_TestAppointment.Save())
            {
                MessageBox.Show($"Test Appointment Saved Succesfully at {_TestAppointment.AppointmentDate}","Saving Appointment");
                //lblR_testAppID.Text = 
                return;
            }

            MessageBox.Show($"Falid to save Test Appointment", "Saving Appointment");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
