using System;

namespace _14th_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			ILogWriter consoleWriter = new ConsoleLogWriter();
			consoleWriter.LogError("Записываем...");

			var fileWriter = new FileLogWriter(@"D:\Git\Lessons\nordic-it-netcore\13\HomeWork\log.txt");
			fileWriter.WriteMessage("Записываем..", MessageType.Error);

			var multipleWriter = new MultipleLogWriter(new ILogWriter[2] { fileWriter, consoleWriter });

			multipleWriter.LogError(" \"Ошибка\" ");
			multipleWriter.LogInfo(" \"Информация\" ");
			multipleWriter.LogWarning("\"Предупреждение\" ");
		}
	}
}
