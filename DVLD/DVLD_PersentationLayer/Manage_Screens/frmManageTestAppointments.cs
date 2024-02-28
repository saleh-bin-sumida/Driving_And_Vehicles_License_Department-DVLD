using DVLD.AddUpdate_Screens;
using DVLD_BusinessLayer.Application;
using DVLD_BusinessLayer.Test;
using System.Windows.Forms;

namespace DVLD.Manage_Screens
{
    public partial class frmManageTestAppointments : Form
    {
        cls_NewLDLApplication LDLapp;
        int _TestTypeID;
        public frmManageTestAppointments(int LDLappID, int TestType) 
        {
            InitializeComponent();
            LDLapp = cls_NewLDLApplication.Find(LDLappID);
            _TestTypeID = TestType;
        
        }

        private void LoadData()
        {
            if (_TestTypeID == 1)
                lblHeading.Text = "Vision Test Appointments";
            else if (_TestTypeID == 2)
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

            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(LDLapp.LDL_ApplicationID,-1, _TestTypeID);
            frm.ShowDialog();

            RefreshDataGridVeiw();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tsmEdit_Click(object sender, System.EventArgs e)
        {
            int TestAppointmentID  = (int)DataGridView.CurrentRow.Cells[0].Value;
            
            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(LDLapp.LDL_ApplicationID, TestAppointmentID, _TestTypeID);
            frm.ShowDialog();

            RefreshDataGridVeiw();
        }

        private void tsmTakeTest_Click(object sender, System.EventArgs e)
        {

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
