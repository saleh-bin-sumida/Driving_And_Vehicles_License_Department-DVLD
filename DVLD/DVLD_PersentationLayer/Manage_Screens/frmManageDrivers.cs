using DVLD_BusinessLayer;
using System;

namespace DVLD.Manage_Screens
{
    public partial class frmManageDrivers : frmManageScreen
    {
        public frmManageDrivers()
        {
            InitializeComponent();
            this.btnAdd.Visible = false;
            this.cbxFilter.Visible = false;
            this.txtFilterExpressions.Visible = false;
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        protected override void RefreshDataGridView()
        {
            this._dt = clsDriver.GetAllDrivers();

            base.RefreshDataGridView();
        }
    
    }
}
