using System;
using System.Data;
using DVLD_BusinessLayer.Application;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManage_NewLDLApplications : frmManageScreen
    {
       // private DataTable _dt;
        public frmManage_NewLDLApplications() : base()
        {
  
            InitializeComponent();
        }

        private void frmManage_NewLDLApplications_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            RefreshDataGridView();
            
        }

        protected override void RefreshDataGridView()
        {
            _dt = cls_NewLDLApplication.GetAll_NewLDLApplications();
            base.RefreshDataGridView();
        }
  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdate_NewLDLApplication frm = new frmAddUpdate_NewLDLApplication(-1);
            frm.ShowDialog();

            RefreshDataGridView();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        { 
            base.cbxFilter_SelectedIndexChanged();
        }


       
    }
}
