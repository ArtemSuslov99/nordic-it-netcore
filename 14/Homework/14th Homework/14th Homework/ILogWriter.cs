using System;
using System.Collections.Generic;
using System.Text;

namespace _14th_Homework
{
	interface ILogWriter
	{
		void LogInfo(string message);
		void LogWarning(string message);
		void LogError(string message);

	}
}
