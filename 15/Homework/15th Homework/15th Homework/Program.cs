using System;

namespace _15th_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = LogWriterFactory.GetLogWriter<ILogWriter>(@"C:\Users\ar199\Desktop\log.txt");

			test.LogError("error!");
		}
	}
}
