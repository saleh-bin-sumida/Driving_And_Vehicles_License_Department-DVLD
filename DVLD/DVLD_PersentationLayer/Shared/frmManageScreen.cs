
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
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            cbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        protected virtual void RefreshDataGridView()
        {
            DataGridView.DataSource = _dt;  
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();
        }


        protected void cbxFilter_SelectedIndexChanged()
        {
            _selectedFilter = cbxFilter.Text;
            txtFilterExpressions.Text = "";
            _ = (_selectedFilter == "None") ? txtFilterExpressions.Visible = false : txtFilterExpressions.Visible = true;
            RefreshDataGridView();
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtFilterExpressions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_selectedFilter == "PersonID" || _selectedFilter == "UserID" || _selectedFilter == "Gender" || _selectedFilter == "LDL app ID"
                || _selectedFilter == "D ID" || _selectedFilter == "L.ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

   

        private void txtFilterExpressions_TextChanged(object sender, System.EventArgs e)
        {
            if (txtFilterExpressions.Text == "")
            {
                RefreshDataGridView();
                return;
            }
            DataView dataView = _dt.DefaultView;
            if (_selectedFilter == "PersonID" || _selectedFilter == "UserID" || _selectedFilter == "LDL app ID"
                || _selectedFilter == "Int License ID" || _selectedFilter == "Application ID" || _selectedFilter == "Driver ID"
               || _selectedFilter == "License ID" || _selectedFilter == "D ID" || _selectedFilter == "L.ID" || _selectedFilter == "Is Released")
            {
                dataView.RowFilter = $"[{cbxFilter.Text}] = {txtFilterExpressions.Text}";
                return;
            }
            dataView.RowFilter = $"[{cbxFilter.Text}] LIKE '%{txtFilterExpressions.Text}%'";
        }
    }
}
