using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManagePeopleUsers : Form
    {

        private enum Mode { ManagePeople = 1, ManageUsers = 2 };

        Mode _mode;
        private DataTable _dt;
        
        private static string _selectedFilter;


        public frmManagePeopleUsers(string WhoToShow)
        {
            InitializeComponent();
            if (WhoToShow == "People")
            {
                _mode = Mode.ManagePeople;

                cbxFilter.DataSource = new object[]  {
                    "None", "PersonID", "NationalNo", "FirstName",
                    "SecondName", "ThridName", "LastName", "Gender", "CountryName", "Address" };

                lblHeading.Text = "Manage People";
                btnAdd.Text = "Add Person";
                contextMenueStrip.Items.RemoveAt(5);
  

            }
            else if (WhoToShow == "Users")
            {
                _mode = Mode.ManageUsers;
                cbxFilter.DataSource = new object[] { "None", "UserID", "PersonID", "Full Name", "Username", "Active" };

                lblHeading.Text = "Manage Users";
                btnAdd.Text = "Add User";

            }
            _RefreshDataGridView();   
        }

        private void _RefreshDataGridView()
        {
            if (_mode == Mode.ManagePeople)
                _dt = clsPerson.GetAllPersons();
            else
                _dt = clsUser.GetAllUsers();
           DataGridView.DataSource = _dt.DefaultView;
        }

  
        private void frmManagePeople_Load(object sender, EventArgs e)
        {

             _RefreshDataGridView();

            cbxFilter.SelectedIndex = 0;
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();

            if (_mode == Mode.ManagePeople)
                cbxExpressions.DataSource = new object[] { "All", "Male", "Female" };
            else
                cbxExpressions.DataSource = new object[] { "All", "Active", "Not Active" };

            cbxExpressions.SelectedIndex = 0;

        }



        private void AddNew_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.ManagePeople)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
                frm.ShowDialog();

            }
            else
            {
                frmAddUpdateUser frm = new frmAddUpdateUser(-1);
                frm.ShowDialog();
            }
            _RefreshDataGridView();
        }


        private void tsmAdd_Click(object sender, EventArgs e)
        {
            AddNew_Click(sender, e);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            if (_mode == Mode.ManagePeople)
            {
                frmAddUpdatePerson frmPeople = new frmAddUpdatePerson(ID);
                frmPeople.ShowDialog();
            }
            else
            {
                frmAddUpdateUser frmUsers = new frmAddUpdateUser(ID);
                frmUsers.ShowDialog();
            }


            _RefreshDataGridView();


        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            string ob = "Person";
            if (_mode == Mode.ManageUsers)
                ob = "User";
            

            if (MessageBox.Show($"Do you want to delete the {ob} with ID {ID} ?", "Deleting {ob}",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_mode == Mode.ManagePeople)
                {
                    if (clsPerson.DeletePerson(ID))
                        MessageBox.Show($"person with ID {ID} deleted succesfully");
                    else
                        MessageBox.Show($"person with ID {ID} falid to delete, cuz referneced in other data");


                }
                else
                {
                    if (clsUser.DeleteUser(ID))
                        MessageBox.Show($"user with ID {ID} deleted succesfully");
                    else
                        MessageBox.Show($"user with ID {ID} falid to delete, cuz referneced in other data");

                }
            }
  
          
             _RefreshDataGridView();

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;

            if (_mode == Mode.ManagePeople)
            {
                frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(ID);
                frmShowPersonInfo.ShowDialog();
            }
            else
            {
               frmShowUserInfo frm = new frmShowUserInfo(ID);
                frm.ShowDialog();
            }            

            _RefreshDataGridView();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFilter = cbxFilter.SelectedItem.ToString();
            txtFilterExpressions.Text = "";


            if (_selectedFilter != "None")
                txtFilterExpressions.Visible = true;
            else
                txtFilterExpressions.Visible = false;

            if (_selectedFilter == "Gender" || _selectedFilter == "Active")
            {
                cbxExpressions.Visible = true;
            }
            else
            {
                cbxExpressions.Visible = false;
            }
            _RefreshDataGridView();
        }    

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            DataView dv = _dt.DefaultView;

            if (txtFilterExpressions.Text == "" || txtFilterExpressions.Text == String.Empty || _selectedFilter == "None")
            {
                _RefreshDataGridView();
                return;

            }
            if ( _selectedFilter == "PersonID" || _selectedFilter == "UserID")
            {
                dv.RowFilter = $"{_selectedFilter} = '{txtFilterExpressions.Text}'";
                return;
            }

            

            dv.RowFilter = $"{_selectedFilter} LIKE '%{txtFilterExpressions.Text}%'";
        }

        private void txtFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_selectedFilter == "PersonID" || _selectedFilter == "UserID" || _selectedFilter == "Gender")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }



        private void cbxExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = _dt.DefaultView;
            if (_selectedFilter == "Gender")
            {
                if (cbxExpressions.SelectedItem.ToString() == "Male")
                {
                    dataView.RowFilter = $"Gender = '1'";

                }
                else if  (cbxExpressions.SelectedItem.ToString() == "Female")
                {
                    dataView.RowFilter = $"Gender = '0'";

                }
                else
                {
                    _RefreshDataGridView();
                }
            }
            else if (_selectedFilter == "Active")
            {
                if (cbxExpressions.SelectedItem.ToString() == "Active")
                {
                    dataView.RowFilter = $"IsActive = 1";

                }
                else if (cbxExpressions.SelectedItem.ToString() == "Not Active")
                {
                    dataView.RowFilter = $"IsActive = 0";

                }
                else
                {
                    _RefreshDataGridView();
                }
            }
        
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            frmChangeUserPassword frm = new frmChangeUserPassword(ID);
            frm.ShowDialog();

        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                contextMenueStrip.Show(DataGridView, e.Location);

            }
        }
    }
}
