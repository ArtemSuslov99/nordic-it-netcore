﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _15th_Homework
{
	class FileLogWriter : AbstractLogWriter
	{
		private StreamWriter _streamWriter;

		public FileLogWriter(string fileName = @"C:\log.txt")
		{

			_streamWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));
			_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public override void Dispose()
		{
			if (_streamWriter != null)
				_streamWriter.Dispose();
		}

		public override void LogSingleRecord(MessageType logMessageType, string message)
		{

			{
				_streamWriter.WriteLine(GetFormatedMessage(logMessageType, message));
			}

		}
	}
}
