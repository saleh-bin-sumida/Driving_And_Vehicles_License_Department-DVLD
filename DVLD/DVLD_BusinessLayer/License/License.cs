using DVLD_DataAccessLayer;
using System;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;


namespace DVLD_BusinessLayer
{
    public abstract class clsLicense
    {
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
                
        }

        public clsLicense(int applicationID, int driverID, DateTime issueDate, DateTime expirationDate
        , bool isActive, int createdByUserID)
        {
            ApplicationID = applicationID;
            DriverID = driverID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }

        public virtual bool IsLicenseActive() => ( _ = (DateTime.Now.Date < this.ExpirationDate) ? true : false) && IsActive;

        public abstract bool Save();
        public abstract bool Deactivate();

    }
}
