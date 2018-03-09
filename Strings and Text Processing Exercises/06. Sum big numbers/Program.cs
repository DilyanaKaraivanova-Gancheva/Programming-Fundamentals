using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine();

            var result = string.Empty;
            var longerNum = string.Empty;
            var shortNum = string.Empty;


            if (firstNum.Length > secondNum.Length)
            {
                longerNum = firstNum;
                shortNum = secondNum;
            }
            else
            {
                longerNum = secondNum;
                shortNum = firstNum;
            }


            var remainder = 0;
            var index = shortNum.Length - 1;
            for (int i = longerNum.Length - 1; i >= 0; i--)
            {
                if (index < 0)
                {
                    var num = (int)longerNum[i] - 48 + remainder;
                    result += (num % 10);
                    remainder = num / 10;
                }
                else
                {
                    var num = ((int)(longerNum[i]) - 48 + (int)(shortNum[index]) - 48 + remainder);
                    result += (num % 10);
                    index--;
                    remainder = num / 10;
                }
            }
            if (remainder > 0)
            {
                result += remainder;
            }
            result = new string(result.Reverse().ToArray()).TrimStart('0');

            Console.WriteLine(result);
        }
    }
}