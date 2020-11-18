using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork2
{
	interface IWriter : IDisposable
	{
		void Write(string content);
	}
}
