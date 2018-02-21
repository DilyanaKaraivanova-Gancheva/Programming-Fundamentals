using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] symbol = Console.ReadLine().Split();//.ToArray();
			int last = symbol.Length - 1;

			for (int i = 0; i <symbol.Length/2 ; i++)
			{
				var current = symbol[i];
				symbol[i] = symbol[last];
				symbol[last] = current;
				last--;

				//Console.Write(string.Join("- ", symbol[i]));
				//Console.Write(symbol[i] +" ");
			
			}
			Console.WriteLine(string.Join(" ",symbol));
		}
	}
}
