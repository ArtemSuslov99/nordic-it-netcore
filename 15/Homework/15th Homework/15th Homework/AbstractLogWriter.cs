using System;
using System.Collections.Generic;
using System.Text;

namespace _15th_Homework
{
    abstract class AbstractLogWriter : ILogWriter
    {
        private readonly string _logFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}";

        protected string GetFormatedMessage(MessageType logMessageType, string message)
        {
            return string.Format(_logFormat, DateTime.UtcNow, logMessageType, message);
        }
        public void LogError(string message)
        {
            LogSingleRecord(MessageType.Error, message);
        }

        public void LogInfo(string message)
        {
            LogSingleRecord(MessageType.Info, message);
        }

        public void LogWarning(string message)
        {
            LogSingleRecord(MessageType.Warning, message);
        }
        public abstract void LogSingleRecord(MessageType logMessageType, string message);

        public abstract void Dispose();
    }
}
