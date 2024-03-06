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



        public clsDriver(cls_NewLDLApplication LDLapp)
        {
            this.DriverID = -1;
            this.Person = clsPerson.FindPersonByID(LDLapp.ApplicantPersonID);
            this.CreatedDate = DateTime.Now.Date;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

     


        //public static clsDriver Find(int DriverID)
        //{
        //    DateTime CreatedDatea = DateTime.Now.Date;
        //    int CreatedByUserID = 0;

        //    clsPerson person;
        //}


        public bool Save()
        {
            this.DriverID = clsDrivers_Data.AddNewDriver(this.Person.PersonID, CreatedByUserID, CreatedDate);

            return this.DriverID != -1;
        }

        public static DataTable GetAllDrivers() => clsDrivers_Data.GetAllDrivers();
    }
}
