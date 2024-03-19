using DVLD_BusinessLayer;
using System;

using System.Drawing;

using System.Windows.Forms;

namespace DVLD.MyControls
{
    public partial class ctrlDriverInternationalLicenseCard : UserControl
    {
        public ctrlDriverInternationalLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadData(int IntlicenseID)
        {
            clsInternationalLicense IntLicense = clsInternationalLicense.Find(IntlicenseID);
            clsApplication app = clsApplication.Find(IntLicense.ApplicationID);
            clsPerson person = clsPerson.FindPersonByID(app.ApplicantPersonID);


            lblName.Text = app.ApplicantName();
            lblLicenseID.Text = IntLicense.LocalLicenseID.ToString();
            lblIntLicenseID.Text = IntLicense.intLicenseID.ToString();
            lblNationalNo.Text = person.NationalNo;
            lblGender.Text = person.Gender.ToString();
            lblIssueDate.Text = IntLicense.IssueDate.ToString();
            lblApplicationID.Text = IntLicense.ApplicationID.ToString();
            _ = (IntLicense.IsActive ? lblIsActive.Text = "Yes" : lblIsActive.Text = "No");
            lblDateOfBith.Text = person.DateOfBirth.ToString();
            lblDriverID.Text = IntLicense.DriverID.ToString();
            lblExpirationDate.Text = IntLicense.ExpirationDate.ToString();


            try
            {
                pbxLicensePhoto.Image = Image.FromFile(person.ImagePath);
            }
            catch (Exception e)
            {
                _ = (person.Gender == 1 ? pbxLicensePhoto.Image = Properties.Resources.Male :
                    pbxLicensePhoto.Image = Properties.Resources.Female);
                    Util.LogError(e.Message);

            }
        }
    }
}
