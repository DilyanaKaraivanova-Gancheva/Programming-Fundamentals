using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            List<int> reverstNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                char[] charTo = numbers[i].ToCharArray();
                char[] reversedChars = charTo.Reverse().ToArray();

                reverstNums.Add(int.Parse(string.Join("",reversedChars)));
            }

            Console.WriteLine(reverstNums.Sum());
        }
    }
}
