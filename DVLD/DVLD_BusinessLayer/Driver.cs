using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;

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

        private bool _Add()
        {
           this.DriverID =  Drivers_Data.AddNewDriver(this.Person.PersonID,CreatedByUserID, CreatedDate);

            return this.DriverID != -1;
        }



        public static clsDriver Find(int DriverID)
        {
            DateTime CreatedDatea = DateTime.Now.Date;
            int CreatedByUserID = 0;

            clsPerson person;
        }


        public bool Save()
        {
            return _Add();
        }
    }
}
