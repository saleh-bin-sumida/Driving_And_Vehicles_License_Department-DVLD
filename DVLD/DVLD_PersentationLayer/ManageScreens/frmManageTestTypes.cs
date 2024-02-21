
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageTestTypes : frmManageScreen
    {
        public frmManageTestTypes() : base() 
        {
            InitializeComponent();

            base.cbxFilter.Visible = false;
            base.txtFilterExpressions.Visible = false;
            base.lblFilterBy.Visible = false;
            base.btnAdd.Visible = false;
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;
        }


      
        private void frmManageTestTypes_Load(object sender, System.EventArgs e)
        {
            _RefreshDataGridView();
        }

        private void _RefreshDataGridView()
        {
            this._dt = clsTestType.GetAllTestTypes();
            DataGridView.DataSource = _dt;
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();

        }

        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                this.cmsManageTestTypes.Show(DataGridView, e.Location);
            }
        }

        private void tsmUpdateTestType_Click(object sender, System.EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            frmUpdateApplicationTest frm = new frmUpdateApplicationTest("UpdatTestType", ID);
            frm.ShowDialog();

            _RefreshDataGridView();
        }
    }
}
