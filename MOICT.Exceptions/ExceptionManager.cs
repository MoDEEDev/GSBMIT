using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace MOICT
{

    public sealed class ExceptionManager
    {
       
        /// Private Constructor to ensure that the class cannot be instantiated

        private ExceptionManager()
        {

        }


        public static MOICTException HandleException(System.Exception ex,string Operation , string ProblemType,string ErrorCode)
        {
            MOICTException exception = new MOICTException();
            exception.Operation  = Operation;
            exception.ProblemType = ProblemType;
            exception.ErrorCode = ErrorCode;

             LogException(ex.Message + " #### " + ex.StackTrace + "  Operation = " + exception.Operation + " ProblemType= " + ProblemType + " ErrorCode= " + ErrorCode);
            return exception;
        }
        private static void LogException(string Message)
        {

            string sSource;
            string sLog;          

            sSource = "MOICT WCF";
            sLog = "Gov";            

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);
          
            EventLog.WriteEntry(sSource, Message,EventLogEntryType.Error);

        }


        
    }
}