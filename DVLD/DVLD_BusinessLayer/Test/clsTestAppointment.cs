using System;
using System.Data;
using DVLD_BusinessLayer.Application;
using DVLD_DataAccessLayer;
using DVLD_DataAccessLayer.Tests_Data;
namespace DVLD_BusinessLayer.Test
{
    public class clsTestAppointment
    {
        enum Mode { Addnew = 1 , Update =2 }
        Mode mode;
        public int TestAppointmentID { get; set; } = 0;
        public int TestTypeID { get; set; }
        public int LDL_ApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        private decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public clsTestAppointment() 
        {
            mode = Mode.Addnew;

            TestAppointmentID = -1;
            TestTypeID = 1;
            LDL_ApplicationID = 0;
            AppointmentDate =  DateTime.Now;
            PaidFees = this.Fees();
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
            IsLocked = false;
            RetakeTestApplicationID = -1;

        }
        public clsTestAppointment(int LDLappID, int TestTypeID)
        {
            mode = Mode.Addnew;

            TestAppointmentID = -1;
            this.TestTypeID = TestTypeID;
            this.LDL_ApplicationID = LDLappID;
            AppointmentDate = DateTime.Now;
            PaidFees = this.Fees();
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
            IsLocked = false;
            RetakeTestApplicationID = -1;

        }

        public clsTestAppointment(int TestAppointmentID ,int LocalDrivingLicenseApplicationID,int TestTypeID,
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



        public string TypeName() => clsTestTypes_Data.GetTestTypeName(this.TestTypeID);
        public decimal Fees() => clsTestTypes_Data.GetTestTypeFees(this.TestTypeID);



        public static  clsTestAppointment Find(int TestAppointmentID)
        {
            int TestType = 0, LDLappID = 0, CreatedByUserID = 0;
            DateTime AppointmentDate = DateTime.Now;
            bool isLocked = false;
            decimal PaidFees = 0;


            if (clsTestsAppointments_Data.GetTestAppointmentInfoByID(TestAppointmentID, ref LDLappID, ref TestType,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref isLocked))
            {
                return new clsTestAppointment(TestAppointmentID, LDLappID, TestType,
                 AppointmentDate, PaidFees, CreatedByUserID, isLocked);
            }
            return null;
        }




        private bool _Add()
        {
            


            this.TestAppointmentID = clsTestsAppointments_Data.AddTestAppointment(LDL_ApplicationID,
                TestTypeID, AppointmentDate, PaidFees, IsLocked, CreatedByUserID, RetakeTestApplicationID);
            return this.TestAppointmentID != -1;
        }


        private bool _Update() => clsTestsAppointments_Data.UpdateTestAppointment(this.TestAppointmentID, AppointmentDate,IsLocked);

        public void TakeTest()
        {
            this.IsLocked = true;
            _ = _Update();
        }

        public static DataTable GetAllTestAppointments(int LDLappID, int TestTypeID) => clsTestsAppointments_Data.GetAllTestAppointments(LDLappID, TestTypeID);




        public bool Save()
        {
            switch (mode)
            {
                case Mode.Addnew:
                    mode = Mode.Update;
                    return _Add();

                case Mode.Update:
                    return _Update();

                default:
                    break;
            }
            return false;
        }

    }
}
