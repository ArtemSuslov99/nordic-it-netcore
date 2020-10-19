using System;

namespace _6th_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов: ");
			do
			{
				try
				{
					var a = int.Parse(Console.ReadLine());
					int c = 0;
					if (a > 0)
					{
						while (a != 0)
						{
							if ((a % 10) % 2 == 0)
							{
								c++;
							}
							a = a / 10;
						}
						Console.WriteLine("Количество четных цифр: {0} ", c);
						break;
					}
					else
					{
						Console.WriteLine("Введено неверное значение! Попробуйте еще раз: ");
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Вы ввели не числовое значение! Попробуйте еще раз:");
					continue; // start the next cycle iteration!
				}
				catch (OverflowException)
				{
					Console.WriteLine("Вы ввели значение превышающее 2 млрд. Попробуйте еще раз:");
					continue; // start the next cycle iteration!
				}
			} while (true);
		}
	}
}
