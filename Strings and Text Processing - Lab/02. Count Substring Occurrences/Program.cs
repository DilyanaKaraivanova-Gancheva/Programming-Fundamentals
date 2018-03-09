using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int searchedWord = text.IndexOf(word);
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (searchedWord != -1)
                {
                    counter++;
                    searchedWord = text.IndexOf(word,searchedWord + 1);
                }
            }
            Console.WriteLine(counter);
        }
    }
}
