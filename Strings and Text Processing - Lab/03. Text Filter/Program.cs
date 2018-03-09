using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            
            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                  text = text.Replace(bannedWords[i], new String('*', bannedWords[i].Length));
                }    
            }
            Console.WriteLine(text);
        }
    }
}
