using System;
using System.Linq;
using System.Text;

namespace _7th_Homework_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string text;
			int num;
			bool isNum;
			Console.Write("Введите текст: ");

			do
			{
				text = Console.ReadLine();
				isNum = int.TryParse(text, out num);
				if (isNum == false)
				{
					try
					{
						StringBuilder sb = new StringBuilder(text.Length);
						for (int i = 0; i < sb.Capacity; i++)
							sb.Insert(0, text[i]);
						Console.WriteLine(sb.ToString().ToLower());
					}
					catch
					{
						Console.Write("Вы ввели пустую строку! Попробуйте ещё раз: ");
						continue;
					}
					
				}
				else
				{
					Console.Write("Вы ввели не строковое значение! Введите строковое значение: ");
					continue;
				}
			} while (string.IsNullOrWhiteSpace(text) || isNum == true);
		}
	}

}