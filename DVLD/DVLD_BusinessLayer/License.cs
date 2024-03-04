using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class License
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
        public byte IssueResson { get; set; }
        public int CreatedByUserID { get; set; }

        public License(cls_NewLDLApplication LDLapp)
        {
            this.ApplicationID = LDLapp.ApplicationID;
            this.DriverID = LDLapp.ApplicantPersonID;
            this.LicenseClassID = LDLapp.LicenseClassID;
            this.IssueDate = DateTime.Now.Date;
            this.ExpirationDate = DateTime.Now.Date.AddYears(clsLicenseClasses_Data.GetDefaultValidityLength(LicenseClassID));
            this.Notes = "";
            this.PaidFees = clsLicenseClasses_Data.GetClassFees(LicenseClassID);
            IsActive = true;
            IssueResson = 1;
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

        public bool Save()
        {
            clsli
        }

    }
}
