using System;
using System.Collections.Generic;
using System.Text;

namespace IDisposableDemo
{
	class ConsoleWriter
	{
		private static ConsoleWriter _instance;
		private ConsoleWriter()
		{

		}

		public static ConsoleWriter GeyInstance()
		{
			if (_instance == null)
			{
				_instance = new ConsoleWriter();
			}
			return _instance;
		}
	}
}
