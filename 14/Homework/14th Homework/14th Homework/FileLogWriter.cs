﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _14th_Homework
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
            var fs = File.Open(FileName, FileMode.OpenOrCreate);
            fs.Seek(0, SeekOrigin.End);
            var tw = new StreamWriter(fs);
            tw.WriteLine(FormatMessage(message, type));
            tw.Close();
            fs.Close();
        }
    }
}
