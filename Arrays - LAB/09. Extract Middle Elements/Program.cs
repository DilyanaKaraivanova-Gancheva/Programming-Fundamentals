using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			//int[] numsMiddle = new int[numbers.Length];
			if (numbers.Length==1)
			{
				Console.WriteLine(numbers[0]);
			}
			else if (numbers.Length%2==0)
			{
				var numsMiddle = new int[2];
				numsMiddle[0] =numbers[ numbers.Length / 2 - 1];
				numsMiddle[1] = numbers[numbers.Length / 2];

				Console.WriteLine("{{ {0} }}", string.Join(", ", numsMiddle));
			}
			else if (numbers.Length%2==1)
			{
				var numsMiddle = new int[3];
				numsMiddle[0] =numbers[numbers.Length / 2 - 1];
				numsMiddle[1] = numbers[numbers.Length / 2];
				numsMiddle[2] =numbers[numbers.Length / 2 + 1];

				Console.WriteLine("{{ {0} }}", string.Join(", ", numsMiddle));
			}
		
			//Console.WriteLine("{{ 0 }}",string.Join(", ",numsMiddle));
		}
	}
}
