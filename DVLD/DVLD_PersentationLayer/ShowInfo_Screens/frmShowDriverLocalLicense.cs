using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowDriverLocalLicense : Form
    {
        int _LicenseID;
        public frmShowDriverLocalLicense(int LDLappID)
        {
            InitializeComponent();
            _LicenseID = clsLocalLicense.GetLicenseIDbyLDLappID(LDLappID);

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frmShowDriverLicense_Load(object sender, EventArgs e)
        {
           ctrlDriverLicenseCard1.LoadData(_LicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
