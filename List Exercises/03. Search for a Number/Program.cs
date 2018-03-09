using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] numsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int takeNums = numsArr[0];
            int deleteNums = numsArr[1];
            int searchNum = numsArr[2];

            List<int> manupNums = new List<int>();

            manupNums = numbers.Take(takeNums).ToList();
            manupNums.RemoveRange(0, deleteNums);

            if (manupNums.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
