
using DVLD_DataAccessLayer.Licenses_Data;
using System;


namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense : clsLicense
    {
        public const decimal intLicenseFees = 20;
        public int intLicenseID {  get; set; }
        public int LocalLicenseID { get; set; }


        public clsInternationalLicense(int intLicenseID, int localLicenseID, int applicationID, int driverID, DateTime issueDate,
        DateTime expirationDate,bool isActive, int createdByUserID) : 
            base(applicationID,driverID,issueDate,expirationDate,isActive,createdByUserID)
        {
            this.intLicenseID = intLicenseID;
            LocalLicenseID = localLicenseID;
        }


        public static clsInternationalLicense Find(int IntLicenseID)
        {
            int ApplicationID = 0, DriverID  = 0, CreatedByUserID = 0, LocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now.Date, ExpirationDate = DateTime.Now.Date;
            bool IsActive = false;
            


            if (InternationalLicenses_Data.GetIntLicenseInfoByID(IntLicenseID, ref LocalLicenseID, ref ApplicationID, ref DriverID,
                 ref CreatedByUserID, ref IssueDate, ref ExpirationDate, ref IsActive))
            {
                return new clsInternationalLicense(IntLicenseID,LocalLicenseID, ApplicationID, DriverID, IssueDate,
         ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }


    }
}
