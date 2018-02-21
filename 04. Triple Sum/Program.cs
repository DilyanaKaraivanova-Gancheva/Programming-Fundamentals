using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var ifThereTripleSum = false;
			for (int a = 0; a <= array.Length; a++)
			{
				for (int b = a+1; b < array.Length; b++)
				{
					int sum = array[a] + array[b];
					if (array.Contains(sum))
					{
						ifThereTripleSum = true;
						Console.WriteLine("{0} + {1} == {2}", array[a], array[b], sum);
					}
					//else
					//{
					//	Console.WriteLine("No");
					//}
				}
			}
			if (!ifThereTripleSum)
			{
				Console.WriteLine("No");
			}
		}
	}
}
