using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;
using System.Data;


namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees {  get; set; }
        public bool IsActive {  get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


       

        public clsLicense(cls_NewLDLApplication LDLapp)
        {
            this.ApplicationID = LDLapp.ApplicationID;
            this.DriverID = clsDrivers_Data.GetDriverID(LDLapp.ApplicantPersonID);
            this.LicenseClassID = LDLapp.LicenseClassID;
            this.IssueDate = DateTime.Now.Date;
            this.ExpirationDate = DateTime.Now.Date.AddYears(clsLicenseClasses_Data.GetDefaultValidityLength(LicenseClassID));
            this.Notes = "";
            this.PaidFees = clsLicenseClasses_Data.GetLicenseClassFees(LicenseClassID);
            this.IsActive = true;
            this.IssueReason = 1;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }



        public clsLicense(int LicenseID, int ApplicationID, int DriverID,
                int LicenseClassID, int CreatedByUserID, DateTime IssueDate, DateTime
            ExpirationDate, string Notes, bool IsActive, byte IssueReason, decimal PaidFees)
        {
            this.LicenseID = LicenseID; 
            this.ApplicationID =ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.CreatedByUserID=CreatedByUserID;
            this.IssueDate = IssueDate;
            this.ExpirationDate=ExpirationDate;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.PaidFees=PaidFees;
        }



        public static string LicenseClassName(int LicenseClassID) => clsLicenseClasses_Data.GetLicenseClassNameByID(LicenseClassID);

        public string IssueReson()
        {
            string IssueReason = "";
            if (this.IssueReason == 1)
                IssueReason = "First Time";
            else if (this.IssueReason == 2)
                IssueReason = "Renew";
            else if (this.IssueReason == 3)
                IssueReason = "Replacment For Damage Or lost";

            return IssueReason;
        }


        public bool IsDetained() => clsLicenses_Data.IsLicenseDetained(LicenseID);


        public static int GetLicenseIDbyLDLappID(int LDLappID) => clsLicenses_Data.GetLicenseIDbyLDLappID(LDLappID);

        public static DataTable GetAllLicenseClasses() => clsLicenseClasses_Data.GetAllLicenseClasses();

        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = 0, DriverID = 0, LicenseClassID = 0, CreatedByUserID = 0;
            DateTime IssueDate = DateTime.Now.Date, ExpirationDate = DateTime.Now.Date;
            string Notes = ""; decimal PaidFees = 0.00m;
            bool IsActive = false;
            byte IssueReason = 1;



            if (clsLicenses_Data.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID,
                ref LicenseClassID, ref CreatedByUserID, ref IssueDate, ref ExpirationDate, ref Notes,ref IsActive,ref IssueReason,ref PaidFees))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID,
                LicenseClassID, CreatedByUserID, IssueDate, ExpirationDate, Notes,IsActive,IssueReason,PaidFees);
            }
            return null;
        }



        public bool Save()
        {
            this.LicenseID = clsLicenses_Data.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate,
                Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return this.LicenseID != -1;
        }

    }
}
