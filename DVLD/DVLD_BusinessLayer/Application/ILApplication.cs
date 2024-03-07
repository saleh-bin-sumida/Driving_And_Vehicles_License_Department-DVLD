using System;
using DVLD_DataAccessLayer;
using System.Data;
using DVLD_DataAccessLayer.Applications_Data;


namespace DVLD_BusinessLayer.Application
{
    public class clsILApplication : clsApplication
    {
        public int ILApplicationID { get; set; }
        public int LicenseID { get; set; }

        public clsILApplication() : base() 
        {
            ILApplicationID = -1;
            LicenseID = 0;
        }


        public clsILApplication(int iLApplicationID, int licenseID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
         byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID) : base (ApplicationID,
             ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
        {

            ILApplicationID = iLApplicationID;
            LicenseID = licenseID;
       
        }


        public static DataTable GetAllILApplications() => clsILApplications_Data.GetAll_ILApplications();


    }
}
