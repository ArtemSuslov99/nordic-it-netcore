using System;

namespace _10th_Classwork
{

	class CreditCard
	{
		private string _number;
		public string HolderName { get; set; }
		public string ValidBefore { get; set; }
		public ushort Cvc { get; set; }

		public string Number
		{
			get
			{
				//if (_number == null)
				//	return null;
				//string result = string.Empty;
				//for (int i = 0; i < _number.Length; i++)
				//{
				//	if (i > 0 && i % 4 == 0)
				//		result += " ";

				//	result += _number[i];
				//}
				//return result;

				return _number;
			}
			set
			{
				foreach (char ch in value)
				{
					if (!char.IsDigit(ch))
					{
						throw new Exception(message: "Value should contain only digits");
					}
				}
				_number = value;
			}
		}

		public bool IsValid()
		{
			if (Number == null || Number.Length < 12 || Number.Length > 26)
			{
				return false;
			}

			if (ValidBefore == null)
			{
				return false;
			}

			if (Cvc > 999)
			{
				return false;
			}
			return true;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			CreditCard creditCard = new CreditCard();
			creditCard.HolderName = "Artem Suslov";
			creditCard.Number = "111122223333444455";
			creditCard.ValidBefore = "25/17";
			creditCard.Cvc = 123;

			Console.WriteLine(creditCard.Number);
			creditCard.Number += "9";

			creditCard.Number = creditCard.Number + "9";
			Console.WriteLine(creditCard.Number);
			Console.WriteLine(creditCard.IsValid()
				? "Credit card is valid"
				: "Credit card is not valid");

			CreditCard[] creditCards = new CreditCard[2];
			creditCards[0] = creditCard;
		}
	}
}
