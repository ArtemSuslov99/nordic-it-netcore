using System;

namespace _2nd_HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			string userInputNumber;
			Console.Write("Введите первое число: ");
			userInputNumber = Console.ReadLine();
			int firstArgument = int.Parse(userInputNumber);
			Console.Write("Введите второе число: ");
			userInputNumber = Console.ReadLine();
			int secondArgument = int.Parse(userInputNumber);
			Console.WriteLine($"Сумма чисел равна: {firstArgument + secondArgument}");
			Console.WriteLine($"Разница чисел равна: {firstArgument - secondArgument}");
			Console.WriteLine($"Произведение чисел равна: {firstArgument * secondArgument}");

		}
	}
}
