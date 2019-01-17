using NLog;

namespace SimpleNLog
{
    public static class LogHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void WriteLog(LogLevel logLevel, string message)
        {
            logger.Log(logLevel, message);
        }
    }
}