 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			num = num.OrderByDescending(n=>n).Take(3).ToArray();
			Console.WriteLine(string.Join(" ",num));
		}
	}
}
