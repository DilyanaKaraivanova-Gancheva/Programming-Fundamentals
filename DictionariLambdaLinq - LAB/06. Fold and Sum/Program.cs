using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int k = nums.Length / 4;
			int[] leftSide=nums.Take(k).Reverse().ToArray();
			int[] rightSide = nums.Reverse().Take(k).ToArray();
			int[] firstRow = leftSide.Concat(rightSide).ToArray();

			int[] secondRow = nums.Skip(k).Take(2 * k).ToArray();

			var result = firstRow.Select((x, index) => x + secondRow[index]);

			Console.WriteLine(string.Join(" ",result));


		}
	}
}
