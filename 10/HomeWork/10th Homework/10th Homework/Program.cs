using System;

namespace _10th_Homework
{
    class Person
    {
        private string _nameOfPerson;
        private byte _age;

        public string NameOfPerson
        {
            get
            {
                return _nameOfPerson;
            }

            set
            {
                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new Exception(message: "Ошибка! Вы должны использовать только буквенные значения!");
                    }
                }
                _nameOfPerson = value;
            }
        }

        public byte Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 120)
                {
                    throw new Exception("Указанный возраст не должен привышать 120!");
                }
                _age = value;
            }
        }

        public int AgeInFourYears
        {
            get
            {
                return _age + 4;
            }
        }

        public string GetPropertiesString
        {
            get
            {
                return $"{NameOfPerson} возраст через 4 года: {AgeInFourYears}";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
            }

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    Console.WriteLine($"Введите имя  {i + 1} человека: ");
                    persons[i].NameOfPerson = Console.ReadLine();
                    Console.WriteLine($"Введите взораст {i + 1} человека: ");
                    persons[i].Age = byte.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                for (int i = 0; i < persons.Length; i++)
                {
                    Console.WriteLine(persons[i].GetPropertiesString);
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите любую кнопку для выхода:");
                Console.ReadKey();
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }
        }
    }
}
