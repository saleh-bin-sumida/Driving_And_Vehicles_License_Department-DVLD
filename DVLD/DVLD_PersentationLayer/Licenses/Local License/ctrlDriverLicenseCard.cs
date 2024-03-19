using DVLD_BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.MyControls
{
    public partial class ctrlDriverLicenseCard : UserControl
    {
        public ctrlDriverLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadData(int  licenseID)
        {
            clsLocalLicense License = clsLocalLicense.Find(licenseID);
            clsApplication app = clsApplication.Find(License.ApplicationID);
            clsPerson person = clsPerson.FindPersonByID(app.ApplicantPersonID);


            lblClassName.Text = clsLocalLicense.LicenseClassName(License.LicenseClassID);
            lblName.Text = app.ApplicantName();
            lblLicenseID.Text = License.LocalLicenseID.ToString();
            lblNationalNo.Text = person.NationalNo;
            lblGender.Text = person.Gender.ToString();    
            lblIssueDate.Text = License.IssueDate.ToString();
            lblIssueReason.Text = License.IssueReson();
            lblNotes.Text = License.Notes;
            _ = (License.IsActive ? lblIsActive.Text = "Yes" : lblIsActive.Text = "No");
            lblDateOfBith.Text = person.DateOfBirth.ToString();
            lblDriverID.Text = License.DriverID.ToString();
            lblExpirationDate.Text = License.ExpirationDate.ToString();
            _ = (License.IsDetained() ? lblIsDetained.Text = "Yes" : lblIsDetained.Text = "No");

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

        public void ClearData()
        {

            lblClassName.Text = "";
            lblName.Text = "";
            lblLicenseID.Text = "";
            lblNationalNo.Text = "";
            lblGender.Text = "";
            lblIssueDate.Text = "";
            lblIssueReason.Text = "";
            lblNotes.Text = "";
            lblIsActive.Text = "";
            lblDateOfBith.Text = "";
            lblDriverID.Text = "";
            lblExpirationDate.Text = "";
            lblIsDetained.Text = "";
            pbxLicensePhoto.Image = Properties.Resources.Male;
        }
    }
}
