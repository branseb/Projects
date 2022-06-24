using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class LoggerAdapter
    {
        private readonly List<ILogger> loggers;

        public LoggerAdapter ()
        {
            loggers = new List<ILogger>();

        }

        public void AddLogger (ILogger logger)
        {
            loggers.Add(logger);
        }

        public void Log (Exception exception)
        { 
            foreach (ILogger logger in loggers)
            {
                logger.Log (exception);
            }
        }
    }
}
