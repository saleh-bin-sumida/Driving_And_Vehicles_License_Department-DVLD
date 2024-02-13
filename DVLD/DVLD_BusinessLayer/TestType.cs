using System;
using System.Data;
using DVLD_DataAccessLayer;
namespace DVLD_BusinessLayer
{
    public class clsTestType

    {

        public int TestTypeID { get; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }


        public clsTestType(int TestTypeID, string TestTypeTitle,string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeFees = TestTypeFees;
            this.TestTypeDescription = TestTypeDescription;

        }

        public static DataTable GetAllTestTypes() => clsTestsD_ata.GetAllTestTypes();


        public static clsTestType GetTestTypeInfoByID(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = 0;
            clsTestsD_ata.GetTestTypeInfo(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);

            return new clsTestType(TestTypeID, TestTypeTitle,TestTypeDescription, TestTypeFees);

        }

        public bool Update() => clsTestsD_ata.UpdateTestType(TestTypeID, TestTypeTitle,TestTypeDescription, TestTypeFees);
    }
}
