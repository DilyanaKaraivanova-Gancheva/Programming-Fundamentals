using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCount = 0;
            int count = 1;
            int freaquant = 0;
            int mostFreaquent = 0;

            numbers = numbers.OrderBy(x => x).ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    count++;
                    if (bestCount < count)
                    {
                        bestCount = count;
                        mostFreaquent = freaquant;
                    }
                }
                else
                {
                    count = 1;
                    freaquant = i;
                }
            }
            Console.WriteLine(numbers[mostFreaquent]);
        }
    }
}
