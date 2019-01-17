using NLog;
using System;

namespace SimpleNLog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Start");
            LogHelper.WriteLog(LogLevel.Trace, "Trace Aemitez");
            LogHelper.WriteLog(LogLevel.Debug, "Debug Aemitez");
            LogHelper.WriteLog(LogLevel.Info, "Info Aemitez");
            LogHelper.WriteLog(LogLevel.Warn, "Warn Aemitez");
            LogHelper.WriteLog(LogLevel.Error, "Error Aemitez");
            LogHelper.WriteLog(LogLevel.Fatal, "Fatal Aemitez");
            LogHelper.WriteLog(LogLevel.Off, "Off Aemitez");
            Console.ReadLine();
        }
    }
}