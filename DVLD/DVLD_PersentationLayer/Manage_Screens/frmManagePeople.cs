
using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
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



        protected override void RefreshDataGridView()
        {
            this._dt = clsPerson.GetAllPersons();
            base.RefreshDataGridView();

        }

        private void frmManagePeople_Load_2(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            cbxExpressions.SelectedIndex = 0;
            RefreshDataGridView();
        }


        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();

            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           

            base.cbxFilter_SelectedIndexChanged();

            if (_selectedFilter == "Gender")
                cbxExpressions.Visible = true;
            else
                cbxExpressions.Visible = false;

        }

        private void cbxExpressions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataView dataView = _dt.DefaultView;

            if (cbxExpressions.SelectedItem.ToString() == "Male")
                dataView.RowFilter = $"Gender = '1'";
            else if (cbxExpressions.SelectedItem.ToString() == "Female")
                dataView.RowFilter = $"Gender = '0'";
            else
                RefreshDataGridView();
        
            
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
                    cmsManagePeople.Show(Cursor.Position);
                }
            }
    
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

            RefreshDataGridView();
        }

    }
}
