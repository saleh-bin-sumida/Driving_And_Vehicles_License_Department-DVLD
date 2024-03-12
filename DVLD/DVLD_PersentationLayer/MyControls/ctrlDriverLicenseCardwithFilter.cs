using DVLD_BusinessLayer;
using System;
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
            _LicenseID = -1;
        }

        private void ClearData()
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtLicenseId.Text == "")
            {

                MessageBox.Show("Licesen with this ID not found!");
                ctrlDriverLicenseCard1.ClearData();
                _LicenseID = -1;
                OnLicenseSelected?.Invoke(_LicenseID);
                return;
            }

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

        public void Select(int LicenseID)
        {
            object o = new object();
            EventArgs e = new EventArgs();
            txtLicenseId.Text = LicenseID.ToString();
            _LicenseID = LicenseID;
            btnSelect_Click(o,e);
        }

        public void DisableFilter()
        {
            gbxPersonFilter.Enabled = false;
        }
    }
}
