using System;

namespace _13th_Classwork
{
	class Program
	{
		static void Main(string[] args)
		{
			var plane = new Plane(100, 4);
			plane.TakeUpper(120);
			plane.TakeLower(20);
			plane.WriteAllProperties();

			var helicopter = new Helicopter(80, 3);
			helicopter.TakeUpper(120);
			helicopter.TakeLower(60);
			helicopter.WriteAllProperties();

		}
		public static void DoFlyerTest(IFlyer flyer)
		{
			flyer.TakeUpper(100);
			flyer.TakeLower(50);

			flyer.TakeUpper(100);
			flyer.TakeLower(100);
		}
	}
}
