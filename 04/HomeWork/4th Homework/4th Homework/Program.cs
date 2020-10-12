using System;
using System.Globalization;

namespace _4th_Homework
{
	enum ContainerType
	{
		Small,
		Medium,
		Large
	}
	class Program
	{
		static void Main(string[] args)
		{
			const int smallContainerSize = 1;
			const int mediumContainerSize = 5;
			const int largeContainerSize = 20;
			var firstContainer = ContainerType.Small;
			var secondContainer = ContainerType.Medium;
			var thirdContainer = ContainerType.Large;
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
			if (thirdContainer != 0)
			{
				Console.WriteLine($"20л: " + (int)thirdContainer + "шт.");
			}

			for (secondContainer = 0; mediumContainerSize <= firstNumber; secondContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - mediumContainerSize);
			}
			if (secondContainer != 0)
			{
				Console.WriteLine($"5л: " + (int)secondContainer + "шт.");
			}

			for (firstContainer = 0; smallContainerSize <= firstNumber; firstContainer++)
			{
				firstNumber = Math.Ceiling(firstNumber - smallContainerSize);
			}
			if (firstContainer != 0)
			{
				Console.WriteLine($"1л: " + (int)firstContainer + "шт.");
			}
		}
	}
}

