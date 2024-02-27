using System;
using DVLD_DataAccessLayer.Tests_Data;
namespace DVLD_BusinessLayer.Test
{
    public class TestAppointment
    {
        enum Mode { Addnew = 1 , Update =2 }
        Mode mode;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public TestAppointment() 
        {
            mode = Mode.Addnew;

            TestAppointmentID = -1;
            TestTypeID = 1;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = this.Fees();
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
            IsLocked = false;

        }

        public TestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID , bool IsLocked)
        {
            mode = Mode.Update;

            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
        }

        protected string TypeName() => clsTestTypes_Data.GetTestTypeName(this.TestTypeID);
        protected decimal Fees() => clsTestTypes_Data.GetTestTypeFees(this.TestTypeID);

        public bool _SchduleTestAppointments(ref string ErrorMessage)
        {
            
            if (!clsTestsAppointments_Data.AllowedToCreateAppointment(this.LocalDrivingLicenseApplicationID, TestTypeID, ref ErrorMessage))
                return false;

            this.TestAppointmentID = clsTestsAppointments_Data.AddTestAppointment(LocalDrivingLicenseApplicationID,
                TestTypeID, AppointmentDate, PaidFees, IsLocked, CreatedByUserID);
            return this.TestAppointmentID != -1;
        }

    }
}
