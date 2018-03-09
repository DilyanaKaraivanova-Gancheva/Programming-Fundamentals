using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] leftNumbers = numbers.Take(k).Reverse().ToArray();
            int[] middleNumbers = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightNumbers = numbers.Skip(3 * k).Take(k).Reverse().ToArray();

            int[] concatNumbers = leftNumbers.Concat(rightNumbers).ToArray();
            int[] sumNumbers = concatNumbers.Select((num1, num2) => num1 + middleNumbers[num2]).ToArray();

            Console.WriteLine(String.Join(" ", sumNumbers));

        }
    }
}
