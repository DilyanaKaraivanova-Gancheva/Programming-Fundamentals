using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] days = {
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday",
			};
			int numberOfDay = int.Parse(Console.ReadLine());

			if (numberOfDay>= 1 && numberOfDay<=7)
			{
				Console.WriteLine(days[numberOfDay-1]);
			}
			else
			{
				Console.WriteLine("Invalid Day!");
			}
		}
	}
}
