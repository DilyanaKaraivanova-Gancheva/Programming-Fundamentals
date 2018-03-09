using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _03.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMessages = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;
            int attackedPlanets = 0;
            int destroyedPlanets = 0;
            List<Match> destroyedResult = new List<Match>();
            List<Match> attackedResult = new List<Match>();
            List<string> groupNamePlanet = new List<string>();

            for (int i = 0; i < countMessages; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                int count = 0;
                List<double> charToNum = new List<double>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 's' || input[j] == 'S' 
                        || input[j] == 't' || input[j] == 'T' 
                        || input[j] == 'a' || input[j] == 'A'
                        || input[j] == 'r' || input[j] == 'R')
                    {
                        count++;
                    }
                }
                for (int k = 0; k < input.Length; k++)
                {
                    double charNum =((input[k])) - count;
                    charToNum.Add(charNum);
                }

                var decryptedCharMessage = charToNum.Select(x => (char)x).ToArray();

                decryptedMessage = new string(decryptedCharMessage);

                string pattern = @"[^\@\-!:>]*@(?<planetName>[a-zA-Z]+)[^\@\-!:>]*:(?<planetPopulation>[0-9]+)[^\@\-!:>]*!(?<attackType>A|D)![^\@\-!:>]*->(?<soldierCount>[0-9]+)[^\@\-!:>]*";

                MatchCollection matches = Regex.Matches(decryptedMessage, pattern);
              
                foreach (Match m in matches)
                {
                    if (m.Groups[3].Value == "D")
                    {
                        destroyedPlanets++;
                        destroyedResult.Add(m);
                    }
                    else
                    {
                        attackedPlanets++;
                        attackedResult.Add(m);
                    }
                }
            }

            Console.WriteLine($"Attacked  planets: {attackedResult.Count}");
            foreach (Match attacked in attackedResult)
            {
                groupNamePlanet.Add(attacked.Groups[1].Value);
            }

            groupNamePlanet.Sort();
            foreach (var name in groupNamePlanet)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedResult.Count}");
            groupNamePlanet.Clear();

            foreach (var dest in destroyedResult)
            {
                groupNamePlanet.Add(dest.Groups[1].Value);
            }

            groupNamePlanet.Sort();
            foreach (var name in groupNamePlanet)
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
