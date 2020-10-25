using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _8th_Classwork_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Dictionary<int, string> countries = new Dictionary<int, string>(5);
			//countries.Add(1, "Russia");
			//countries.Add(3, "Great Britain");
			//countries.Add(2, "USA");

			//foreach (KeyValuePair<int, string> country in countries)
			//{
			//	Console.WriteLine($"{country.Key} - {country.Value}");
			//}
			////countries.Add(1, "Some new country"); нельзя добавлять элементы ссуществующими ключами
			//countries[1] = "Россия";

			//foreach (KeyValuePair<int, string> country in countries)
			//{
			//	Console.WriteLine($"{country.Key} - {country.Value}");
			//}
			//countries.Remove(key: 1);
			//countries.Add(1, "Russia");

			//foreach (KeyValuePair<int, string> country in countries)
			//{
			//	Console.WriteLine($"{country.Key} - {country.Value}");
			//}

			//if (!countries.ContainsKey(1))
			//	countries.Add(1, "XXX");


			//Dictionary<string, string> countries = new Dictionary<string, string>
			//{
			//	{ "Россия", "Москва" },
			//	{ "Франция", "Париж" },
			//	{ "Германия", "Берлин"},
			//	{ "Великобритания", "Лондон" }
			//};
			//while (true)
			//{
			//	int randomCountry = (new Random()).Next(countries.Count);
			//	KeyValuePair<string, string> kvp = countries.ElementAt(randomCountry);
			//	string country = kvp.Key;
			//	string capital = kvp.Value;
			//	Console.Write($"Введите столицу страны \"{country}\": ");
			//	var answer = Console.ReadLine().Trim();
			//	if (answer == capital)
			//		Console.WriteLine("Правильно!");
			//	else
			//	{
			//		Console.WriteLine("Вы проиграли!");
			//		break;
			//	}
			//}

			Queue<int> queue = new Queue<int>();
			Console.WriteLine("Enter the integer numbers for delayed evaluation of square root");
			Console.WriteLine("(type \"run\" command to run the evaluation or \"exit\" to close the program):");
			while (true)
			{
				string input = Console.ReadLine().ToLower();
				if (input == "run")
				{
					while (queue.Count > 0)
					{
						int number = queue.Dequeue();
						Console.WriteLine($"sqrt({number}) = {MathF.Sqrt(number):0.##}");
					}
					continue;
				}
				else if (input == "exit")
				{
					Console.WriteLine($"Number of cancelled tasks in the queue: {queue.Count}. Cancelling...");
					break;
				}
				queue.Enqueue(int.Parse(input));
			}
		}
	}
}
