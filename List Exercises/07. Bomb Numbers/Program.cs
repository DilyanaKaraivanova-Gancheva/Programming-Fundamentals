using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)  // 80/100
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] detonators = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = detonators[0];
            int pow = detonators[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    if ((i-pow)>= 0 && (2*pow + 1) <= numbers.Count-1)
                    {
                        numbers.RemoveRange(Math.Max(i - pow, 0),Math.Min(2 * pow + 1,numbers.Count - 1));
                    }
                    else if ((i-pow) < 0 && (2 * pow + 1) <= numbers.Count - 1)
                    {
                        numbers.RemoveRange(0, i + pow);
                    }
                    else if ((i - pow) >= 0 && (2*pow + 1) > numbers.Count -1)
                    {
                        numbers.RemoveRange(i - pow, (numbers.Count - (i - pow)));
                    }
                    else
                    {
                        numbers.RemoveRange(0,numbers.Count);
                    }
                    i--;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
