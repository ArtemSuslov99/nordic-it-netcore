using System;
using System.Collections.Generic;
using System.Text;

namespace _10th_Classwork_2
{

	class Pet
	{
		public PetKind Kind;
		private string _birthPlace;
		private char _sex;
		private byte _age;
		public string Name { get; set; }
		public int Age { get; set;}
		public DateTimeOffset DateOfBirth;


		public byte GetAge()
		{
			TimeSpan liveTime = DateTimeOffset.Now.Subtract(DateOfBirth);
			return (byte)Math.Floor(liveTime.TotalDays / 365.242);

		}

		public string ShortDescription
		{
			get
			{
				return $"Имя:{Name}, возраст {GetAge()}";
			}
		}

		public Pet(string name, PetKind kind, char sex, DateTimeOffset dateofbirth, string birthplace)
		{
			Name = name;
			Kind = kind;
			Sex = sex;
			DateOfBirth = dateofbirth;
			_birthPlace = birthplace;
		}

		public string GetShortDescription(bool isShort = false)
		{
			return isShort
				? ShortDescription
				: PropertiesString;
		}



		public void UpdateProperties(string name)
		{
			Name = name;
		}

		public void UpdateProperties(string name, char sex)
		{
			Name = name;
			Sex = sex;

		}

		public string PropertiesString

		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {GetAge()} years old birth place: {_birthPlace}.";
			}
		}
		public string GetPropertiesString()
		{
			return $"{Name} is a {Kind} ({Sex}) of {GetAge()} years old.";
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


	}

}
