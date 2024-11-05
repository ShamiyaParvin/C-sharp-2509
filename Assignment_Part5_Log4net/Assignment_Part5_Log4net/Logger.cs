using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Assignment_Part5_Log4net
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            XmlConfigurator.Configure();

        }

        public static void LogError(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }
}
