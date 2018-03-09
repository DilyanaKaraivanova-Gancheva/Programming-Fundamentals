
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
            var input = Console.ReadLine().Split(':');

            var handsOfCards = new Dictionary<string, List<string>>();

            while (input[0] != "JOKER")
            {
                var name = input[0];
                var cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!handsOfCards.ContainsKey(name))
                {
                    handsOfCards[name] = cards;
                }
                else
                {
                    handsOfCards[name] = handsOfCards[name].Concat(cards).ToList();
                }
                handsOfCards[name] = handsOfCards[name].Distinct().ToList();

                input = Console.ReadLine().Split(':');
            }
            foreach (var name in handsOfCards)
            {
                var sum = CalculateSum(name);
                Console.WriteLine("{0}: {1}", name.Key, sum);
            }
        }

        static int CalculateSum(KeyValuePair<string, List<string>> name)
        {
            var sum = 0;

            foreach (var card in name.Value)
            {
                var typeOfCard = card[1];
                var powerOfCard = card[0].ToString();

                if (card.Length == 3)
                {
                    typeOfCard = card[2];
                    powerOfCard = "10";
                }
                var value = 0;

                switch (typeOfCard)
                {
                    case 'S':
                        value = 4;
                        break;
                    case 'H':
                        value = 3;
                        break;
                    case 'D':
                        value = 2;
                        break;
                    case 'C':
                        value = 1;
                        break;
                }
                var power = 0;
                var isNumber = int.TryParse(powerOfCard, out power);

                if (!isNumber)
                {
                    switch (powerOfCard)
                    {
                        case "J":
                            power = 11;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "A":
                            power = 14;
                            break;

                    }
                }
                sum += value * power;
            }
            return sum;
        }
    }
}