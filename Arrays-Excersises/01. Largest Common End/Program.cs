using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();
            int length = Math.Min(firstArr.Length, secondArr.Length);
            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftCounter++;
                }
                continue;
            }

            firstArr = firstArr.Reverse().ToArray();
            secondArr = secondArr.Reverse().ToArray();

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    rightCounter++;
                }
                continue;
            }

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }
    }
}
