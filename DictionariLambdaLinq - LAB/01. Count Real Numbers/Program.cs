using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
			var counts = new SortedDictionary<double, int>();
			foreach (var num in nums)
			{
				if (counts.ContainsKey(num))
				{
					counts[num]++;
				}
				else
				{
					counts[num] = 1;
				}
			}
			foreach (var num in counts.Keys)
			{
				Console.WriteLine($"{num} -> { counts[num]}");
			}
		}
	}
}
