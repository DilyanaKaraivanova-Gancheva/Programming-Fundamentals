using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] num = ReadNums();
			double[] roundedNums = new double[num.Length];
			for (int i = 0; i < num.Length; i++)
			{
				roundedNums[i] = (double)Math.Round(num[i],MidpointRounding.AwayFromZero);
			}
			for (int i = 0; i < num.Length; i++)
			{
				Console.WriteLine($"{num[i]}->{roundedNums[i]}");
			}
		}

		private static double[] ReadNums()
		{
			double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			return nums;
		}
	}
}
