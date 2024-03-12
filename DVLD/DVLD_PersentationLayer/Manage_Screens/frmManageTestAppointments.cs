using DVLD.AddUpdate_Screens;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System.Windows.Forms;

namespace DVLD.Manage_Screens
{
    public partial class frmManageTestAppointments : Form
    {
        enum Mode { Addappoinment, RetakeTestApp};
        Mode mode;

        cls_LDLapplication LDLapp;
        clsApplication RetakeTestApp;
        int _TestTypeID;
        public frmManageTestAppointments(int LDLappID, int TestType) 
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;


            LDLapp = cls_LDLapplication.Find(LDLappID);
            _TestTypeID = TestType;
        
        }

        private void LoadData()
        {
        

            ctrl_LDLapplicationInfo1.LoadData(LDLapp.LDL_ApplicationID);
            ctrlBasicApplicationInfo1.LoadData(LDLapp.ApplicationID);
            RefreshDataGridVeiw();

        }

        private void frmManageTestAppointments_Load(object sender, System.EventArgs e)
        {
            if (_TestTypeID == 1)
                lblHeading.Text = "Vision Test Appointments";
            else if (_TestTypeID == 2)
                lblHeading.Text = "Wrriten Test Appointments";
            else
                lblHeading.Text = "Street Test Appointments";

            LoadData();
            string temp = "";
            if (LDLapp.AllowedToCreateAppointment(_TestTypeID,ref temp))
            {

            }
            

        }

        private void RefreshDataGridVeiw()
        {
            DataGridView.DataSource = clsTestAppointment.GetAllTestAppointments(LDLapp.LDL_ApplicationID, _TestTypeID);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string ErrorMessage = "";
            if (!LDLapp.AllowedToCreateAppointment(_TestTypeID, ref ErrorMessage))
            {
                MessageBox.Show(ErrorMessage);
                return;
            }

            if (LDLapp.HasAppoinntment(_TestTypeID))
            {
                RetakeTestApp = new clsApplication(8);
                RetakeTestApp.ApplicantPersonID = LDLapp.ApplicantPersonID;

                frmAddUpdateTestAppointment fr = new frmAddUpdateTestAppointment(-1, LDLapp.LDL_ApplicationID, _TestTypeID,RetakeTestApp);
                fr.ShowDialog();
                LoadData();
                return;
            }

            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(-1, LDLapp.LDL_ApplicationID, _TestTypeID, RetakeTestApp);
            frm.ShowDialog();

            LoadData();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tsmEdit_Click(object sender, System.EventArgs e)
        {
                
            int TestAppointmentID  = (int)DataGridView.CurrentRow.Cells[0].Value;
            
            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(TestAppointmentID, LDLapp.LDL_ApplicationID, _TestTypeID, RetakeTestApp);
 
            frm.ShowDialog();

            LoadData();
        }

        private void tsmTakeTest_Click(object sender, System.EventArgs e)
        {
            bool isLocked = (bool)DataGridView.CurrentRow.Cells[3].Value;
            if (isLocked)
            {
                MessageBox.Show("this Appointment is locked!");
                return;
            }

            int TestAppointmentID = (int)DataGridView.CurrentRow.Cells[0].Value;

            frmTakeTest frm = new frmTakeTest(TestAppointmentID);
            frm.ShowDialog();

            LoadData();
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Check if right mouse button is clicked
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
                {
                    DataGridView.CurrentCell = DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Select the cell that was right-clicked
                    DataGridView.Rows[e.RowIndex].Selected = true;

                    // Display the context menu strip at the mouse pointer position
                    cmsTestAppointments.Show(Cursor.Position);

                }
            }
        }
    }
}
