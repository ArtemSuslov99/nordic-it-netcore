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
			Console.Write("Введите текст: ");
		link1:
			do
			{
				text = Console.ReadLine();
				bool isNum = int.TryParse(text, out num);
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
					goto link1;
				}
			} while (string.IsNullOrWhiteSpace(text));
		}
	}

}