using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (oddWords.ContainsKey(word))
                {
                    oddWords[word]++;
                }
                else
                {
                    oddWords[word] = 1;
                }
            }
            List<string> result = new List<string>();

            foreach (var pairs in oddWords)
            {
                if (pairs.Value % 2 == 1)
                {
                    result.Add(pairs.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));

        }
    }
}
