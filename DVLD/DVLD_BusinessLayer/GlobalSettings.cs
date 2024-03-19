using System.Configuration;
using System.Diagnostics;

namespace DVLD_BusinessLayer
{
    public static class GlobalSettings
    {

        public static  clsUser CurrentUser { get; set; }

        public static readonly  string destinationFolder = ConfigurationManager.AppSettings["ImagesDestaionFolder"] ;

        public static void LogError(string ErrorMessage)
        {
            string SourceName = "DVLD";
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Applications");
            }

            EventLog.WriteEntry(SourceName, ErrorMessage, EventLogEntryType.Error);
        }
        


    }
}
