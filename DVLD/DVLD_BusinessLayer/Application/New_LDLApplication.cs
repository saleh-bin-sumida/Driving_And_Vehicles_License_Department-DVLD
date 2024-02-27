using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;


namespace DVLD_BusinessLayer.Application
{
    public class cls_NewLDLApplication : clsApplication //, IApplication
    {
        public int LDL_ApplicationID { get; set; }
        public int LicenseClassID { get; set; }





        public cls_NewLDLApplication() : base()
        {
            LDL_ApplicationID = -1;
            base.ApplicationTypeID = 1;
            base.PaidFees = clsApplicationType.GetApplicationTypeFees(base.ApplicationTypeID);
            this.LicenseClassID = 3;
        }





        public cls_NewLDLApplication(int lDL_ApplicationID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int licenseClassID)
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {

            this.LDL_ApplicationID = lDL_ApplicationID;
            this.LicenseClassID = licenseClassID;
        }




        public string GetLicenseClassNameByID() => cls_NewLDLApplications_Data.GetLicenseClassNameByID(LicenseClassID);

        public int GetPassedTests() => cls_NewLDLApplications_Data.GetPassedTestsForLDLapp(LDL_ApplicationID);    

        private bool _AddNew()
        {
            this.LDL_ApplicationID = cls_NewLDLApplications_Data.Add_NewLDLApplication(this.ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            return this.LDL_ApplicationID != -1;
        }


        private bool _Update() => cls_NewLDLApplications_Data.Update_NewLDLApplication(this.LDL_ApplicationID,ApplicantPersonID, LicenseClassID);


        public  bool LikedwithLicense() => clsApplications_Data.ApplicationLikedWithLicense(this.ApplicationID) ;


        public static bool isLDLappHasActiveTestAppointment(int LDLappID, int TestTypeID) => cls_NewLDLApplications_Data.isLDLappHasActiveTestAppointment(LDLappID, TestTypeID);

        public static bool Cancel(int LDLappID) => cls_NewLDLApplications_Data.Cancel_NewLDLApplication(LDLappID);



        public static bool Delete(int LDLappID) => cls_NewLDLApplications_Data.Delete_NewLDLApplication(LDLappID);


        public  static  new cls_NewLDLApplication  Find(int LDL_ApplicationID)
        {
            int ApplicationID = 0, ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0, LicenseClassID = 0;
            byte ApplicationStatus = 0;
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
                case Mode.Addnew:
                    mode = Mode.Update;
                    return _AddNew();

                case Mode.Update:   
                    return _Update();

                default:
                    break;
            }
            return false;
        }
    }
}
