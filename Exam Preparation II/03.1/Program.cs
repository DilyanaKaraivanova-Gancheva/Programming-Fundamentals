using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonsname = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string healthPattern = @"[^\d\*\/\+\-\.]";
            string damagePattern = @"\-?\+?\d+\.?\d*";
            string multyDivPattern = @"[\/\*]";
            int totalHealth = 0;
            double totalDamage = 0.0;
            Dictionary<string, Dictionary<int, double>> demons = new Dictionary<string, Dictionary<int, double>>();
            List<char> multyDivList = new List<char>();

            foreach (var name in demonsname)
            {
                MatchCollection healthMatches = Regex.Matches(name, healthPattern);
                MatchCollection damageMatches = Regex.Matches(name, damagePattern);
                MatchCollection multyDivMatches = Regex.Matches(name, multyDivPattern);

                if (healthMatches.Count > 0)
                {
                    foreach (Match health in healthMatches)
                    {
                        totalHealth += char.Parse(health.Value);
                    }
                }

                if (damageMatches.Count > 0)
                {
                    foreach (Match damage in damageMatches)
                    {
                        totalDamage += double.Parse(damage.Value);
                    }
                }

                if (multyDivMatches.Count > 0)
                {
                    foreach (Match symbol in multyDivMatches)
                    {
                        if (char.Parse(symbol.Value) == '/' && totalDamage != 0)
                        {
                            totalDamage /= 2;
                        }
                        if (char.Parse(symbol.Value) == '*')
                        {
                            totalDamage *= 2;
                        }
                    }
                }
                demons[name] = new Dictionary<int, double>();
                demons[name].Add(totalHealth, totalDamage);

                totalHealth = 0;
                totalDamage = 0;
            }

            demons = demons.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var demon in demons)
            {
                foreach (var kvp in demon.Value)
                {
                    Console.WriteLine($"{demon.Key} - {kvp.Key} health, {kvp.Value:F2} damage");
                }
            }
        }
    }
}
