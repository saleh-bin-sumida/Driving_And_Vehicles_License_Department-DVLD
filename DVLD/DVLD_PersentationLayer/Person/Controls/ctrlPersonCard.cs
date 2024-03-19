using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        public string PersonID { get { return _PersonIDValue.Text; } private set { this._PersonIDValue.Text = value.ToString(); } }
        public string NationalNo { get { return _NationalNo.Text; }private set { this._NationalNo.Text = value; } }
        public string FullName { get { return _FullName.Text; }private set { this._FullName.Text = value; } }


        public string Gender { get { return _Gender.Text; }private set { this._Gender.Text = value; } }
        public string DateOfBirth { get { return _DateOfBirth.Text; }private set { this._DateOfBirth.Text = value; } }
        public string Phone { get { return _Phone.Text; }private set { this._Phone.Text = value; } }
        public string Email { get { return _Email.Text; }private set { this._Email.Text = value; } }

        public string Country { get { return _Country.Text; }private set { this._Country.Text = value; } }

        public string Address { get { return _Address.Text; } private set { this._Address.Text = value; } }

        

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            PersonID = "";
            NationalNo = "";
            FullName = "";
            DateOfBirth = "";
            Gender = "";
            Phone = "";
            Email = "";
            Address = "";
            Country = "";
            this._pictureBox1.Image = Properties.Resources.Male;
        }

        public void LoadData(clsPerson Person)
        {
            if (Person == null)
            {
                this.Clear();
                return;
            }

            PersonID = Person.PersonID.ToString();
            FullName = Person.FirstName +" "+ Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            NationalNo = Person.NationalNo;
            if (Person.Gender == 1)
                Gender = "Male";
            else
                Gender = "Female";
            Email = Person.Email;
            Address = Person.Address;
            DateOfBirth = Person.DateOfBirth.ToString();
            Phone = Person.Phone;
            Country = clsCountry.GetCountryNameByID( Person.NationalityCountryID);

            try
            {

                this._pictureBox1.Image = Image.FromFile(Person.ImagePath);
            }
            catch (Exception e  )
            {

                if (this.Gender == "Male")
                    _pictureBox1.Image = DVLD.Properties.Resources.Male;
                else
                    _pictureBox1.Image = DVLD.Properties.Resources.Female;
                GlobalSettings.LogError(e.Message);

            }
        }

        private void _LoadDataByPersonID(int PersonID)
        {
            LoadData(clsPerson.FindPersonByID(PersonID));
        }

        private void LinkLabelEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personID = int.Parse(PersonID);
            frmAddUpdatePerson frm = new frmAddUpdatePerson(personID);
            frm.SendDataBack += _LoadDataByPersonID;
            frm.ShowDialog();
            
        }



     
    }
}
