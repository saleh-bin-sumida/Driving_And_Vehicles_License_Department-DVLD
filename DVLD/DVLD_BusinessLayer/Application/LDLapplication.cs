using DVLD_DataAccessLayer;
using DVLD_DataAccessLayer.Tests_Data;
using System;
using System.Data;
using System.Reflection.Emit;


namespace DVLD_BusinessLayer.Application
{
    public class cls_LDLapplication : clsApplication //, IApplication
    {
        public int LDL_ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

      


        public cls_LDLapplication() : base()
        {
            LDL_ApplicationID = -1;
            base.ApplicationTypeID = 1;
            base.PaidFees = TypeFees();
            this.LicenseClassID = 3;

        }



        public cls_LDLapplication(int lDL_ApplicationID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int licenseClassID)
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {

            this.LDL_ApplicationID = lDL_ApplicationID;
            this.LicenseClassID = licenseClassID;
        }




        public int GetPassedTests() => cls_LDLapplications_Data.GetPassedTestsForLDLapp(LDL_ApplicationID);    


        private bool _AddNew()
        {
            this.LDL_ApplicationID = cls_LDLapplications_Data.Add_NewLDLApplication(this.ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            return this.LDL_ApplicationID != -1;
        }


        private bool _Update() => cls_LDLapplications_Data.Update_NewLDLApplication(this.LDL_ApplicationID,ApplicantPersonID, LicenseClassID);


        public bool LinkedwithLicense() => clsApplications_Data.ApplicationLikedWithLicense(this.ApplicationID) ;


        public override bool MakeComplete()
        {
            clsDriver driver = new clsDriver(this);
            driver.Save();
            return base.MakeComplete();
        }


        public static bool Cancel(int LDLappID) => cls_LDLapplications_Data.Cancel_NewLDLApplication(LDLappID);

        public int Trial(int TestTypeID) => cls_LDLapplications_Data.GetTrial(this.LDL_ApplicationID, TestTypeID);



        public static bool Delete(int LDLappID) => cls_LDLapplications_Data.Delete_NewLDLApplication(LDLappID);


        public  static  new cls_LDLapplication  Find(int LDL_ApplicationID)
        {
            int ApplicationID = 0, ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0, LicenseClassID = 0;
            byte ApplicationStatus = 0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (cls_LDLapplications_Data.Get_NewLDLApplicationInfoByID(LDL_ApplicationID, ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID, ref LicenseClassID))
            {
                return new cls_LDLapplication(LDL_ApplicationID, ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, LicenseClassID);
            }
            return null;
        }


        public static DataTable GetAll_NewLDLApplications() => cls_LDLapplications_Data.GetAll_NewLDLApplications();

        public bool AllowedToCreateAppointment(int TestType, ref string ErrorMessage)
        {

            return clsTestsAppointments_Data.AllowedToCreateAppointment(LDL_ApplicationID, TestType , ref ErrorMessage);

        }


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
