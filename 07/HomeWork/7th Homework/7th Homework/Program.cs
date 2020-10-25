using System;
using System.Data.Common;
using System.Linq;

namespace _7th_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words;
			string text;
			Console.Write("Введите строку из нескольких слов: ");
			do
			{
				text = Console.ReadLine();
				words = text.Split(' ');
				if (words.Length >= 2 )
				{
					int letter = 0;
					foreach (string i in words)
					{
						
						if (i.Substring(0, 1) == "А" || i.Substring(0, 1) == "а")
						{
							letter++;
						}
					}
					Console.WriteLine($"Количество слов, начинающихся с буквы 'А': {letter}");
				}
				else
				{
					Console.Write("Слишком мало слов! Попробуйте ещё раз: ");
				}
				continue;
			}
			while (words.Length < 2);
		}
	}
}
