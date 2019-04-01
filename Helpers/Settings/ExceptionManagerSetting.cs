using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers.ExceptionHandling
{
    public static class ExceptionManagerSetting
    {
        // tpdo singleton 
        public static void SetExceptionManager()
        {
            IConfigurationSource source = ConfigurationSourceFactory.Create();
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(source));

            var logwriterFactory = new LogWriterFactory(source);
            var logWriter = logwriterFactory.Create();
            Logger.Reset();
            Logger.SetLogWriter(logWriter);

            var exceptionPolicyFactory = new ExceptionPolicyFactory(source);
            var exceptionManager = exceptionPolicyFactory.CreateManager();
            ExceptionPolicy.SetExceptionManager(exceptionManager);
        }
    }
}
