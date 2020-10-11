using System;
using System.Globalization;

namespace _4th_Homework
{
	enum containersType
	{
		OneLiter = 1,
		Fiveliter = 5,
		Twentyliter = 20
	}
	class Program
	{
		static void Main(string[] args)
		{
			int firstContainer = 0;
			int secondContainer = 0;
			int thirdContainer = 0;
			string delimite =
				CultureInfo
				.CurrentCulture
				.NumberFormat
				.NumberDecimalSeparator;

			Console.WriteLine("Какой объем сока (в литрах) требуется упаковать? " +
				$"Введите число используя '{delimite}' если оно не целое");
			string firstInputNumber = Console.ReadLine();
			double firstNumber = double.Parse(firstInputNumber);

			Console.WriteLine("Вам потребуются следующие контейнеры:");
			for (thirdContainer = 0; (double)containersType.Twentyliter <= firstNumber; thirdContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - (double)containersType.Twentyliter);
			}
			if (thirdContainer != 0)
			{
				Console.WriteLine($"20л: " + thirdContainer + "шт.");
			}
			for (secondContainer = 0; (double)containersType.Fiveliter <= firstNumber; secondContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - (double)containersType.Fiveliter);
			}
			if (secondContainer != 0)
			{
				Console.WriteLine($"5л: " + secondContainer + "шт.");
			}
			for (firstContainer = 0; (double)containersType.OneLiter <= firstNumber; firstContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - (double)containersType.OneLiter);
			}
			if (firstContainer != 0)
			{
				Console.WriteLine($"1л: " + firstContainer + "шт.");
			}
		}
	}
}

