using System;
using System.Data;
using DVLD_DataAccessLayer;


namespace DVLD_BusinessLayer
{
    public static class clsCountry
    {
        public static DataTable GetAllCountries() => clsCounties_Data.GetAllCountries();

        public static string GetCountryNameByID(int CountryID) => clsCounties_Data.GetCountryNameByID(CountryID);
    }
}
