using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Common.Helpers.ExceptionHandling
{
    public class BaseLoggingExceptionHandler : Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging.LoggingExceptionHandler
    {
        public BaseLoggingExceptionHandler(string logCategory, int eventId, TraceEventType severity, string title, int priority, Type formatterType, LogWriter writer) : base(logCategory, eventId, severity, title, priority, formatterType, writer)
        {
        }
    }
}
