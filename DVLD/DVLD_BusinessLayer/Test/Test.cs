
using DVLD_BusinessLayer.Test;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        

        public int TestID;
        clsTestAppointment TestAppointment;
        public bool isPassed;
        public string Notes;
        private readonly int CreatedByUserID;


        public clsTest(int TestAppointmentID)
        {

            TestID = -1;
            TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            isPassed = false;
            Notes = "";
            CreatedByUserID = GlobalSettings.CurrentUser.UserID;
        }



        public bool Save()
        {
            this.TestID = clsTests_Data.AddTestAppointment(TestAppointment.TestAppointmentID, isPassed, Notes, CreatedByUserID);
            return this.TestID != -1;
        }
    }

}
