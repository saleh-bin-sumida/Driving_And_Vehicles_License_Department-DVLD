
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
            RefreshDataGridView();
        }

        protected override void RefreshDataGridView()
        {
            this._dt = clsTestType.GetAllTestTypes();
            base.RefreshDataGridView();

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
                    cmsManageTestTypes.Show(Cursor.Position);
                }
            }
        }

        private void tsmUpdateTestType_Click(object sender, System.EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            frmUpdateApplicationTestTypes frm = new frmUpdateApplicationTestTypes("UpdatTestType", ID);
            frm.ShowDialog();

            RefreshDataGridView();
        }
    }
}
