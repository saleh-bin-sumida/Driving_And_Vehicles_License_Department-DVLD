
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageApplicationTypes : frmManageScreen
    {
        public frmManageApplicationTypes() : base()
        {
            InitializeComponent();

            base.cbxFilter.Visible = false;
            base.txtFilterExpressions.Visible = false;
            base.lblFilterBy.Visible = false;
            base.btnAdd.Visible = false;
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;

        }
        private void frmManageApplicationTypes_Load(object sender, System.EventArgs e)
        {
            RefreshDataGridView();
        }

        protected override void RefreshDataGridView()
        {
            this._dt = clsApplicationType.GetAllApplicationsTypes();
            base.RefreshDataGridView();

        }


        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                this.cmsManageApplicationTypes.Show(DataGridView, e.Location);
            }
        }

        private void tsmUpdateApplicationType_Click(object sender, System.EventArgs e)
        {
            int ID = (int) DataGridView.CurrentRow.Cells[0].Value;
            frmUpdateApplicationTest frm = new frmUpdateApplicationTest("UpdatApplicationType", ID);
            frm.ShowDialog();

            RefreshDataGridView();
        }
    }
}
