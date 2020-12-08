using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _13th_Homework
{
	class FileLogWriter : BaseLogWriter, ILogWriter
	{
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
