using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();
            //char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p',
            //'q','r','s','t','u','v','w','x','y','z'};

            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                counter = (word[i] - 97);

                Console.WriteLine($"{word[i]} -> {counter}");
            }
        }
    }
}
