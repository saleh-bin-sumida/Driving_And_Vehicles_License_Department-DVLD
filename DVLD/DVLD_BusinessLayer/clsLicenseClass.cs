using DVLD_DataAccessLayer;
using System.Data;
namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        public static DataTable GetAllLicenseClasses() => clsLicenseClasses_Data.GetAllLicenseClasses();
    }
}
