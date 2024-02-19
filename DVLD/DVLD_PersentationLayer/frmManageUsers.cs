
using System;
using System.Data;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageUsers : frmManageScreen
    {
        public frmManageUsers(): base() 
        {
            InitializeComponent();
        }


        private void _RefreshDataGridView()
        {
            this._dt = clsUser.GetAllUsers();
            DataGridView.DataSource = _dt;
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedFilter = cbxFilter.SelectedItem.ToString();
            txtFilterExpressions.Text = "";

            base.cbxFilter_SelectedIndexChanged();

            if ( _selectedFilter == "Active")
                cbxExpressions.Visible = true;
            else
                cbxExpressions.Visible = false;

            _RefreshDataGridView();
        }

        private void cbxExpressions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataView dataView = _dt.DefaultView;
         
            
            if (cbxExpressions.SelectedItem.ToString() == "Active")
                dataView.RowFilter = $"IsActive = 1";
            else if (cbxExpressions.SelectedItem.ToString() == "Not Active")
                dataView.RowFilter = $"IsActive = 0";
            else
                _RefreshDataGridView();
            
        }

    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();

            _RefreshDataGridView();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            //cbxFilter.DataSource = new object[] { "None", "UserID", "PersonID", "Full Name", "Username", "Active" };
            //cbxExpressions.DataSource = new object[] { "All", "Active", "Not Active" };
            _RefreshDataGridView();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
       
            frmShowUserInfo frm = new frmShowUserInfo(ID);
            frm.ShowDialog();
            

            _RefreshDataGridView();
        }

        private void tsmAddUser_Click(object sender, EventArgs e)
        {
           btnAdd_Click(sender, e); 
        }

        private void tsmEditUser_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
    
            frmAddUpdateUser frmUsers = new frmAddUpdateUser(ID);
            frmUsers.ShowDialog();
           

            _RefreshDataGridView();
        }

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;


            if (MessageBox.Show($"Do you want to delete the User with ID {ID} ?", "Deleting User",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(ID))
                    MessageBox.Show($"user with ID {ID} deleted succesfully");
                else
                    MessageBox.Show($"user with ID {ID} falid to delete, cuz referneced in other data");
            }

            _RefreshDataGridView();
        }

  

        private void frmManageUsers_Load_2(object sender, EventArgs e)
        {
            _RefreshDataGridView();
            cbxFilter.SelectedIndex = 0;
            cbxExpressions.SelectedIndex = 0;
        }

        private void txtFilterExpressions_TextChanged(object sender, EventArgs e)
        {
            DataView dv = _dt.DefaultView;

            if (txtFilterExpressions.Text == "" || txtFilterExpressions.Text == String.Empty || _selectedFilter == "None")
            {
                _RefreshDataGridView();
                return;

            }
            if (_selectedFilter == "UserID")
            {
                dv.RowFilter = $"{_selectedFilter} = '{txtFilterExpressions.Text}'";
                return;
            }



            dv.RowFilter = $"{_selectedFilter} LIKE '%{txtFilterExpressions.Text}%'";
        }
    }
}
