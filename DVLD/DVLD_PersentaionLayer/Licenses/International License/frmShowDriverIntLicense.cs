using System;
using System.Windows.Forms;

namespace DVLD.ShowInfo_Screens
{
    public partial class frmShowDriverIntLicense : Form
    {
        int _IntLicenseID;
        public frmShowDriverIntLicense(int IntLicenseID)
        {
            InitializeComponent();
            _IntLicenseID = IntLicenseID;
        }

        private void frmShowDriverIntLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseCard1.LoadData(_IntLicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
