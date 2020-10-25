using System;
using System.IO;
using System.Text;

namespace _8th_classwork
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"test.txt";
			const string content = "Do you like what you see?";
			//FileStream stream = File.Create(fileName, bufferSize: 4096);

			
			FileStream stream = File.Open(fileName, 
				FileMode.OpenOrCreate, 
				FileAccess.ReadWrite, 
				FileShare.Read);

			//byte[] bytesOfContent = Encoding.ASCII.GetBytes(content);
			//stream.Seek(offset: 0, SeekOrigin.End);
			const int readBufferSize = 5;
			byte[] bytesOfContent = new byte[readBufferSize];
			string result = String.Empty;
			int bytesRead;
			do
			{
				bytesRead = stream.Read(
					bytesOfContent,
					offset: 0,
					count: readBufferSize);

				result += Encoding.ASCII.GetString(
					bytesOfContent,
					index: 0,
					count: bytesRead);
			} while (bytesRead > 0);
			stream.Close();
			Console.WriteLine(result);
			
			//stream.WriteByte(13);
			//stream.WriteByte(10);
			//stream.Write(bytesOfContent);
			//stream.Flush();

		}
	}
}
