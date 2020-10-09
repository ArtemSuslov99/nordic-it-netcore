using System;

namespace _3d_HomeWorkPifagor
{
	class Program
	{
		static void Main(string[] args)
		{
			//const int number = 10;

			int[] table = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int ctr;
			int result;
			for (ctr = 0; ctr < table.Length; ctr++)
			{
				Console.Write($"  {table[ctr]}\t");
			}
			Console.WriteLine("\n-----------------------------------------------------------------------------");
			for (ctr = 0; ctr < table.Length; ctr++)
			{
				Console.Write($"  { result = table[0] * table[ctr]}\t  " +
					$"{ result = table[1] * table[ctr]}\t  " +
					$"{ result = table[2] * table[ctr]}\t  " +
					$"{ result = table[3] * table[ctr]}\t  " +
					$"{ result = table[4] * table[ctr]}\t  " +
					$"{ result = table[5] * table[ctr]}\t  " +
					$"{ result = table[6] * table[ctr]}\t  " +
					$"{ result = table[7] * table[ctr]}\t  " +
					$"{ result = table[8] * table[ctr]}\t  " +
					$"{ result = table[9] * table[ctr]}\t\n");
			}
			Console.ReadKey();
		}
	}
}
