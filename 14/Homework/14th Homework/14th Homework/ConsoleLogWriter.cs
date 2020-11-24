using System;
using System.Collections.Generic;
using System.Text;

namespace _14th_Homework
{
    public class ConsoleLogWriter : BaseLogWriter
    {
        private static ConsoleLogWriter _consoleLogWriter;
        private ConsoleLogWriter()
		{

		}
        public static ConsoleLogWriter GeyInstance()
        {
            if (_consoleLogWriter == null)
            {
                _consoleLogWriter = new ConsoleLogWriter();
            }
            return _consoleLogWriter;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }
    }
}
