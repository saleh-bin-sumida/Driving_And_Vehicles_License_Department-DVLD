
using DVLD_BusinessLayer.Application;
using System.Data;

namespace DVLD.Manage_Screens
{
    public partial class frmManageILApplications : frmManageScreen
    {
        public frmManageILApplications() : base() 
        {
            InitializeComponent();
            

        }
       
        protected override void RefreshDataGridView()
        {
            _dt = clsILApplication.GetAllILApplications();
            base.RefreshDataGridView();
        }


        private void frmManageILApplications_Load(object sender, System.EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            base.cbxFilter_SelectedIndexChanged();

            if (_selectedFilter == "Is Active")
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

        private void tsmShowLicenseDetails_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {

        }
    }
}
