using System;
using DVLD_DataAccessLayer ;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        public static DataTable GetAllTestsTypes() => clsTestsD_ata.GetAllTestTypes();
    }
}
