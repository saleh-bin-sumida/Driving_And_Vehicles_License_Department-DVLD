using System.Diagnostics;
namespace DVLD_DataAccessLayer
{
    public static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=DVLD; Integrated Security =True;";

        public static void LogError(string message)
        {
            string SourceName = "DVLD";
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Applications");
            }

            EventLog.WriteEntry(SourceName ,message,EventLogEntryType.Error);
        }
    }

}
