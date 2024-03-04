using DVLD_DataAccessLayer;
using System.Data;
namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        string Name {  get; set; }
        public string Description { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal Fees {  get; set; }


        public clsLicenseClass(int LicenseClassID)
        {
            
        }
        public static DataTable GetAllLicenseClasses() => clsLicenseClasses_Data.GetAllLicenseClasses();

    }
}
