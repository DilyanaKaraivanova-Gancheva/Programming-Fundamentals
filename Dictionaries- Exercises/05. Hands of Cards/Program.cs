using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			var namesCards = new Dictionary<string, List<double>>();
			var input = Console.ReadLine();
			while (input!="JOKER")
			{
				var tokens = input.Split(':');
				var name = tokens[0];
				var cards = tokens[1]
					.Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
					.Select(CalculateCarValue)
					.ToArray();
				if (!namesCards.ContainsKey(name))
				{
					namesCards[name] = new List<double>();
				}
				namesCards[name].AddRange(cards);

				foreach (var nameCards in namesCards)
				{
					var names = nameCards.Key;
					var card = nameCards.Value;
					var totalCards = card.Distinct().Sum();
					Console.WriteLine($"{names} : {totalCards}");
				}
				
			}
		}

		private static double CalculateCarValue(string card)
		{
			var cardPower = new Dictionary<string, int>();
			cardPower["J"] = 11;
			cardPower["Q"] = 12;
			cardPower["K"] = 13;
			cardPower["A"] = 14;
			for (int i = 2; i <= 10; i++)
			{
				cardPower[i.ToString()] = i;
			}

			var cardTypes = new Dictionary<string, int>();

			cardTypes["S"] = 4;
			cardTypes["H"] = 3;
			cardTypes["D"] = 2;
			cardTypes["C"] = 1;

			var power = card.Substring(0, card.Length-1).ToString();
			var type = card.Substring(card.Length - 1).ToString();

			var value = cardPower[power] * cardTypes[type];

			return value;
		}
	}
}
