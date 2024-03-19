using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
namespace DVLD_BusinessLayer
{
    public static class GlobalSettings
    {

        public static  clsUser CurrentUser { get; set; }

        public static readonly  string destinationFolder = @"C:\DVLD - People - Images";

        public static Action<string> LogError = clsDataAccessSettings.LogError;
        


    }
}
