using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            int index = text.IndexOf(pattern);
            int lastIndex = text.LastIndexOf(pattern);

            while (true)
                {
                    if (((index != -1)  && (lastIndex != -1)) && (index != lastIndex) && (pattern != string.Empty))
                    {
                        text = text.Remove(index, pattern.Length);
                        text = text.Remove(lastIndex - pattern.Length, pattern.Length);

                         Console.WriteLine("Shaked it.");

                         pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                    else
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(text);
                        break;
                    }
                index = text.IndexOf(pattern);
                lastIndex = text.LastIndexOf(pattern);

            }
        }
    }
}
