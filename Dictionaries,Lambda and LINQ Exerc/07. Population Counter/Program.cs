using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!(populationCounter.ContainsKey(country)))
                {
                    populationCounter[country] = new Dictionary<string, long>();
                    populationCounter[country][city] = population;
                }
                else
                {
                    populationCounter[country][city] = population;
                }

                input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var sortedPopulationCounter = populationCounter.OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var pair in sortedPopulationCounter)
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                var sortedCities = pair.Value.OrderByDescending(x => x.Value);

                foreach (var v in sortedCities)
                {
                    Console.WriteLine($"=>{v.Key}: {v.Value}");
                }
            }
        }
    }
}
