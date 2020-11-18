using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork
{
	public interface IFlyer
	{
		public int MaxHeight { get; }
		public int CurrentHeight { get; }

		public void TakeUpper(int delta);
		public void TakeLower(int delta);
	}
}
