using System;
using System.Globalization;

namespace _4th_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			const int smallContainerSize = 1;
			const int mediumContainerSize = 5;
			const int largeContainerSize = 20;
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
			for (thirdContainer = 0; largeContainerSize <= firstNumber; thirdContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - largeContainerSize);
			}
			for (secondContainer = 0; mediumContainerSize <= firstNumber; secondContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - mediumContainerSize);
			}
			for (firstContainer = 0; smallContainerSize <= firstNumber; firstContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - smallContainerSize);
			}

			if (thirdContainer != 0)
			{
				Console.WriteLine("20л: " + thirdContainer + "шт.");
			}
			if (secondContainer != 0)
			{
				Console.WriteLine("5л: " + secondContainer + "шт.");
			}
			if (firstContainer != 0)
			{
				Console.WriteLine("1л: " + firstContainer + "шт.");
			}
		}
	}
}

