using System;
using System.Collections.Generic;
using System.Text;

namespace _14th_Homework
{
    class MultipleLogWriter : BaseLogWriter
    {
        private static MultipleLogWriter _multipleLogWriter;
        private MultipleLogWriter()
        {

        }
        public static MultipleLogWriter GeyInstance()
        {
            if (_multipleLogWriter == null)
            {
                _multipleLogWriter = new MultipleLogWriter();
            }
            return _multipleLogWriter;
        }


        private IEnumerable<ILogWriter> _logWriters;

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _logWriters = writers;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            foreach (var item in _logWriters)
            {
                switch (type)
                {
                    case MessageType.Error:
                        item.LogError(message);
                        break;
                    case MessageType.Info:
                        item.LogInfo(message);
                        break;
                    case MessageType.Warning:
                        item.LogWarning(message);
                        break;
                }
            }
        }
    }
}
