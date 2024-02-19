using DVLD_DataAccessLayer;
using System;
using System.Data;


namespace DVLD_BusinessLayer.Application
{
    public class cls_NewLDLApplication : clsApplication
    {
        public int LDL_ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public cls_NewLDLApplication() : base()
        {

            LDL_ApplicationID = -1;
            base.ApplicationTypeID = 1;
            base.PaidFees = clsApplicationType.GetApplicationTypeFees(base.ApplicationTypeID);
            this.LicenseClassID = 1;
        }

        public cls_NewLDLApplication(int lDL_ApplicationID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            short ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int licenseClassID)
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {

            this.LDL_ApplicationID = lDL_ApplicationID;
            this.LicenseClassID = licenseClassID;
        }

        private bool _AddNew()
        {
            this.LDL_ApplicationID = cls_NewLDLApplications_Data.Add_NewLDLApplication(this.ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            return this.LDL_ApplicationID != -1;
        }

        private bool _Update() => cls_NewLDLApplications_Data.Update_NewLDLApplication(this.LDL_ApplicationID,ApplicantPersonID, LicenseClassID);


        public static cls_NewLDLApplication Find(int LDL_ApplicationID)
        {
            int ApplicationID = 0, ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0, LicenseClassID = 0;
            short ApplicationStatus = 0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (cls_NewLDLApplications_Data.Get_NewLDLApplicationInfoByID(LDL_ApplicationID, ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID, ref LicenseClassID))
            {
                return new cls_NewLDLApplication(LDL_ApplicationID, ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            }
            return null;
        }


        public static DataTable GetAll_NewLDLApplications() => cls_NewLDLApplications_Data.GetAll_NewLDLApplications();



        public bool Save()
        {
            switch (mode)
            {
                case Mode.addnew:
                    mode = Mode.update;
                    return _AddNew();
                case Mode.update:
                    return _Update();
                default:
                    break;
            }
            return false;
        }
    }
}
