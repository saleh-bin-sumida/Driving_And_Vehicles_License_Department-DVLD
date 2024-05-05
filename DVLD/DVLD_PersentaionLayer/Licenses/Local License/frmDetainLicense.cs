using DVLD.ShowInfo_Screens;
using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenes_Applications
{
    public partial class frmDetainLicense : frmLicenseServiceScreen
    {
        clsLocalLicense License;
        public frmDetainLicense() : base()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            lblDetainDate.Text = DateTime.Now.Date.ToString();
            lblCreatedBy.Text = GlobalSettings.CurrentUser.UserID.ToString();

            btn.Enabled = false;
            linklabel_licsneHistroy.Enabled = false;
            linklabel_NewLicense.Enabled = false;

        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrlDriverLicenseCardwithFilter1_OnLicenseSelected(int obj)
        {
            
            License = clsLocalLicense.Find(ctrlDriverLicenseCardwithFilter1.LicenseID);
            lblLicenseID.Text = License.LocalLicenseID.ToString();

            linklabel_licsneHistroy.Enabled = true;
            btn.Enabled = true;
                
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (License.IsDetained()) 
            {
                MessageBox.Show("this license already detained!");
                return;
            }

            if (!License.IsLicenseActive())
            {
                MessageBox.Show("this license isnt Active, cant detain inactive licenses !");
                return;
            }


            int DetainID = License.Detain(nudValue.Value);

            if (DetainID != -1)
            {
                lblDetainID.Text = DetainID.ToString();
                linklabel_NewLicense.Enabled = true;
                MessageBox.Show("this License Detained Succesfully");

                ctrlDriverLicenseCardwithFilter1.Select(License.LocalLicenseID);
                btn.Enabled = false;
                return;

            }
            MessageBox.Show("falid to detain this License!!");


        }



        private void linklabel_licsneHistroy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory(License.DriverID);
        }

        private void linklabel_NewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocallicenseInfo(License.LocalLicenseID);
        }
    }
}
