using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int firstLength = firstArray.Length;
			int secondLength = secondArray.Length;

			 int[] sumArray= new int[Math.Max(firstLength,secondLength)];

			for (int i = 0; i < sumArray.Length; i++) 
			{
				sumArray[i] = firstArray[i%firstLength] + secondArray[i%secondLength];
			}
			Console.WriteLine(string.Join(" ",sumArray));
		}
	}
}
