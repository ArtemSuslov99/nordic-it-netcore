using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork
{
	class Helicopter : FliyngObject
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It’s a helicopter, welcome aboard!");
		}
		public void WriteAllProperties()
		{
			Console.WriteLine($"\nЧисло лопастей винта вертолета: {BladesCount}");
			base.WriteAllProperties();
		}
	}
}
