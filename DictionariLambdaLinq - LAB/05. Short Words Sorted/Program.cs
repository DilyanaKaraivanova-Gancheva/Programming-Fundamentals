using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] saparators = new char[]
			{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

			string[] words = Console.ReadLine().ToLower().Split(saparators).ToArray();

			words = words.Where(w=> w != "").Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToArray();

			Console.WriteLine(string.Join(", ",words));
		}
	}
}
