using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.MyControls
{
    public partial class ctrlBasicApplicationInfo : UserControl
    {
        clsApplication App;

        public int ID
        {
            get { return int.Parse(lblID.Text); }
            set { lblID.Text = value.ToString(); }
        }

        public ctrlBasicApplicationInfo( )
        {
            InitializeComponent();
         
        }

       
      

        public void LoadData(clsApplication App)
        {
            ID = App.ApplicationID;
            lblStatus.Text = App.Status();
            lblFees.Text = App.PaidFees.ToString();
            lblType.Text = App.TypeTitle();
            lblApplicant.Text = App.ApplicantName();

            lblDate.Text = App.ApplicationDate.ToString();
            lblStatusDate.Text = App.LastStatusDate.ToString();
        }

        private void Clear()
        {
            ID = 0;
            lblStatus.Text = "";
            lblFees.Text = "";
            lblType.Text = "";
            lblApplicant.Text = "";

            lblDate.Text = "";
            lblStatusDate.Text = "";
        }

        private void linkLabelViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(App.ApplicantPersonID);
            frm.ShowDialog();

        }
    }
}
