using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var tex = Console.ReadLine()
                .Split(new char[] 
                { ',',';',':','.','!','(',')','\"', '\'','\\','/', '[',']',' '},StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            int counterLow = 0;
            int counterUpp = 0;

            for (int i = 0; i < tex.Length; i++)
            {
                var word = tex[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] > 96 && word[j] < 123) //== char.ToLower(word[j]))
                    {
                        counterLow++;   
                    }
                    else if(word[j] > 64 && word[j] < 91)//(word[j] == char.ToUpper(word[j]))
                    {
                        counterUpp++; 
                    }
                }
                if (counterLow == word.Length)
                {
                    lowerCase.Add(word);
                }
                else if (counterUpp == word.Length)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
                counterLow = 0;
                counterUpp = 0;
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
