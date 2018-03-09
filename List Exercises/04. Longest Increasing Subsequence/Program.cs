using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = new int[nums.Length];
            var prev = new int[nums.Length];

            var bestLenght = 0;
            var lastIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                var anchorNum = nums[i];

                for (int j = 0; j < i; j++)
                {
                    var currentNum = nums[j];
                    if (currentNum < anchorNum && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
                if (len[i] > bestLenght)
                {
                    bestLenght = len[i];
                    lastIndex = i;
                }
            }
            var result = new List<int>();

            while (lastIndex != -1)
            {
                result.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));

         

        }
    }
}