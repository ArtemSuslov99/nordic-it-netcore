using System;

namespace _10th_Classwork_2
{
	enum PetKind
	{
		Mouse,
		Cat,
		Dog
	}

	class Pet
	{
		public PetKind Kind;
		private string _birthPlace;
		private char _sex;
		private byte _age;
		public string Name { get; set; }
		public string PropertiesString
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age} years old birth place: {_birthPlace}.";
			}
		}
		public string GetPropertiesString()
		{
			return $"{Name} is a {Kind} ({Sex}) of {Age} years old.";
		}

		public void SetBirthPlace(string birthPlace)
		{
			if (birthPlace == null)
			{
				throw new ArgumentNullException(nameof(birthPlace));
			}

			if (_birthPlace != null)
			{
				throw new Exception(message: "Birth place cannot be overriden.");
			}
			_birthPlace = birthPlace;
		}


		public char Sex
		{
			get { return _sex; }
			set
			{
				if (value != 'M' && value != 'm' && value != 'F' && value != 'f')
					throw new Exception(message: "Sex should be one of two options: M/F");

				_sex = char.ToUpper(value);
			}
		}
		public byte Age
		{
			get { return _age; }
			set
			{
				if (value > 150)
					throw new Exception(message: "Age can not be more than 150");
				_age = value;
			}
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Kind = PetKind.Cat;
			pet1.Name = "Barsik";
			pet1.Age = 8;
			pet1.Sex = 'M';
			pet1.SetBirthPlace("Moscow");
			Console.WriteLine(pet1.PropertiesString);

			Pet pet2 = new Pet();
			pet2.Kind = PetKind.Dog;
			pet2.Name = "Elly";
			pet2.Age = 2;
			pet2.Sex = 'F';
			pet2.SetBirthPlace("Deutschland");
			Console.WriteLine(pet2.PropertiesString);


		}


	}
}
