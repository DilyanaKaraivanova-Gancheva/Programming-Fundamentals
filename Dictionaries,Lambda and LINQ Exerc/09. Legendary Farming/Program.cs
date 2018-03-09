using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryMaterials = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes",0}

            };

            var junkMaterials = new SortedDictionary<string, int>();
            var obtainedItem = string.Empty;
            var isObtained = false;

            while (!isObtained)
            {
                var input = Console.ReadLine().ToLower().Split(' ');


                for (int i = 0; i < input.Length; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1];

                    if (legendaryMaterials.ContainsKey(material))
                    {
                        legendaryMaterials[material] += quantity;

                        if (legendaryMaterials[material] >= 250)
                        {
                            obtainedItem = GetTheObtainedItem(material);
                            legendaryMaterials[material] -= 250;
                            isObtained = true;
                            break;
                        }

                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }

                }
            }

            Console.WriteLine("{0} obtained!", obtainedItem);

            var sortedMaterials = legendaryMaterials.OrderByDescending(q => q.Value).ThenBy(n => n.Key);

            foreach (var kvp in sortedMaterials)
            {
                PrintOutput(kvp);
            }
            foreach (var kvp in junkMaterials)
            {
                PrintOutput(kvp);
            }
        }

        static void PrintOutput(KeyValuePair<string, int> kvp)
        {
            var materialName = kvp.Key;
            var quantity = kvp.Value;

            Console.WriteLine("{0}: {1}", materialName, quantity);
        }

        static string GetTheObtainedItem(string material)
        {
            var item = string.Empty;
            switch (material)
            {
                case "shards":
                    item = "Shadowmourne";
                    break;
                case "fragments":
                    item = "Valanyr";
                    break;
                case "motes":
                    item = "Dragonwrath";
                    break;

            }
            return item;

        }
    }
}