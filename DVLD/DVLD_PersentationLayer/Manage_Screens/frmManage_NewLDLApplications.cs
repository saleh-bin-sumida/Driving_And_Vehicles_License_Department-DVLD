using System;
using System.Data;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManage_NewLDLApplications : frmManageScreen
    {
       // private DataTable _dt;
        public frmManage_NewLDLApplications() : base()
        {
            InitializeComponent();
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;

        }

        private void frmManage_NewLDLApplications_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
            
        }

        protected override void RefreshDataGridView()
        {
            _dt = cls_NewLDLApplication.GetAll_NewLDLApplications();
            base.RefreshDataGridView();
        }
  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdate_NewLDLApplication frm = new frmAddUpdate_NewLDLApplication(-1);
            frm.ShowDialog();

            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        { 
            base.cbxFilter_SelectedIndexChanged();
        }

        private void tsmCancel_Click(object sender, EventArgs e)
        {
            int ID = (int) DataGridView.CurrentRow.Cells[0].Value;
            cls_NewLDLApplication.Cancel(ID);

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
                    cmsManageLDLApplications.Show(Cursor.Position);

                    int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
                    InitializeContextMenueStrip(ID);

                }
            }
        }

        private void InitializeContextMenueStrip(int LDLappID)
        {
            cls_NewLDLApplication lDLApplication = cls_NewLDLApplication.Find(LDLappID);

            if (lDLApplication.IsCompleted())
            {
                tsmShowDetails.Enabled = false;
                tsmEdit.Enabled = false;
                tsmDelete.Enabled = false;
                tsmCancel.Enabled = false;
                tsmSechduleTests.Enabled = false;
                tsmIssueDrivingLicense.Enabled = true;
            }

            if (lDLApplication.IsNew())
                tsmCancel.Enabled = true;
            else
                tsmCancel.Enabled = false;
        }

    }
}
