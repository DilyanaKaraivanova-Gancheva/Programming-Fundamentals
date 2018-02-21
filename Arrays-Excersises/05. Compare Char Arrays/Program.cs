using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int length = Math.Min(firstArr.Length, secondArr.Length);
            bool isTrue = true;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    continue;
                }

                if (firstArr[i] > secondArr[i])
                {
                    isTrue = false;
                    Console.WriteLine(String.Join("",secondArr));
                    Console.WriteLine(String.Join("", firstArr));
                    break;
                }
                else if(firstArr[i] < secondArr[i])
                {
                    isTrue = false;
                    Console.WriteLine(String.Join("", firstArr));
                    Console.WriteLine(String.Join("", secondArr));
                    break;
                }

            }
            if (isTrue && firstArr.Length >=secondArr.Length)
            {
                Console.WriteLine(String.Join("", secondArr));
                Console.WriteLine(String.Join("", firstArr));
            }
            else if(isTrue && firstArr.Length <= secondArr.Length)
            {
                Console.WriteLine(String.Join("", firstArr));
                Console.WriteLine(String.Join("", secondArr));
            }
        }
    }
}
