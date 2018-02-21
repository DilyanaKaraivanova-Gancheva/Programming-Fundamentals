using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
	
			while (arr.Length != 1)
			{
				int[] condensedArr = new int[arr.Length - 1];

				for (int i = 0; i < condensedArr.Length; i++)
				{
					condensedArr[i] = arr[i] + arr[i + 1];
				}
				arr = condensedArr;
			}
			Console.WriteLine(string.Join(" ", arr));
		}
		
	}
}
