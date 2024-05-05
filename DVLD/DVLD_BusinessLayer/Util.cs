using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_BusinessLayer
{
    public class Util
    {
        public static void LogError(string ErrorMessage)
        {
                string SourceName = "DVLD";
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Applications");
                }

                EventLog.WriteEntry(SourceName, ErrorMessage, EventLogEntryType.Error);

            }
            catch { }
       
        }


        public static string ComputeHashing(string Input)
        {
            using (SHA256 sh = SHA256.Create())
            {
                byte[] byts = sh.ComputeHash(Encoding.UTF8.GetBytes(Input));

                return BitConverter.ToString(byts).Replace("-", "");
            }

        }
    }
}
