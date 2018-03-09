using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> possitive = new List<int>();
            bool isPossitive = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    isPossitive = true;
                    possitive.Add(numbers[i]);
                }
            }
            possitive.Reverse();
            if (isPossitive)
            {
                Console.WriteLine(String.Join(" ", possitive));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
