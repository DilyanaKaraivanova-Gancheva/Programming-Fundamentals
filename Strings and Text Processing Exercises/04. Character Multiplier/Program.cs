using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];
            int length = Math.Min(firstWord.Length,secondWord.Length);
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                result += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    result += firstWord[i];
                }
            }
            else
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    result += secondWord[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
