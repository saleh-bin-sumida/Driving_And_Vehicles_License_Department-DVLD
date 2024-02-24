using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsApplicationType
    {

        public  int ApplicationTypeID { get;}  
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationTypeFees { get; set; }


        public clsApplicationType(int ApplicationTypeID, string applicationTitle, decimal applicationTypeFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = applicationTitle;
            this.ApplicationTypeFees = applicationTypeFees;

        }

        public static DataTable GetAllApplicationsTypes() => ApplicationTypes_Data.GetAllApplicationTypes();


        public static clsApplicationType GetApplicationTypeInfoByID(int ApplicationTypeID)
        {
            string ApplicationTypeTitle ="";
            decimal ApplicationTypeFees = 0.0m;
            ApplicationTypes_Data.GetApplicationTypeInfo(ApplicationTypeID, ref ApplicationTypeTitle,ref ApplicationTypeFees);

            return new clsApplicationType(ApplicationTypeID,ApplicationTypeTitle,ApplicationTypeFees);  

        }

        // this method is referenced by dynamic object
        public bool Update()  => ApplicationTypes_Data.UpdateApplicationType(ApplicationTypeID,ApplicationTypeTitle,ApplicationTypeFees);

        public static decimal GetApplicationTypeFees(int ApplicationTypeID) => ApplicationTypes_Data.GetApplicationTypeFees(ApplicationTypeID);

    }
}
