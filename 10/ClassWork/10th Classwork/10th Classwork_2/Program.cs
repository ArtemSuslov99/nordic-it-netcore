using System;

namespace _10th_Classwork_2
{
	enum PetKind
	{
		Mouse,
		Cat,
		Dog
	}

	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Kind = PetKind.Cat;
			pet1.Name = "Barsik";
			pet1.DateOfBirth = DateTimeOffset.Parse("2012-11-07 20:20:15.5488");
			pet1.Sex = 'M';
			pet1.SetBirthPlace("Moscow");
			pet1.UpdateProperties(name: "Tom");

			Pet pet2 = new Pet();
			pet2.Kind = PetKind.Dog;
			pet2.Name = "Elly";
			pet2.DateOfBirth = DateTimeOffset.Parse("2019-11-06 20:20:15.5488");
			pet2.Sex = 'F';
			pet2.SetBirthPlace("Deutschland");
			pet2.UpdateProperties(name: "Tom", sex: 'M');

			Pet pet3 = new Pet(name:"Tom", PetKind.Dog, sex: 'M');
		}
	}
}
