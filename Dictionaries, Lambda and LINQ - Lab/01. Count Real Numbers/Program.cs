using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> countedNumbers = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (countedNumbers.ContainsKey(num))
                {
                    countedNumbers[num]++;
                }
                else
                {
                    countedNumbers.Add(num, 1);
                }
            }
            foreach (var pair in countedNumbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }   
        }
    }
}
