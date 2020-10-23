using System;
using System.IO;
using System.Globalization;
using System.Text;
using System.Linq;

namespace _7th_classwork
{
	class Program
	{
		static void Main(string[] args)
		{
			//string a = "test";
			//string b = "Test";
			//Console.WriteLine(a == b); // false
			//Console.WriteLine(a.Equals(b)); // false
			//								// but this will return true
			//Console.WriteLine(a.Equals(b, StringComparison.InvariantCultureIgnoreCase));

			//var test = "a\tb\nc";
			//Console.WriteLine(test);

			//			string multiline = @"Lorem ipsum dolor sit amet, consectetur adipiscing
			//elit, sed do eiusmod tempor incididunt ut labore et dolore magna
			//aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
			//laboris nisi ut aliquip ex ea commodo consequat.";
			//			Console.WriteLine(multiline);

			//		string longText = "Lorem ipsum dolor sit amet, consectetur adipiscing "
			//+ "elit, sed do eiusmod tempor incididunt ut labore et dolore magna "
			//+ "aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco "
			//+ "laboris nisi ut aliquip ex ea commodo consequat.";
			//		Console.WriteLine(longText);

			//Console.OutputEncoding = Encoding.UTF8;

			//double radius = 15;
			//double square = radius * radius * Math.PI;
			//string stringRadius = radius.ToString(format: "C",
			//	provider: CultureInfo.GetCultureInfo("en-GB"));
			//Console.WriteLine(stringRadius);

			//double i = 15;
			//double j = Math.PI;
			//var s = $"{i} divided by {j:#.##} equals to {i / j:#.##}";
			//Console.WriteLine(s); // 15 divided by 3.14 equals to 4.77
			//DateTime now = DateTime.Now;
			//string result = $"Now is {now:dd.MM.yyyy HH:mm}";
			//Console.WriteLine(result); // Now is 29.01.2019 14:00



			//--------------------------------------------------------------------------------------------------



			//Console.WriteLine($"Введите 2 дробных числа :");
			//string userInput = Console.ReadLine();
			//double num = double.Parse(userInput);
			//userInput = Console.ReadLine();
			//double secondNum = double.Parse(userInput);
			//string result = num + " умноженное на " + secondNum + " равно " + num * secondNum;
			//string secondResult = string.Format("{0} сложенное с {1} равна {2}", num, secondNum, num + secondNum);
			//string thirdResult = $"{num} вычитаемое из {secondNum:#.##} будет равна {num - secondNum:#.##}";
			//Console.WriteLine(result);
			//Console.WriteLine(secondResult);
			//Console.WriteLine(thirdResult);

			//-----------------------------------------------------------------------------------------------------------------------------

			//Console.WriteLine("Ввидите слово: ");
			//string word = Console.ReadLine();
			//Console.WriteLine("Ввидите букву: ");
			//string letter = Console.ReadLine();

			//string result = word.Replace(oldValue: letter, newValue: "*");
			//Console.WriteLine(result);


			//var test = "my  test string";
			////Console.WriteLine(test.Replace("test", "best")); // my best string
			////Console.WriteLine(test.Substring(8, 3)); // str
			//string[] words = test.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			//foreach (string word in words)
			//	Console.WriteLine(word.Length);// my
			//							// test
			//							// string

			//Console.WriteLine("Слово: ");
			//string userInput = Console.ReadLine();
			//Console.WriteLine("Буква");
			//string secondUserInput = Console.ReadLine();
			//int indexOfLetter = 0;
			//do
			//{
			//	indexOfLetter = userInput.IndexOf(secondUserInput, indexOfLetter);

			//	if (indexOfLetter < 0)
			//		break;

			//	Console.WriteLine(indexOfLetter);
			//	indexOfLetter++;
			//} while (true);

			//Console.WriteLine($"Количество букв \"{secondUserInput}\" " +
			//	$"в слове \"{userInput}\" равна: {indexOfLetter}");

			//var test = "test string";
			//Console.WriteLine(test.Contains(" ")); // true
			//Console.WriteLine(test.StartsWith("te")); // true
			//Console.WriteLine(test.EndsWith("s")); // false
			//Console.WriteLine(test.IndexOf("s")); // 2
			//Console.WriteLine(test.LastIndexOf("s")); // 5

			//string email;
			//Console.Write("Enter your email: ");
			//do
			//{
			//	email = Console.ReadLine();
			//	email = email.ToLower().Trim();

			//} while (string.IsNullOrWhiteSpace(email));
			//Console.WriteLine(email);


			//Console.Write("Enter card holder name: ");
			//string name = Console.ReadLine();
			//name = name.ToUpper();
			//Console.WriteLine(name);


			//string[] figures = { "Circle", "Triangle", "Square" };
			//foreach (string figure in figures)
			//{
			//	Console.Write(figure + ", ");
			//}
			//Console.WriteLine();
			//Console.WriteLine( string.Join(separator: ", ", figures));

			//string text = "     lorem   ipsum    dolor      sit amet ";
			//string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			//words[1] = words[1].ToUpper(); 
			//Console.WriteLine(string.Join(' ', words));

			//string textClean = text.TrimEnd();
			//int lastSpaceIndex = textClean.LastIndexOf(' ');
			//textClean = textClean.Substring(0, lastSpaceIndex);
			//textClean = textClean.TrimEnd();
			//Console.WriteLine(textClean);

			//string[] words = "this is my great example".Split(separator:' ');
			//var exampleBuilder = new StringBuilder(100);
			//foreach (var word in words)
			//{
			//	exampleBuilder.
			//		Append(word).
			//		Append(", ");
			//}
			//exampleBuilder.Remove(exampleBuilder.Length - 2, 2);
			//Console.WriteLine(exampleBuilder.ToString());


			//string text = "     lorem   ipsum    dolor      sit amet           ";
			//var resultBilder = new StringBuilder(text.Length);
			//for (int i = 0; i < text.Length; i++)
			//{
			//	resultBilder.Append(text[i]);

			//}


			string str = @"Здравствуйте уважаемы форумчане. 
Попросили написать программу, которая считает количество 
встречаемости каждой буквы в тексте.
Подскажите как подсчитать эти смволы? Заранее спасибо!";
			Console.WriteLine("Введите символ:");
			string s = Console.ReadLine();
			int count = str.ToCharArray().Where(c => c == s[0]).Count();
			Console.WriteLine(count);
			Console.ReadKey();
		}
	}
}
