using System.Diagnostics;
using System.Configuration;
namespace DVLD_DataAccessLayer
{
    internal static class General
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static void LogErrorMessage(string message)
        {
            string SourceName = "DVLD";

            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName,"DVLD Application Log");
               
            }

            EventLog.WriteEntry(SourceName ,message,EventLogEntryType.Error);
        }
    }

}
