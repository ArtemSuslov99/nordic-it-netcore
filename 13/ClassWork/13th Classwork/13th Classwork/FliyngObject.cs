using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork
{
	public abstract class FliyngObject : IFlyer, IPropertiesWriter
	{
		public int MaxHeight { get; private set; }
		public int CurrentHeight { get; private set; }

		public FliyngObject(int maxHeight)
		{
			MaxHeight = maxHeight;
		}

		public void TakeUpper (int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(delta));
			}
			CurrentHeight = Math.Min(CurrentHeight + delta, MaxHeight);
		}

		public void TakeLower(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(delta));
			}
			
			if (CurrentHeight - delta < 0)
			{
				throw new InvalidOperationException("Crash!");
			}

			CurrentHeight = Math.Min(CurrentHeight - delta, MaxHeight);
		}

		public virtual void WriteAllProperties() 
		{
			Console.WriteLine(
				$"\nМаксимальная высота: {MaxHeight}" +
				$"\nВысота: {CurrentHeight}");
		}
	}
}
