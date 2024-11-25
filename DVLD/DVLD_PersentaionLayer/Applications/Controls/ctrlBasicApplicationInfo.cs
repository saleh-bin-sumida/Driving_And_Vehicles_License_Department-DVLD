using DVLD_BusinessLayer;
using System.ComponentModel;

namespace DVLD.MyControls
{
    public partial class ctrlBasicApplicationInfo : UserControl
    {
        clsApplication _App;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ID
        {
            get { return int.Parse(lblID.Text); }
            private set { lblID.Text = value.ToString(); }
        }

        //  public int ApplicantPersonID;

        public ctrlBasicApplicationInfo()
        {
            InitializeComponent();

        }




        public void LoadData(int AppID)
        {
            _App = clsApplication.Find(AppID);

            ID = _App.ApplicationID;
            lblStatus.Text = _App.Status();
            lblFees.Text = _App.PaidFees.ToString();
            lblType.Text = _App.TypeTitle();
            lblApplicant.Text = _App.ApplicantName();

            lblDate.Text = _App.ApplicationDate.ToString();
            lblStatusDate.Text = _App.LastStatusDate.ToString();
            lblCreatedBy.Text = _App.UserFullName();
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
            frmShowPersonInfo frm = new frmShowPersonInfo(_App.ApplicantPersonID);
            frm.ShowDialog();

        }
    }
}
