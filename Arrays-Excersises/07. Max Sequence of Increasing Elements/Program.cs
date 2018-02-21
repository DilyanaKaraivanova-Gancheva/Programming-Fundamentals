using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestPos = 0;
            int bestLenght = 0;
            int pos = 0;
            int counter = 1;
            var bestSeq = new int[bestLenght];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] < numbers[i])
                {
                    counter++;
                    if (bestLenght < counter)
                    {
                        bestPos = pos;
                        bestLenght = counter;
                        
                    }
                }
                else
                {
                    counter = 1;
                    pos = i;
                    continue;
                }
            }
            for (int i = bestPos; i < bestPos + bestLenght; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
