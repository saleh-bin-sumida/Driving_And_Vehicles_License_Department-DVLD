using System;
using System.Data;
using DVLD_DataAccessLayer.Tests_Data;
namespace DVLD_BusinessLayer.Test
{
    public class clsTestAppointment
    {
        enum Mode { Addnew = 1 , Update =2 }
        Mode mode;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LDL_ApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointment() 
        {
            mode = Mode.Addnew;

            TestAppointmentID = -1;
            TestTypeID = 1;
            LDL_ApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = this.Fees();
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
            IsLocked = false;

        }

        public clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID , bool IsLocked)
        {
            mode = Mode.Update;

            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDL_ApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
        }

        protected string TypeName() => clsTestTypes_Data.GetTestTypeName(this.TestTypeID);
        protected decimal Fees() => clsTestTypes_Data.GetTestTypeFees(this.TestTypeID);



        public bool _SchduleTestAppointments()
        {
            


            this.TestAppointmentID = clsTestsAppointments_Data.AddTestAppointment(LDL_ApplicationID,
                TestTypeID, AppointmentDate, PaidFees, IsLocked, CreatedByUserID);
            return this.TestAppointmentID != -1;
        }





        public static DataTable GetAllTestAppointments(int LDLappID, int TestTypeID) => clsTestsAppointments_Data.GetAllTestAppointments(LDLappID, TestTypeID);

    }
}
