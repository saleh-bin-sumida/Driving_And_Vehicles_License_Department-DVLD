
using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManagePeople : frmManageScreen
    {
        public frmManagePeople() : base()
        {
            InitializeComponent();
        }



        private void _RefreshDataGridView()
        {
            this._dt = clsPerson.GetAllPersons();
            DataGridView.DataSource = _dt;
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();

        }


        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();

            _RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedFilter = cbxFilter.SelectedItem.ToString();
            txtFilterExpressions.Text = "";

            base.cbxFilter_SelectedIndexChanged();

            if (_selectedFilter == "Gender")
                cbxExpressions.Visible = true;
            else
                cbxExpressions.Visible = false;

            _RefreshDataGridView();
        }

        private void cbxExpressions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataView dataView = _dt.DefaultView;

            if (cbxExpressions.SelectedItem.ToString() == "Male")
                dataView.RowFilter = $"Gender = '1'";
            else if (cbxExpressions.SelectedItem.ToString() == "Female")
                dataView.RowFilter = $"Gender = '0'";
            else
                _RefreshDataGridView();
        
            
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(ID);
            frmShowPersonInfo.ShowDialog();

            _RefreshDataGridView();
        }

        private void tsmAddPerson_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);

        }

        private void tsmEditPerson_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;
            
            frmAddUpdatePerson frmPeople = new frmAddUpdatePerson(ID);
            frmPeople.ShowDialog();

            _RefreshDataGridView();
        }

        private void tsmDeletePerson_Click(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Do you want to delete the Person with ID {ID} ?", "Deleting Person",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
              
                if (clsPerson.DeletePerson(ID))
                    MessageBox.Show($"person with ID {ID} deleted succesfully");
                else
                    MessageBox.Show($"person with ID {ID} falid to delete, cuz referneced in other data");
            }
            _RefreshDataGridView();
        }

   

        private void frmManagePeople_Load_2(object sender, EventArgs e)
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
            if (_selectedFilter == "PersonID")
            {
                dv.RowFilter = $"{_selectedFilter} = '{txtFilterExpressions.Text}'";
                return;
            }



            dv.RowFilter = $"{_selectedFilter} LIKE '%{txtFilterExpressions.Text}%'";
        }
    }
}
