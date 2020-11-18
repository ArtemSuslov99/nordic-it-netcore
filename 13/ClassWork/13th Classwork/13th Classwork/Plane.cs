using System;
using System.Collections.Generic;
using System.Text;

namespace _13th_Classwork
{
	class Plane: FliyngObject
	{
		public byte EnginesCount { get; private set; }

		public Plane (int maxHeight, byte enginesCount) :base(maxHeight)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("It’s a plane, welcome aboard!");
		}

		public override void WriteAllProperties()
		{
			Console.WriteLine($"\nЧисло двигателей самолёта: {EnginesCount}");
			base.WriteAllProperties();

		}
	}
}
