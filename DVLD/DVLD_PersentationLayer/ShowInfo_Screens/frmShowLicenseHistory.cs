using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowLicenseHistory : Form
    {
        clsDriver Driver;

        public frmShowLicenseHistory(int DriverID)
        {
            InitializeComponent();
            Driver = clsDriver.Find(DriverID);
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonCardwithFilter1._LoadPersonCardwithFilterData(Driver.Person.PersonID);
            ctrlPersonCardwithFilter1.DisableFilter();
            Load_LocalLicenses();
            Load_InternationalLicenses();
           
            
        }

        private void Load_LocalLicenses()
        {
            dgvLocalLicenses.DataSource = Driver.GetLocalLicenses();
            lblTotalLocalLicenses.Text = dgvLocalLicenses.Rows.Count.ToString();
        }

        private void Load_InternationalLicenses()
        {
            dgvIntLicenses.DataSource = Driver.GetInternationalLicenses();
            lblTotalIntLicenses.Text = dgvIntLicenses.Rows.Count.ToString();
        }
    }
}
