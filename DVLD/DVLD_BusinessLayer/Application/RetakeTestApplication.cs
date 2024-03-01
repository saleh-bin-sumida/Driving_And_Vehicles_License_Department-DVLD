

using System.Security.Principal;

namespace DVLD_BusinessLayer.Application
{
    public class clsRetakeTestApplication
    {
        public const int RetakeTestFees = 5;
        public int RetakeTestID { get; }
        public int LDLappID { get; set; }

        public int TestTypeID { get; set;}


        public clsRetakeTestApplication(int LDLappID, int TestTypeID)
        {
            RetakeTestID = -1;
            this.LDLappID = LDLappID;
            this.TestTypeID = TestTypeID;
        }

    }
}
