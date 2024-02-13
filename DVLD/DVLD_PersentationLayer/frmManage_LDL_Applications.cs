using System;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class frmManage_LDL_Applications : Form1
    {
        public frmManage_LDL_Applications()
        {
            InitializeComponent();
            this.InitializeComponent();
        }

        private void frmManage_LDL_Applications_Load(object sender, EventArgs e)
        {
            cbxFilter.DataSource = new string[] { "LDLapp ID", "National No" }; 
            lblHeading.Text = "Manage Local Driving License Applications";
            this.DataGridView.DataSource = cls_LDL_Application.GetAll_LDL_Applications();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdate_LDL_Application frm = new frmAddUpdate_LDL_Application(-1);
            frm.ShowDialog();
        }
    }
}
