using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using DVLD_DataAccessLayer;
using static DVLD_BusinessLayer.clsPerson;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        public  enum Mode { addnew= 1, update = 2};
        public Mode mode;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }   

        public short ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        
        public clsApplication()
        {
            mode = Mode.addnew;

            this.ApplicationID = -1;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

        public clsApplication( int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
         short ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.mode = Mode.update;

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.CreatedByUserID = CreatedByUserID;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
        }


        //public static clsApplication Find(int ApplicationID)
        //{
        //    return clsApplications_Data.GetApplicationInfoByID(ApplicationID);
        //}
    }

    public class cls_LDL_Application : clsApplication
    {
        public int LDL_ApplicationID { get; set; }  
        public int LicenseClassID { get; set; }


        public cls_LDL_Application() : base()
        {

            LDL_ApplicationID = -1;
            base.ApplicationTypeID = 1;
            base.PaidFees = clsApplicationType.GetApplicationTypeFees(base.ApplicationTypeID);
            this.LicenseClassID = 0;
        }

        public cls_LDL_Application(int lDL_ApplicationID,int ApplicationID,int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,
            short ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int licenseClassID)
            : base(ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
        {

            this.LDL_ApplicationID = lDL_ApplicationID;
            this.LicenseClassID = licenseClassID;
        }

        private bool _AddNew()
        {
            this.LDL_ApplicationID = clsLDL_Applications_Data.AddNew_LDL_Application(this.ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            return this.LDL_ApplicationID != -1;
        }

        private bool _Update() =>
            clsLDL_Applications_Data.Update_LDL_Application(this.LDL_ApplicationID, ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);


        public static cls_LDL_Application Find(int LDL_ApplicationID)
        {
            int ApplicationID =0, ApplicantPersonID =0 , ApplicationTypeID = 0, CreatedByUserID = 0,LicenseClassID=0;
            short ApplicationStatus = 0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (clsLDL_Applications_Data.Get_LDL_ApplicationInfoByID(LDL_ApplicationID,ref ApplicationID,ref ApplicantPersonID,ref ApplicationDate,
                ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID, ref LicenseClassID))
            {
                return new cls_LDL_Application(LDL_ApplicationID, ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            }
            return null;
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.addnew:
                    mode = Mode.update;
                    return  _AddNew();
                case Mode.update:
                    return _Update();
                default:
                    break;
            }
            return false;
        }
    }
}
