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
            string[] demonsname = Console.ReadLine().Split(new[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string healthPattern = @"[^\d\*\/\+\-\.]";
            string damagePattern = @"\-?\+?\d+\.?\d*";

            SortedDictionary<string, Dictionary<int, double>> demons = new SortedDictionary<string, Dictionary<int, double>>();

            foreach (var name in demonsname)
            {
                int totalHealth = 0;
                double totalDamage = 0.0;

                MatchCollection healthMatches = Regex.Matches(name, healthPattern);
                MatchCollection damageMatches = Regex.Matches(name, damagePattern);

                    foreach (Match health in healthMatches)
                    {
                        totalHealth += char.Parse(health.Value);
                    }
               
                    foreach (Match damage in damageMatches)
                    {
                        totalDamage += double.Parse(damage.Value);
                    }

                    foreach (var symbol in name)
                    {
                        if (symbol == '/')
                        {
                            totalDamage /= 2;
                        }
                        if(symbol == '*')
                        {
                            totalDamage *= 2;
                        }
                    }

                demons[name] = new Dictionary<int, double>();
                demons[name].Add(totalHealth,totalDamage);
            }

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
