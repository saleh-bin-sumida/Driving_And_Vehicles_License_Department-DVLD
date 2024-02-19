
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageScreen : Form
    {
        protected enum Mode { ManagePeople =1 ,ManageUers=2, ManageApplications=3 }
        protected Mode _mode;

        protected DataTable _dt;
        protected string _selectedFilter;

        public frmManageScreen()
        {
            InitializeComponent();

        }

        protected void cbxFilter_SelectedIndexChanged()
        {
            _ = (_selectedFilter == "None") ? txtFilterExpressions.Visible = false : txtFilterExpressions.Visible = true;
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtFilterExpressions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_selectedFilter == "PersonID" || _selectedFilter == "UserID" || _selectedFilter == "Gender")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                //contextMenueStrip.Show(DataGridView, e.Location);

            }
        }
    }
}
