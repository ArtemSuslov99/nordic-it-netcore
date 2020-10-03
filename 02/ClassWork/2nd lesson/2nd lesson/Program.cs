using System;
using System.Dynamic;
using System.Threading;

namespace _2nd_lesson
{
	class Program
	{
		static void Main()
		{
			//char letter = 'A';
			//Console.WriteLine(letter);

			//string name = "Bob";
			//Console.WriteLine(name);

			//byte age = 36;
			//Console.WriteLine(age);

			Console.Write("Введите ваш вораст: ");
			string inutAge = Console.ReadLine(); 
			int age = int.Parse(inutAge);
			Console.WriteLine($"Ваш вораст чере 10 лет: { age + 10}");
		}
	}
}
