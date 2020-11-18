using System;

namespace _13th_Classwork2
{
	class Program
	{
		static void Main(string[] args)
		{
			//using ConsoleIWriter consoleIWriter = new ConsoleIWriter();
			//consoleIWriter.Write("Hello world");
			////consoleIWriter.Dispose();

			var v = new SimpleNumbersValidator();
			bool ok = v.Check(new[] { 1, 3, 5, 7, 9});
			Console.WriteLine(ok);
		}
	}
}
