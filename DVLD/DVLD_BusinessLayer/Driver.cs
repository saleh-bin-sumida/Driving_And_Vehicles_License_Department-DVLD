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



        public bool Save()
        {
            this.DriverID = clsDrivers_Data.AddNewDriver(this.Person.PersonID, CreatedByUserID, CreatedDate);

            return this.DriverID != -1;
        }

        public static DataTable GetAllDrivers() => clsDrivers_Data.GetAllDrivers();
    }
}
