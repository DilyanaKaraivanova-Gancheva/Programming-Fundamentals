using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var baseN = readNumbers[0];
            var base10num = readNumbers[1];
            var resultNumbers = new BigInteger();
            var pow = 0;

            while (base10num!=0)
            {
                var lastDigit = base10num % 10;
                resultNumbers += lastDigit * BigInteger.Pow(baseN,pow);
                base10num = base10num / 10;
                pow++;
            }
            Console.WriteLine(resultNumbers);

        }
    }
}
