using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;
using System.Data;


namespace DVLD_BusinessLayer
{
    public class clsLocalLicense : clsLicense
    {
        public int LocalLicenseID { get; set; }

        public int LicenseClassID { get; set; }

        public string Notes { get; set; }

        public decimal PaidFees { get; set; }   

        public byte IssueReason { get; set; }

        public clsLocalLicense(cls_LDLapplication LDLapp)
        {
            this.LocalLicenseID = -1;
            this.ApplicationID = LDLapp.ApplicationID;
            this.DriverID = clsDriver.GetDriverIDby(LDLapp.ApplicantPersonID);

            this.LicenseClassID = LDLapp.LicenseClassID;
            this.IssueDate = DateTime.Now.Date;
            this.ExpirationDate = DateTime.Now.Date.AddYears(GetDefaultValidityLength(LicenseClassID));
            this.Notes = "";
            this.PaidFees = clsLocalLicense.LicenseClassFees(LDLapp.LicenseClassID);
            this.IsActive = true;
            this.IssueReason = 1;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

        public clsLocalLicense()
        {
            this.LocalLicenseID = -1;
        }

        public clsLocalLicense(int localLicenseID, int licenseClassID, string notes,
        decimal paidFees, byte issueReason, int applicationID, int driverID, DateTime issueDate,
        DateTime expirationDate, bool IsActive
        , int createdByUserID) : base(applicationID,driverID,issueDate,expirationDate,IsActive,createdByUserID)
        {
          
            LocalLicenseID = localLicenseID;
            LicenseClassID = licenseClassID;
            Notes = notes;
            PaidFees = paidFees;
            IssueReason = issueReason;
        }

        public static string LicenseClassName(int LicenseClassID) => clsLicenseClasses_Data.GetLicenseClassNameByID(LicenseClassID);

        public static decimal LicenseClassFees(int LicenseClassID) => clsLicenseClasses_Data.GetLicenseClassFees(LicenseClassID);


        public string IssueReson()
        {
            string IssueReason = "";
            if (this.IssueReason == 1)
                IssueReason = "First Time";
            else if (this.IssueReason == 2)
                IssueReason = "Renew License";
            else if (this.IssueReason == 3)
                IssueReason = "Replacment For Damaged";
            else if (this.IssueReason == 4)
                IssueReason = "Replacment For Lost";

            return IssueReason;
        }


        public bool IsDetained() => clsLocalLicenses_Data.IsLicenseDetained(LocalLicenseID);

        public int Detain(decimal FineFees) => clsLocalLicenses_Data.DetainLicense(LocalLicenseID,FineFees, GlobalSettings.CurrentUser.UserID);

        public static bool ReleaseLicense(int DetainID, int ReleaseAppID) => 
            clsLocalLicenses_Data.ReleaseLicense(DetainID, GlobalSettings.CurrentUser.UserID, ReleaseAppID);


        public static byte GetDefaultValidityLength(int LicenseClassID) => clsLicenseClasses_Data.GetDefaultValidityLength(LicenseClassID);
        public static int GetLicenseIDbyLDLappID(int LDLappID) => clsLocalLicenses_Data.GetLicenseIDbyLDLappID(LDLappID);

        public static DataTable GetAllLicenseClasses() => clsLicenseClasses_Data.GetAllLicenseClasses();

        public static clsLocalLicense Find(int LocalLicenseID)
        {
            int ApplicationID = 0, DriverID = 0, LicenseClassID = 0, CreatedByUserID = 0;
            DateTime IssueDate = DateTime.Now.Date, ExpirationDate = DateTime.Now.Date;
            string Notes = ""; decimal PaidFees = 0.00m;
            bool IsActive = false;
            byte IssueReason = 1;



            if (clsLocalLicenses_Data.GetLicenseInfoByID(LocalLicenseID, ref ApplicationID, ref DriverID,
                ref LicenseClassID, ref CreatedByUserID, ref IssueDate, ref ExpirationDate, ref Notes,ref IsActive,ref IssueReason,ref PaidFees))
            {
                return new clsLocalLicense( LocalLicenseID,  LicenseClassID,  Notes,PaidFees,  IssueReason,  ApplicationID,  DriverID,  IssueDate,
         ExpirationDate,  IsActive ,  CreatedByUserID);
            }
            return null;
        }





        public override bool Save()
        {
            this.LocalLicenseID = clsLocalLicenses_Data.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate,
                Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return this.LocalLicenseID != -1;
        }

        public override bool Deactivate()
        {
            this.IsActive = false;
            return clsLocalLicenses_Data.DeactivateLocalLicense(this.LocalLicenseID);
        }

        public struct DetainInfo
        {
            public int DetainID ;
            public decimal FineFees;
            public DateTime DetainDate;
            public int DetainedBy;

            public DetainInfo(int LicenseId)
            {
                DetainID = 0;
                FineFees = 0;
                DetainDate = DateTime.Now.Date;
                DetainedBy = 0;

                FillData(LicenseId);
            }

            public bool FillData(int LicenseID) => clsLocalLicenses_Data.GetLicenseDetainInfo( LicenseID, ref DetainID,ref FineFees,ref DetainDate, ref DetainedBy);
        }

        public static DataTable GetAllDetainedLicenses() => clsLocalLicenses_Data.GetAllDetainedLicenses();

    }
}
