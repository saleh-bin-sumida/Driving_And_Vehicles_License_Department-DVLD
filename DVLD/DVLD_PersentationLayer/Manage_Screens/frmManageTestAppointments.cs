using DVLD.AddUpdate_Screens;
using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System.Windows.Forms;

namespace DVLD.Manage_Screens
{
    public partial class frmManageTestAppointments : Form
    {
        cls_NewLDLApplication LDLapp;
        int _TestType;
        public frmManageTestAppointments(int LDLappID, int TestType) 
        {
            InitializeComponent();
            LDLapp = cls_NewLDLApplication.Find(LDLappID);
            _TestType = TestType;
        
        }

        private void LoadData()
        {
            if (_TestType == 1)
                lblHeading.Text = "Vision Test Appointments";
            else if (_TestType == 2)
                lblHeading.Text = "Wrriten Test Appointments";
            else
                lblHeading.Text = "Street Test Appointments";

            ctrl_LDLapplicationInfo1.LoadData(LDLapp.LDL_ApplicationID);
            ctrlBasicApplicationInfo1.LoadData(LDLapp.ApplicationID);
            btnAdd.Text = "Add Appointment";
            RefreshDataGridVeiw();

        }

        private void frmManageTestAppointments_Load(object sender, System.EventArgs e)
        {
            LoadData();

        }

        private void RefreshDataGridVeiw()
        {
            DataGridView.DataSource = clsTestAppointment.GetAllTestAppointments(LDLapp.LDL_ApplicationID, _TestType);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string ErrorMessage = "";
            if (!LDLapp.AllowedToCreateAppointment(_TestType, ref ErrorMessage))
            {
                MessageBox.Show(ErrorMessage);
                return;
            }

            //clsTestAppointment frm = new clsTestAppointment(LDLapp.LDL_ApplicationID, _TestType);
            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(LDLapp.LDL_ApplicationID, _TestType)

            RefreshDataGridVeiw();
        }
    }
}
