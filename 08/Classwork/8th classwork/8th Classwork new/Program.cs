using System;
using System.Collections.Generic;
using System.Linq;

namespace _8th_Classwork_new
{
	class Program
	{
		static void Main(string[] args)
		{
			//var intList = new List<int> 
			//{ 
			//	10, 20, 30, 40 
			//};

			//intList.RemoveAt(index: 1);
			//intList.Insert(index:1, item:21);

			//int[] intArray = new[] 
			//{ 
			//	50, 60 
			//};
			//intList.AddRange(intArray);
			//string output = string.Join(separator: ", ", intList);
			//intList.Clear();
			//if (intList.Count == 0)
			//	Console.WriteLine("Список intList пуст!");
			//Console.WriteLine(output);


			//var l = string.Join(", ", intList);
			//Console.WriteLine(l);
			// 10, 20, 30, 40
			//var strList = new List<string>();
			//strList.Add("one");
			//strList.Add("two");
			//strList.Add("three");
			//strList.Add("four");
			//strList.Add("four");
			//strList.Add(null);
			//strList.Add(null);
			//var m = string.Join(", ", strList);
			//Console.WriteLine(m);
			// one, two, three, four, four, ,


			var list = new List<double>();
			Console.WriteLine("Введите значения с плавающей запятой (введите \"stop\" чтобы закончить");
			do
			{
				string userInput = Console.ReadLine();
				if (userInput.Equals("stop", StringComparison.CurrentCultureIgnoreCase))
				{
					if(list.Count > 1)
						break;

					Console.WriteLine("Вы должны ввести хотя бы 2 числа: ");
					continue;
				}
				try
				{
					list.Add(double.Parse(userInput));
				}
				catch(FormatException)
				{
					Console.WriteLine("Вы ввели не числовое значение!");
					continue;
				}
			} while (true);

			double sum = 0;
			foreach (double d in list)
				sum += d;
			double avg = sum / list.Count;
			Console.WriteLine($"Сумма: {sum:0.0##}, Среднее арифметичсекое: {avg:0.0##}");
		}
	}
}
