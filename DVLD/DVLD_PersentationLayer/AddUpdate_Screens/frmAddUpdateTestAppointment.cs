using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System;

using System.Windows.Forms;

namespace DVLD.AddUpdate_Screens
{
    public partial class frmAddUpdateTestAppointment : Form
    {
        enum Mode { AddnewAppointment, UpdateAppointment};
        Mode mode;

        cls_NewLDLApplication _LDLapp;
        clsTestAppointment _TestAppointment;

        public frmAddUpdateTestAppointment(int LDLappID, int TestAppointmentID, int TestTypeID)
        {
            InitializeComponent();
            
            _LDLapp = cls_NewLDLApplication.Find(LDLappID);

            if (TestAppointmentID == -1)
            {
                mode = Mode.AddnewAppointment;
                _TestAppointment = new clsTestAppointment(LDLappID, TestTypeID);
                return;
            }

            mode = Mode.UpdateAppointment;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);


        }

        private void LoadData()
        {
            gbx.Text = _TestAppointment.TypeName();
            lbl_LDLappID.Text = _LDLapp.LDL_ApplicationID.ToString();
            lblName.Text = _LDLapp.ApplicantName();
            dtpAppointmentDate.MinDate = _TestAppointment.AppointmentDate;
            lblFees.Text = _TestAppointment.Fees().ToString();

        }

        private void frmAddUpdateTestAppointment_Load(object sender, EventArgs e)
        {
            LoadData(); 
            gbxRetakeTestInfo.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;




            if (_TestAppointment.Save())
            {
                MessageBox.Show($"Test Appointment Saved Succesfully at {_TestAppointment.AppointmentDate}","Saving Appointment");
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
