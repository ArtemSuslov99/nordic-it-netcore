using System;

namespace _3d_lesson
{
	class Program
	{
		static void Main(string[] args)
		{
			//const int myConstants = 255;
			//const int mySecondConstant = myConstants + 1;
			//Console.WriteLine(myConstants);
			//Console.WriteLine(mySecondConstant);
			//Console.WriteLine(mySecondConstant - myConstants);

			//Console.Write("Введите число: ");
			//string InputNumber = Console.ReadLine();
			//object i = int.Parse(InputNumber);
			//object j = (int)i + 10;
			//Console.WriteLine(Math.Sqrt((int)j));


			//Console.Write("Введите слово: ");
			//object s1 = Console.ReadLine();
			//Console.WriteLine(((string)s1).Length);

			//Console.Write("Введите слово: ");
			//dynamic s2 = Console.ReadLine();
			//Console.WriteLine(s2.Length);

			//var a = 3.14F;
			//var b = 1D;
			//var c = 49L; // int 64 = long
			//var d = (byte)255;

			//Console.WriteLine(a.GetType());
			//Console.WriteLine(b.GetType());
			//Console.WriteLine(c.GetType());
			//Console.WriteLine(d.GetType());

			//string i = default;
			//Console.WriteLine(i);

			//int? a = null;
			//Console.WriteLine(a);
			//a = 4;
			//Console.WriteLine(a);

			//int? a = 5;
			//Console.WriteLine(a.Value);
			//Console.WriteLine(a.HasValue);

			//string[] names = new string[4]; 
			//names[0] = "Andrey";
			//names[1] = "Maria";
			//names[2] = "Alexander";
			//names[3] = "Eugenia";
			//for (int i = 0; i < names.Length; i++)
			//{
			//	Console.WriteLine(names[i]);
			//}

			//string[] trees = new string[3];
			//trees[0] = "Ясень";
			//trees[1] = "Липа";
			//trees[2] = "Кедр";

			//string[] ages = new string[3];
			//ages[0] = "32";
			//ages[1] = "24";
			//ages[2] = "43";
			//for (int i = 0; i < ages.Length; i++)
			//{
			//	Console.WriteLine(trees[i] +" -возраст в годах:"+ ages[i]);
			//}

			//string[] names =
			//{
			//"Andrey",
			//"Maria",
			//"Alexander",
			//"Eugenia",
			//};

			//for (int i = 0; i < names.Length; i++)
			//{
			//	Console.WriteLine(names[i]);
			//}

			//Console.WriteLine("Key Analyzer App"); // Writes text and starts a new line
			//Console.Write("Enter string: "); // Writes text without starting a new line
			//Console.WriteLine(); // Just starts a new line
			//string s = Console.ReadLine(); // Reading a line
			//Console.WriteLine(s); // Repeat the entered line on the screen
			//ConsoleKeyInfo cki1 = Console.ReadKey(); // Reads a single key
			//Console.WriteLine(cki1.Key.ToString()); // Writes the name of pressed key
			//ConsoleKeyInfo cki2 = Console.ReadKey(false); // Reading single key (hidden)
			//Console.WriteLine($"Key {cki1.Key}"); // Writes the name with template

			//Console.WriteLine("Нажмите любумую клавишу");
			//ConsoleKeyInfo keyInfo = Console.ReadKey();

			//Console.WriteLine($"Key char:  { keyInfo.KeyChar}");
			//ConsoleModifiers modifiers = keyInfo.Modifiers;

			//ConsoleColor color = Console.ForegroundColor;
			//ConsoleColor backcolor = Console.BackgroundColor;

			//Console.ForegroundColor = ConsoleColor.Green;
			//Console.BackgroundColor = ConsoleColor.Red;
			//if ((modifiers & ConsoleModifiers.Alt) != 0)
			//	Console.WriteLine("Alt pressed");

			//Console.ForegroundColor = color;
			//Console.BackgroundColor = backcolor;


			//if ((modifiers & ConsoleModifiers.Shift) != 0)
			//	Console.WriteLine("Shift pressed");
			//if ((modifiers & ConsoleModifiers.Control) != 0)
			//	Console.WriteLine("Control pressed");

			//string s = "10";
			//Console.WriteLine(s.PadRight(4));
			const int fun = 2;
			string[] trees = new string[fun];
			int[] ages = new int[fun];

			Console.WriteLine("Please, enter three names of trees, each on new string");

			for (int i = 0; i < trees.Length; i++)
			{
				trees[i] = Console.ReadLine();
			}

			Console.SetCursorPosition(left: 10, top: 20);

			Console.WriteLine("Please, enter ages of these trees, each on new string");
			for (int i = 0; i < ages.Length; i++)
			{
				ages[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < ages.Length; i++)
			{
				Console.WriteLine(trees[i] + " " + ages[i]);
			}
		}
	}
}
