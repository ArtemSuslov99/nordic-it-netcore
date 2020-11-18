using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork2
{
	class ConsoleIWriter : IWriter
	{
		public void Dispose()
		{
			Console.WriteLine("Освобождение ресурсов");
		}

		public void Write(string content)
		{
			Console.WriteLine(content);
		}
	}
}
