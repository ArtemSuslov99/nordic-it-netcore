﻿using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _4th_ClassWork
{
	class Program
	{
		[Flags]
		enum CarType : byte
		{
			None = 0,
			SUV = 1,
			Sedan = 2,
			Truck = 4,
		}

		public static void Main(string[] args)
		{
			//float a = 7 + 0.5F;
			//Console.WriteLine(a);
			//int b = 7 - 2;
			//Console.WriteLine(b);
			//float c = 10.1f * 3;
			//Console.WriteLine(c);
			//int d = 11 / 3;
			//Console.WriteLine(d);
			//double e = 11 / 3;
			//Console.WriteLine(e);
			//double f = 11.0 / 3;
			//Console.WriteLine(f);
			//int g = 11 % 3;
			//Console.WriteLine(g);

			//int i = 0;
			//int j = ++i;
			//Console.WriteLine(j); 

			//int c = 0;
			//int d = 0;
			//d = c++; 
			//Console.WriteLine(c); 
			//Console.WriteLine(d); 

			//bool a = true;
			//Console.WriteLine(a);
			//bool b = !a;
			//Console.WriteLine(b);
			//bool c = !b;
			//Console.WriteLine("Operation");

			//int a = 18;
			//int b = 0;
			//b = a++;
			//Console.WriteLine(a);
			//Console.WriteLine(b);
			//Console.WriteLine(a == b);
			//Console.WriteLine(a != b);
			//Console.WriteLine(a > b);
			//Console.WriteLine(a < b);
			//Console.WriteLine(a >= b);
			//Console.WriteLine(a <= b);

			//int a = 10;
			//double b = a;
			//Console.WriteLine(b);

			//double g = 9.8;
			//int c = (int)g;
			//Console.WriteLine(c);

			//long veryBigNumber = long.MaxValue;
			//int notSomeBig = (int)veryBigNumber;
			//Console.WriteLine(veryBigNumber);
			//Console.WriteLine(notSomeBig);

			//int a = int.MaxValue;
			//int b = int.MaxValue;
			//float c = (float)a * b;
			//Console.WriteLine(c);

			//double l = 10.5;
			//Console.WriteLine(Convert.ToInt32(l));

			//Console.WriteLine(Math.Round(10.5, MidpointRounding.ToEven)); // 10
			//Console.WriteLine(Math.Round(10.5, MidpointRounding.AwayFromZero)); // 11

			//Console.WriteLine(Convert.ToByte('s')); 

			//double d = 10.9;
			//Console.WriteLine(Math.Sqrt(d));

			//float f = 10.9F;
			//Console.WriteLine((double)MathF.Sqrt(f));

			//var a = Math.Max(
			//	Math.Sqrt(d),
			//	MathF.Sqrt(f));
			//Console.WriteLine(a);

			//float a = 10.5F;
			//float b = 30.21F;

			//float c = MathF.Sqrt(x:a * a + MathF.Pow(b, 2));
			//Console.WriteLine(c);

			/* double a = 1;
			double h = 2.5;
			double n = 6;
			double g = a / (2 * Math.Tan(Math.PI / n));

			double sFirst = ((n * a) / 2) * (g + Math.Sqrt(Math.Pow(h, 2) + ((Math.Pow(g, 2)))));
			double sSecond = ((n * a) / 2) * (Math.Sqrt(Math.Pow(h, 2) + ((Math.Pow(g, 2)))));
			double v = (h * n * (Math.Sqrt(Math.Pow(a, 2)))/(12* Math.Tan(Math.PI / n)));
			Console.WriteLine(sFirst);
			Console.WriteLine(sSecond);
			Console.WriteLine(v); */

			//string strFloat = "3.14159265";
			//float f = Single.Parse(strFloat, CultureInfo.InvariantCulture);
			//Console.WriteLine(f * 2);


			//string delimiter = 
			//	CultureInfo
			//		.CurrentCulture
			//		.NumberFormat
			//		.NumberDecimalSeparator;
			//Console.WriteLine("Enter floating number," 
			//	+ $"use '{delimiter}' as number decimal separator");
			//string strFloat2 = Console.ReadLine();
			//float f2 = Single.Parse(strFloat2);
			//Console.WriteLine(f2 * 2);

			//var currentDayTime = 
			//	Enum.Parse(
			//		typeof(DayTime),
			//		value:Console.ReadLine());
			//Console.WriteLine(currentDayTime);
			//Console.WriteLine(
			//	(DayTime)((int)currentDayTime + 1));

			var myCarType = CarType.Sedan;
			WriteByteValueWithBits((byte)myCarType);

			CarType supportedCars =
				CarType.SUV
				| CarType.Sedan
				| CarType.Truck;

			WriteByteValueWithBits((byte)supportedCars);
		}
		static void WriteByteValueWithBits(byte value)
		{
			Console.WriteLine(
				"0x{0}\t({1})\t{2}",
				value.ToString("X").PadLeft(2, '0'),
				Convert.ToString(value, 2).PadLeft(8, '0'),
				value.ToString().PadLeft(3, '0'));
		}
	}
}
