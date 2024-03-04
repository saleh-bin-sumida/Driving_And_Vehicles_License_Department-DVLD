using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; }
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

        private bool _Add() => DVLD_DataAccessLayer.Drivers_Data.AddNewDriver(this.Person.PersonID,CreatedByUserID, CreatedDate);
    }
}
