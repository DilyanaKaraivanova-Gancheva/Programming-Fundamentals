using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstWord = input[0];
            string secondWord = input[1];

            int length = Math.Min(firstWord.Length,secondWord.Length);
            bool isExchangeable = true;
            Dictionary<char, char> exchangeable = new Dictionary<char, char>();

            for (int i = 0; i < length; i++)
            {
                if (!(exchangeable.ContainsKey(firstWord[i])) && (!exchangeable.ContainsValue(secondWord[i])))
                {
                    exchangeable[firstWord[i]] = secondWord[i];
                }
                else
                {
                    if (!(exchangeable[firstWord[i]]==(secondWord[i])))
                    {
                        isExchangeable = false;

                        break;
                    }
                }
            }
            if (firstWord.Length < secondWord.Length)
            {
                for (int j = firstWord.Length; j < secondWord.Length; j++)
                {
                    if (!(exchangeable.ContainsValue(secondWord[j])))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }
            else
            {
                for(int j = secondWord.Length; j < firstWord.Length; j++)
                {
                    if (!(exchangeable.ContainsKey(firstWord[j])))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }  
    }
}
