
using DVLD_DataAccessLayer;
using DVLD_DataAccessLayer.Licenses_Data;
using System;


namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense : clsLicense
    {
        public const decimal intLicenseFees = 20;
        public int intLicenseID {  get; set; }
        public int LocalLicenseID { get; set; }


        public clsInternationalLicense(clsLocalLicense license, clsApplication app)
        {
            this.intLicenseID = -1;
            this.ApplicationID = app.ApplicationID;
            this.LocalLicenseID = license.LocalLicenseID;
            this.IsActive = true;
            this.CreatedByUserID = app.CreatedByUserID;
            this.DriverID = license.DriverID;
            this.IssueDate = DateTime.Now.Date;
            this.ExpirationDate = IssueDate.AddYears(1);
            
           
        }

        public clsInternationalLicense(int intLicenseID, int localLicenseID, int applicationID, int driverID, DateTime issueDate,
        DateTime expirationDate,bool isActive, int createdByUserID) : 
            base(applicationID,driverID,issueDate,expirationDate,isActive,createdByUserID)
        {
            this.intLicenseID = intLicenseID;
            LocalLicenseID = localLicenseID;
        }


        public static clsInternationalLicense Find(int IntLicenseID)
        {
            int ApplicationID = 0, DriverID  = 0, CreatedByUserID = 0, LocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now.Date, ExpirationDate = DateTime.Now.Date;
            bool IsActive = true;
            


            if (clsInternationalLicenses_Data.GetIntLicenseInfoByID(IntLicenseID, ref LocalLicenseID, ref ApplicationID, ref DriverID,
                 ref CreatedByUserID, ref IssueDate, ref ExpirationDate, ref IsActive))
            {
                return new clsInternationalLicense(IntLicenseID,LocalLicenseID, ApplicationID, DriverID, IssueDate,
         ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }

        

        public override bool Save()
        {
            this.intLicenseID = clsInternationalLicenses_Data.AddNewIntLicense(ApplicationID, DriverID, LocalLicenseID, IssueDate, ExpirationDate,
                 IsActive, CreatedByUserID);
            return this.LocalLicenseID != -1;
        }

        public override bool Deactivate()
        {
            this.IsActive = false;
            return clsInternationalLicenses_Data.DeactivateintLicense(this.intLicenseID);
        }
    }
}
