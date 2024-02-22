
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
            base.DataGridView.CellMouseClick += CellMouseClick_dataGridVeiew;

        }


        protected override void RefreshDataGridView()
        {
            this._dt = clsUser.GetAllUsers();
            base.RefreshDataGridView(); 
            
        }


        private void frmManageUsers_Load_2(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            cbxExpressions.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            base.cbxFilter_SelectedIndexChanged();

            if ( _selectedFilter == "Is Active")
                cbxExpressions.Visible = true;
            else
                cbxExpressions.Visible = false;

        }

        private void cbxExpressions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataView dataView = _dt.DefaultView;
         
            
            if (cbxExpressions.SelectedItem.ToString() == "Active")
                dataView.RowFilter = $"IsActive = 1";
            else if (cbxExpressions.SelectedItem.ToString() == "Not Active")
                dataView.RowFilter = $"IsActive = 0";
            else
                RefreshDataGridView();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();

            RefreshDataGridView();
        }


        private void CellMouseClick_dataGridVeiew(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.ClearSelection();
                DataGridView.Rows[e.RowIndex].Selected = true;
                this.cmsManageUsers.Show(DataGridView, e.Location);


            }
        }
  

        private void toolStripMeune_Clicked(object sender, EventArgs e)
        {
            int ID = (int)DataGridView.CurrentRow.Cells[0].Value;


            switch (((ToolStripMenuItem)sender).Name.ToString())
            {
                case "tsmShowDetails":
                    frmShowUserInfo ShowForm = new frmShowUserInfo(ID);
                    ShowForm.ShowDialog();
                    break;

                case "tsmAdd":
                    btnAdd_Click(sender, e);
                    break;

                case "tsmEdit":
                    frmAddUpdateUser EditForm = new frmAddUpdateUser(ID);
                    EditForm.ShowDialog();
                    break;

                case "tsmDelete":

                    if (MessageBox.Show("R U sure To delete this User?", "Deleting User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (clsPerson.DeletePerson(ID))
                            MessageBox.Show("User Deleted Succesfully");
                        else
                            MessageBox.Show("this User Liked with application on this system, Cant be deleted");
                    }
                    break;
            }

            RefreshDataGridView();
        }   
    }
}
