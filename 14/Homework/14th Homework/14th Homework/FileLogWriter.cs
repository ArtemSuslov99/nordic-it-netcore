using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _14th_Homework
{
    class FileLogWriter : BaseLogWriter, ILogWriter
    {

        private static FileLogWriter _fileLogWriter;
        private FileLogWriter()
        {

        }

        public static FileLogWriter GeyInstance()
        {
            if (_fileLogWriter == null)
            {
                _fileLogWriter = new FileLogWriter();
            }
            return _fileLogWriter;
        }

        private string FileName { get; }

        public FileLogWriter(string fileName)
        {
            FileName = fileName;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            using (var fs = File.Open(FileName, FileMode.OpenOrCreate))
            {
                fs.Seek(0, SeekOrigin.End);
                using (var tw = new StreamWriter(fs))
                    tw.WriteLine(FormatMessage(message, type));
            }
        }
    }
}
