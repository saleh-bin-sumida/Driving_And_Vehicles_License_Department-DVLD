using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        protected enum Mode { AddNew = 0, Update = 1 }
        protected Mode mode;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        public clsPerson()
        {
            mode = Mode.AddNew;

            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 191;
            this.ImagePath = "";

        }

        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            this.mode = Mode.Update;

            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
        }


        private bool _AddPerson()
        {
            this.PersonID = clsPerson_Data.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return this.PersonID != -1;
        }

        private bool _UpdatePerson() => clsPerson_Data.UpdatePerson(PersonID,NationalNo,FirstName,SecondName,
            ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath);
            

        public static bool DeletePerson(int PersonID) => clsPerson_Data.DeletePerson(PersonID);
        

        public static clsPerson FindPersonByID(int PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                Address = "", Phone = "", Email = "", ImagePath = "";

            byte Gender = 1;
            int NationalityCountryID = 191;
            DateTime DateOfBirth = DateTime.Now;


            if (clsPerson_Data.GetPersonInfoByID(PersonID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,
                ref DateOfBirth ,ref Gender,ref Address,ref Phone,ref Email,ref NationalityCountryID,ref ImagePath))

                return new clsPerson(PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,
                    Gender,Address,Phone,Email,NationalityCountryID,ImagePath);
            else
                return null;
        }


        public static clsPerson FindPersonByNationalNo(string NationalNo)
        {
            int PersonID = 0;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                Address = "", Phone = "", Email = "", ImagePath = "";

            byte Gender = 1;
            int NationalityCountryID = 191;
            DateTime DateOfBirth = DateTime.Now;


            if (clsPerson_Data.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }


        public static DataTable GetAllPersons() => clsPerson_Data.GetAllPersons();


        public static bool IsPersonExists(string NationalNo) => clsPerson_Data.IsPersonExists(NationalNo);

        public static bool IsPersonExists(int PersonID) => clsPerson_Data.IsPersonExists(PersonID);


        public static bool IsPersonLikedWithUser(int PersonID) => clsPerson_Data.IsPersonLikedWithUser(PersonID);



        public bool Save()
        {
            switch (this.mode)
            {
                case Mode.AddNew:
                    return _AddPerson();
                case Mode.Update:
                    return _UpdatePerson();

            }

            return false;
        }
    
    }
}
