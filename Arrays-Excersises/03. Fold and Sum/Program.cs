using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] arrMiddle = numbers.Skip(k).Take(2*k).ToArray();
            int[] arrLeft = numbers.Take(k).ToArray();
            int[] arrRight = numbers.Skip(3 * k).Take(k).ToArray();

            arrLeft = arrLeft.Reverse().ToArray();
            arrRight = arrRight.Reverse().ToArray();

            int[] arrConcat = arrLeft.Concat(arrRight).ToArray();

            for (int i = 0; i < 2*k; i++)
            {
                arrConcat[i] += arrMiddle[i];
            }
            Console.WriteLine(String.Join(" ",arrConcat));



        }
    }
}
