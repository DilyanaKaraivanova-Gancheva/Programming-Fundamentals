using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCount = 0;
            int[] sequance1 = new int[bestCount];
            int counter = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    counter++;
                    if (bestCount < counter)
                    {
                        bestCount = counter;
                        sequance1 = new int[bestCount];
                        for (int j = 0; j < bestCount; j++)
                        {
                            sequance1[j] = numbers[i];
                        }
                        //sequance1[bestCount-i] = numbers[i];

                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(String.Join(" ", sequance1));
        }
    }
}
