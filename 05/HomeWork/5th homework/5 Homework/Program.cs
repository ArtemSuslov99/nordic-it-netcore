using System;
using System.Globalization;

namespace _5_Homework
{
	class Program
	{
		[Flags]
		enum BodyType
		{
			Circle = 0x1,
			EquilateralTriangle = 0x2,
			Rectangle = 0x4
		}

		static void Main(string[] args)
		{
			string delimite =
				CultureInfo
				.CurrentCulture
				.NumberFormat
				.NumberDecimalSeparator;
			string info = $"Введите число используя '{delimite}' если оно не целое";
			double longValue;
			string selectedInput;
			BodyType bodyType = (BodyType)(0x8 - 1);
			try
			{
				Console.WriteLine($"Введите тип фигуры (от 1 до 3): {bodyType}");
				string userInput = Console.ReadLine();
				int num = int.Parse(userInput);
				switch (num)
				{
					case 1:
						Console.WriteLine("Введите значение диаметра окружности. " + info + ":");
						string inputDiametr = Console.ReadLine();
						double diametrValue = double.Parse(inputDiametr);
						Console.WriteLine("Площадь круга равна: " + (Math.Round((Math.PI) * Math.Pow(diametrValue, 2), 2)));
						Console.WriteLine("Периметр круга равна : " + (Math.Round((2 * Math.PI * diametrValue), 2)));
						break;
					case 2:
						Console.WriteLine("Введите значение длинны сторон равностороннего треугольника. " + info + ":");
						string selectedLong = Console.ReadLine();
						longValue = double.Parse(selectedLong);
						double p = ((3 * longValue) / 2);
						Console.WriteLine("Периметр равносторонненго треугольника равен: " + Math.Round(3 * longValue, 2));
						Console.WriteLine("Площадь равносторонненго треугольника равна: " + (Math.Round(Math.Sqrt(p * (p - longValue) * (p - longValue) * (p - longValue)), 2)));
						break;
					case 3:
						Console.WriteLine("Введите длинну прямоугольника. " + info + ":");
						selectedInput = Console.ReadLine();
						longValue = double.Parse(selectedInput);
						Console.WriteLine("Введите высоту прямоугольника. " + info + ":");
						selectedInput = Console.ReadLine();
						double heightValue = double.Parse(selectedInput);
						Console.WriteLine("Площадь повехности прямоугольника равна: " + Math.Round(longValue * heightValue, 2));
						Console.WriteLine("Периметр прямоугольника равен: " + Math.Round((longValue + heightValue) * 2, 2));
						break;
				}
			}
			catch
			{
				Console.WriteLine("Вы ввели неккоректное значение, допускаются только числа!");
			}
		}

	}
}
