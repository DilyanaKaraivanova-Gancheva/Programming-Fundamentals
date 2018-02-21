using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine().ToLower().Split().ToList();
			var resultWords = new Dictionary<string, int>();
			foreach (var word in words)
			{
				if (resultWords.ContainsKey(word))
				{
					resultWords[word]++;
				}
				else
				{
					resultWords[word] = 1;
				}
			}
				var result = new List<string>();

				foreach (var pair in resultWords)
					if (pair.Value % 2 == 1)

						result.Add(pair.Key);

				Console.WriteLine(string.Join(", ", result));
			}
		}
	}

	