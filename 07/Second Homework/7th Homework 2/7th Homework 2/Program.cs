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
			Console.Write("Введите текст: ");
			do
			{
				text = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(text))
				{
					Console.Write("Вы ввели пустую строку! Попробуйте ещё раз: ");
					continue;
				}
				StringBuilder sb = new StringBuilder(text.Length);
				for (int i = 0; i < sb.Capacity; i++)
					sb.Insert(0, text[i]);
				Console.WriteLine(sb.ToString().ToLower());
			} while (string.IsNullOrWhiteSpace(text));
		}
	}

}