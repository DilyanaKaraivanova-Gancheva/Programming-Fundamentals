using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromsList = new List<string>();

            foreach (var word in text)
            {
                string reversed = new string(word.Reverse().ToArray());

                if (word.CompareTo(reversed) == 0)
                {
                    palindromsList.Add(word);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromsList.Distinct().OrderBy(x => x).ToList()));
        }
    }
}
