using System;


namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        protected  enum Mode { addnew= 1, update = 2};
        protected Mode mode;
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
            this.ApplicationTypeID = 1;
            this.ApplicationStatus = 1; // means app is new
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
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }


      
    }


}
