using System;

namespace _3d_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			const int person = 3;
			string[] name = new string[person];
			int[] ages = new int[person];

			Console.WriteLine("Enter three name");

			for (int i = 0; i < name.Length; i++)
			{
				name[i] = Console.ReadLine();
			}

			Console.WriteLine("Enter their age");

			for (int i = 0; i < ages.Length; i++)
			{
				ages[i] = int.Parse(Console.ReadLine());
				ages[i] = ages[i] + 4;
			}

			for (int i = 0; i < ages.Length; i++)
			{
				Console.WriteLine("Name: "+ name[i] + " age in 4 years: " + ages[i]);
			}
			Console.ReadKey();
		}
	}
}
