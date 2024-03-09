using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public clsPerson Person { get; set; }
        DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }



        public clsDriver(cls_LDLapplication LDLapp)
        {
            this.DriverID = -1;
            this.Person = clsPerson.FindPersonByID(LDLapp.ApplicantPersonID);
            this.CreatedDate = DateTime.Now.Date;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

        public clsDriver(int driverID, clsPerson person, DateTime createdDate, int createdByUserID)
        {
            DriverID = driverID;
            Person = person;
            CreatedDate = createdDate;
            CreatedByUserID = createdByUserID;
        }


        public static clsDriver Find(int DriverID)
        {
            int CreatedByUserID = 0, personID = 0;
            DateTime createdDate = DateTime.Now.Date;


            if (clsDrivers_Data.GetDriverInfoByID(DriverID, ref personID, ref createdDate, ref CreatedByUserID))
                return new clsDriver(DriverID, clsPerson.FindPersonByID(personID), createdDate, CreatedByUserID);
            else
                return null;
        }

        public bool HasActiveIntLicense() => HasActiveInternationalLicense(this.DriverID);

        public static bool HasActiveInternationalLicense(int DriverID) =>
            clsDrivers_Data.HasActiveInternationalLicense(DriverID);

        public bool Save()
        {
            this.DriverID = clsDrivers_Data.AddNewDriver(this.Person.PersonID, CreatedByUserID, CreatedDate);

            return this.DriverID != -1;
        }


        public static int GetDriverIDby(int PersonID) => clsDrivers_Data.GetDriverID(PersonID);


        public DataTable GetLocalLicenses() => clsDrivers_Data.GetLocalLicenses(DriverID);
        public DataTable GetInternationalLicenses() => clsDrivers_Data.GetInternationalLicenses(DriverID);


        public static DataTable GetAllDrivers() => clsDrivers_Data.GetAllDrivers();
    }
}
