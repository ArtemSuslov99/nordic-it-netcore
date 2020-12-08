using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IDisposableDemo
{
	class ErrorList: IDisposable, IEnumerable<string>
	{

		public static string OutputPrefixFormat { get; set; }

		static ErrorList()
		{
			OutputPrefixFormat = "MMMM dd, yyyy (h:mm tt)";
		}

		public string Category { get;}
		public List<string> _errors;

		public ErrorList(string category)
		{
			Category = category;
			_errors = new List<string>();
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public void WriteToConsole()
		{
			foreach (string error in _errors)
			{
				Console.WriteLine($"{DateTimeOffset.Now.ToString(OutputPrefixFormat)}: {error}");
			}
		}

		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
