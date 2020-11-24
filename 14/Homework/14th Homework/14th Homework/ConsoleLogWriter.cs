using System;
using System.Collections.Generic;
using System.Text;

namespace _14th_Homework
{
    public class ConsoleLogWriter : BaseLogWriter
    {
        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }
    }
}
