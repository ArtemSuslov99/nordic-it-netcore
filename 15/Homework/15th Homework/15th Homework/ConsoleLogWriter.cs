using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _15th_Homework
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void Dispose()
        {

        }
        public override void LogSingleRecord(MessageType logMessageType, string message)
        {
            Console.WriteLine(GetFormatedMessage(logMessageType, message));
        }

    }
}
