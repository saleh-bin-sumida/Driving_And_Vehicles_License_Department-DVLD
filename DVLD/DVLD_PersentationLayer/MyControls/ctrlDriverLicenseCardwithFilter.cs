using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.MyControls
{
    public partial class ctrlDriverLicenseCardwithFilter : UserControl
    {
        int _LicenseID;

        public int LicenseID { get { return _LicenseID; } }

        clsLocalLicense _LocalLicense;
        public event Action<int> OnLicenseSelected;
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }
        public ctrlDriverLicenseCardwithFilter()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _LicenseID = int.Parse(txtLicenseId.Text);

            _LocalLicense = clsLocalLicense.Find(_LicenseID);

            if (_LocalLicense == null)
            {
                MessageBox.Show("Licesen with this ID not found!");
                return;
            }

            ctrlDriverLicenseCard1.LoadData(_LicenseID);

            OnLicenseSelected?.Invoke(_LicenseID);
        }
    }
}
