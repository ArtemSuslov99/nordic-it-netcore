using System;

namespace IDisposableDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//using (var errList = new ErrorList("Message error"))
			//{
			//	System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			//	errList.Add("1-ая категория");
			//	errList.Add("2-ая категория");
			//	errList.WriteToConsole();
			//}
			//using (var fw = new FileWriter(fileName: "test.txt"))
			//{
			//	fw.Write(content: "Hello\r\n");
			//	fw.Write(content: "World\r\n");

			//	for (int i = 0; i < 10; i++)
			//		fw.Write(content: i + " ");
			//}

			//StaticDemoClass weight1 = new StaticDemoClass();
			//weight1.Weight = 12;

			//StaticDemoClass weight2 = new StaticDemoClass();
			//weight2.Weight = 16;

			//weight2.Weight += 4;
			//weight1.Weight -= 2;

			//Console.WriteLine(StaticDemoClass.SumWeight);

			var cw = ConsoleWriter.GeyInstance();
			var cw2 = ConsoleWriter.GeyInstance();
			Console.WriteLine(cw == cw2);





		}
	}
}
