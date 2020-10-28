using System;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace _9th_Classswork
{
	class Program
	{
		static void Main(string[] args)
		{
			//string input1 = Console.ReadLine();
			//string input2 = Console.ReadLine();
			//int sameLettersNumber = 0;
			//for (int i = 0; i < input1.Length; i++)
			//{
			//	for (int j = 0; j < input2.Length; j++)
			//	{
			//		if (input1[i] == input2[j])
			//		{
			//			sameLettersNumber++;
			//		}
			//	}
			//}
			//Console.WriteLine(sameLettersNumber);
			//----------------------------------------------------------------------------------------------------------

			//input

			const int length = 100000;
			const int maxValue = 100;

			var stopwatch = new Stopwatch();

			int[] arraySource = GetSourceArray(length, maxValue);
			stopwatch.Start();
			//WriteOutArray(arraySource);
			int[] arraySortedInternal = GetArraySorteInternal(arraySource);
			stopwatch.Stop();
			stopwatch.Reset();
			stopwatch.Start();
			//WriteOutArray(arraySource);
			int[] arraySortedBubble = GetArraySortedBubble(arraySource);
			stopwatch.Stop();

			

			Console.WriteLine($"Bubble sorting done in {stopwatch.ElapsedMilliseconds} (ms):");

			//WriteOutArray(arraySource);
			//WriteOutArray(arraySortedBubble);
		}

		public static int[] GetSourceArray(int length, int maxValue)
		{
			int[] arr = new int[length];
			var random = new Random();

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = random.Next(maxValue);
			}
			return arr;
		}
		public static void WriteOutArray(int[] array)
		{
			Console.WriteLine(string.Join(separator: ", ", array));
		}

		public static int[] GetArraySortedBubble(int [] sourceArray)
		{
			int[] array = (int[])sourceArray.Clone();

			for (int i = 0; i < array.Length - 1; i++)
			{
				int limit = array.Length - 1 - i;

				for (int j = 0; j < limit; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j + 1];
						array[j + 1] = array[j];
						array[j] = temp;

					}
				}
			}
			return array;
		}


		public static int[] GetArraySorteInternal(int[] sourceArray)
		{
			int[] array = (int[])sourceArray.Clone();

			Array.Sort(array);
			return array;
		}
	}
}
