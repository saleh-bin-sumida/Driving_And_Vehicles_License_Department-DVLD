
using DVLD.AddUpdate_Screens;
using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Manage_Screens
{
    public partial class frmManageILApplications : frmManageScreen
    {
        public frmManageILApplications() : base() 
        {
            InitializeComponent();
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;
        }

        protected override void RefreshDataGridView()
        {
            _dt = clsApplication.GetAll_ILApplications();
            base.RefreshDataGridView();
        }


        private void frmManageILApplications_Load(object sender, System.EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            base.cbxFilter_SelectedIndexChanged();

            if (_selectedFilter == "Is Active")
                cbxExpressions.Visible = true;
            else
                cbxExpressions.Visible = false;
        }

        private void cbxExpressions_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            DataView dataView = _dt.DefaultView;


            if (cbxExpressions.SelectedItem.ToString() == "Active")
                dataView.RowFilter = $"IsActive = 1";
            else if (cbxExpressions.SelectedItem.ToString() == "Not Active")
                dataView.RowFilter = $"IsActive = 0";
            else
                RefreshDataGridView();
        }

        private void tsmShowLicenseDetails_Click(object sender, System.EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;

            frmShowDriverIntLicense frm = new frmShowDriverIntLicense(ID);
            frm.ShowDialog();
        }

       

        private void tsmShowPersonDetails_Click(object sender, System.EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[1].Value;

            clsApplication app = clsApplication.Find(ID);

            frmShowPersonInfo frm = new frmShowPersonInfo(app.ApplicantPersonID);
            frm.ShowDialog();

            RefreshDataGridView();
        }
        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) // Check if right mouse button is clicked
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
                {
                    DataGridView.CurrentCell = DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Select the cell that was right-clicked
                    DataGridView.Rows[e.RowIndex].Selected = true;

                    // Display the context menu strip at the mouse pointer position

                    cmsManageILApplications.Show(Cursor.Position);

                }
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddILapplication frm = new frmAddILapplication();
            frm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, System.EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[2].Value;

            frmShowLicenseHistory frm = new frmShowLicenseHistory(ID);
            frm.ShowDialog();
        }
    }
}
