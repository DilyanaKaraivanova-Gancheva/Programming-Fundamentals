using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

           // List<int> sumNumbers = new List<int>();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    var sumNumbers = numbers[i - 1] + numbers[i];
                    numbers.Insert(i-1,sumNumbers);
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
