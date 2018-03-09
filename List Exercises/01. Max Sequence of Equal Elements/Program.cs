using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //numbers.Sort();

            int counter = 1;
            int bestCounter = 0;
            int pos = 0;
            int bestPos = 0;
            bool noBestPos = true;

            List<int> countedNum = new List<int>();
            //countedNum.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                
                if (numbers[i-1] == numbers[i])
                {
                    
                    counter++;
                    if (bestCounter < counter)
                    {
                        bestCounter = counter;
                        bestPos = pos;
                        noBestPos = false;

                    }
                }
                else
                {
                    counter = 1;
                    pos = i;
                }
            }

            if (noBestPos)
            {
                bestCounter = 1;
                bestPos = 0;
            }

            for (int i = bestPos; i < bestPos + bestCounter; i++)
            {
                countedNum.Add(numbers[i]);
            }

            Console.WriteLine(String.Join(" ",countedNum));
        }
    }
}
