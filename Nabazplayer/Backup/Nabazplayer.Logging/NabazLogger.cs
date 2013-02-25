using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

namespace Nabazplayer.Logging
{
    /// <summary>
    /// Provide a simple access to log4net. Warning, this class isn't thread safe yet
    /// </summary>
    public class NabazLogger
    {
        public static NabazLogger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NabazLogger();
                }
                return instance;
            }
        }

        public ILog CurrentLogger
        {
            get
            {
                return logger;
            }
        }


        private NabazLogger()
        {
            BasicConfigurator.Configure();
            logger = LogManager.GetLogger(typeof(NabazLogger));
            logger.Info("Logging configuration loaded");

        }

        private static NabazLogger instance;
        private ILog logger;
    }
}
