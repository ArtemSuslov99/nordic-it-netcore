using System;
using System.Collections.Generic;
using System.Text;

namespace _15th_Homework
{
    interface ILogWriter : IDisposable
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogSingleRecord(MessageType logMessageType, string message);

    }
}
