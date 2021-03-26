using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Framework.Logger
{
    class Logger
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public static ILogger getLogger()
        {
            return logger;
        }
    }
}
