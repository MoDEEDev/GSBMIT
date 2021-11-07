using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;

namespace MOICT.DataAccess.Mappers
{
    class Logger
    {
        public static void logError(Exception ex)
        {
            string strLogText = Environment.NewLine + "************************************ MITService logger ************************************" +
                Environment.NewLine + "Date : " + DateTime.Now + Environment.NewLine + "Data : " + ex.Data +
                Environment.NewLine + "Source : " + ex.Source + Environment.NewLine + "Message : " + ex.Message +
                Environment.NewLine + "InnerException : " + ex.InnerException + Environment.NewLine + "Error: " + ex.ToString() +
                Environment.NewLine + "*************************************************************************************" + Environment.NewLine;

            if (!EventLog.SourceExists("MITService"))
                EventLog.CreateEventSource("MITService", "MITService");

            EventLog.WriteEntry("MITService", strLogText, EventLogEntryType.Error);
        }
    }
}
