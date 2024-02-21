
using DVLD_BusinessLayer;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManagePeople : frmManageScreen
    {
        public frmManagePeople() : base()
        {
            InitializeComponent();
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew; 
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


        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                this.cmsManagePeople.Show(DataGridView, e.Location);


            }
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

        

        
        private void toolStripMeune_Clicked(object sender, EventArgs e)
        {
            int ID = (int) DataGridView.CurrentRow.Cells[0].Value;
            

            switch ( ((ToolStripMenuItem)sender).Name.ToString() )
            {
                case "tsmShowDetails":
                    frmShowPersonInfo ShowForm = new frmShowPersonInfo(ID);
                    ShowForm.ShowDialog();
                    break;

                case "tsmAdd":
                    btnAdd_Click(sender, e);
                    break;

                case "tsmEdit":
                    frmAddUpdatePerson EditForm = new frmAddUpdatePerson(ID);
                    EditForm.ShowDialog();
                    break;

                case "tsmDelete":

                    if (MessageBox.Show("R U sure To delete this Person?", "Deleting Person", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (clsPerson.DeletePerson(ID))
                            MessageBox.Show("Person Deleted Succesfully");
                        else
                            MessageBox.Show("this Person Liked with application on this system, Cant be deleted");
                    }
                    break;
            }

            _RefreshDataGridView();
        }

    }
}
