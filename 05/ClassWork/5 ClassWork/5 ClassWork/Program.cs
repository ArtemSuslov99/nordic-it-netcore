using System;
using System.Diagnostics;

namespace _5_ClassWork
{
	class Program
	{

		static void Main(string[] args)
		{
			//Console.WriteLine("Введите длительность договора аренды в годах:");
			//string userInput = Console.ReadLine();
			//int num = int.Parse(userInput);
			//string text = "Договор аренды оформлен на период длительностью: ";
			//if (num < 30)
			//{
			//	if (num == 1 || num == 21)
			//	{
			//		Console.WriteLine(text + num + " год");
			//	}
			//	else if ((num >= 2 & num <= 4) || (num >= 22 & num <= 24))
			//	{
			//		Console.WriteLine(text + num + " года");
			//	}
			//	else
			//		Console.WriteLine(text + num + " лет");
			//}
			//else
			//{
			//	Console.WriteLine(" Вы ввели неверное значение!");
			//}

			//Console.WriteLine("Введите число от 1 до 100: ");
			//string strNum = Console.ReadLine();
			//int num = int.Parse(strNum);
			//string message;
			//message = num < 50
			//? "Введенное число меньше 50"
			//: "Введенное число больше либо равно 50!";
			//Console.WriteLine(message);
			//Console.ReadKey();

			//Console.WriteLine("Введите число от 1 до 100: ");
			//Console.WriteLine(int.Parse(Console.ReadLine()) < 50
			//	? "Введенное число меньше 50"
			//	: "Введенное число больше либо равно 50!");


			Console.WriteLine("Введите длительность договора аренды в годах:");
			string userInput = Console.ReadLine();
			int num = int.Parse(userInput);
			string text = "Договор аренды оформлен на период длительностью: ";

			if (num < 1 || num > 30)
			{
				throw new Exception("Введенное значение выходит за допустимыепределы от 1 до 30");
			}
			else
			{
				switch (num)
				{
					case 1:
					case 21:
						Console.WriteLine(text + num + " год");
						break;
					case 2:
					case 3:
					case 4:
					case 22:
					case 23:
					case 24:
						Console.WriteLine(text + num + " года");
						break;
					default:
						Console.WriteLine(text + num + " лет");
						break;
				}
			}
			//Console.WriteLine("Enter a number less than 100:");
			//string strNum = Console.ReadLine();
			//int num = int.Parse(strNum);
			//if (num >= 100)
			//{
			//	// throwing new exception according to our logic
			//	throw new Exception("The value should be less than 100!");
			//}
			//Console.WriteLine($"You entered correct value {num}");
			//Console.WriteLine("Press any key to exit...");
			//Console.ReadKey();
		}
	}
}
