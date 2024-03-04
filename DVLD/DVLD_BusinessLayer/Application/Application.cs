using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using System;


namespace DVLD_BusinessLayer
{

    interface IApplication
    {
        bool _AddNew();
        bool _Update();
        string Status();
        bool IsNew();
        bool IsCompleted();
        bool Cancel(int ID);
        bool Delete(int ID);
        bool Save();
    }



    public class clsApplication //: IApplication
    {
        protected enum Mode { Addnew = 1, Update = 2 };
        protected Mode mode;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }



        public clsApplication()
        {
            mode = Mode.Addnew;

            this.ApplicationID = -1;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = 1;
            this.ApplicationStatus = 1; // means app is new
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }

        public clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
         byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.mode = Mode.Update;

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

        }


        public string ApplicantName() => clsApplications_Data.GetApplicantName(this.ApplicantPersonID);

        public string Status() => clsApplications_Data.GetApplicationStatus(this.ApplicationID);

        public string TypeTitle() => ApplicationTypes_Data.GetApplicationTypeName(ApplicationTypeID);

        public virtual bool MakeComplete()
        {
            return clsApplications_Data.MakeComplete(this.ApplicationID);
        }


        public string UserFullName() => clsUser_Data.GetUserFullNameByID(this.CreatedByUserID);


        public static clsApplication Find(int AppID)
        {
            int  ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0;
            byte ApplicationStatus = 0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (clsApplications_Data.GetApplicationInfoByID(AppID, ref ApplicantPersonID, ref ApplicationDate,
                ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(AppID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            return null;
        }


    }
}



