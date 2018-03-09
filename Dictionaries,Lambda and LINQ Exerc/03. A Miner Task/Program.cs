using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> mineResource = new Dictionary<string, int>();

            while (true)
            {
                if (input == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!(mineResource.ContainsKey(input)))
                {
                    mineResource.Add(input, quantity);
                }
                else
                {
                    mineResource[input] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in mineResource)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
