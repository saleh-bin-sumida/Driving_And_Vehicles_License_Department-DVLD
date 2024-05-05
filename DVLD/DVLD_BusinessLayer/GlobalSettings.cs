using System.Configuration;
using System.Diagnostics;

namespace DVLD_BusinessLayer
{
    public static class GlobalSettings
    {

        public static  clsUser CurrentUser { get; set; }

        public static readonly  string destinationFolder = ConfigurationManager.AppSettings["ImagesDestaionFolder"] ;

   


    }
}
