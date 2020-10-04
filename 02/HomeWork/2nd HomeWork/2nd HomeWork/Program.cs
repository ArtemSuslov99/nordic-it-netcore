using System;

namespace _2nd_HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Введите первое число: ");
			string firstInputNumber = Console.ReadLine();
			int firstNumber = int.Parse(firstInputNumber);
			Console.Write("Введите второе число: ");
			string secondInputNumber = Console.ReadLine();
			int secondNumber = int.Parse(secondInputNumber);
			Console.WriteLine($"Сумма чисел равна: {firstNumber + secondNumber}");
			Console.WriteLine($"Разница чисел равна: {firstNumber - secondNumber}");
			Console.WriteLine($"Произведение чисел равна: {firstNumber * secondNumber}");

		}
	}
}
