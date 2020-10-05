using System;

namespace _2ndHomeworkHard
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(@"Выберите арифметическое действие:
			- Умножение (кнопка 1)
			- Деление (кнопка 2)
			- Сложение (кнопка 3)
			- Вычитание (кнопка 4)
            - Возведение числа в степень (кнопка 5)
			- Отстаток от деления (кнопка 6)");
			string choiceOfAction = Console.ReadLine();
			Console.Write("Введите первое число: ");
			string firstInputNumber = Console.ReadLine();
			int firstNumber = int.Parse(firstInputNumber);
			Console.Write("Введите второе число: ");
			string secondInputNumber = Console.ReadLine();
			int secondNumber = int.Parse(secondInputNumber);
			if (choiceOfAction == "1")
			{
				Console.WriteLine("Результат умножения = {0}", firstNumber * secondNumber);
			}
			if (choiceOfAction == "2")
			{
				if (secondNumber != 0)
				{
					Console.WriteLine("Результат деления = {0}", firstNumber / secondNumber); 
				}
				else
				{
					Console.WriteLine("На ноль делить нельзя");
				}
			}
			if (choiceOfAction == "3")
			{
				Console.WriteLine("Результат сложения = {0}", firstNumber + secondNumber);
			}
			if (choiceOfAction == "4")
			{
				Console.WriteLine("Результат вычетания = {0}", firstNumber - secondNumber);
			}
			if (choiceOfAction == "5")
			{
				Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(firstNumber, secondNumber));
			}
			if (choiceOfAction == "6")
			{
				Console.WriteLine("Результат остатка от деления = {0}", firstNumber % secondNumber);
			}
			Console.ReadKey();
		}
	}
}
