using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine();

            if (secondNum == "0")
            {
                Console.WriteLine("0");
                return;
            }
            var sb = new StringBuilder();

            var remainder = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {

                var num = int.Parse(firstNum[i].ToString()) * int.Parse(secondNum) + remainder;
                sb.Append(num % 10);
                remainder = num / 10;
            }
            if (remainder > 0)
            {
                sb.Append(remainder);
            }
            var result = new string(sb.ToString().Reverse().ToArray());
            result = result.TrimStart('0');
            Console.WriteLine(result);

        }
    }
}