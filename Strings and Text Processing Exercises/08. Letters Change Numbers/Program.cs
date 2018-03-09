using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new[] { ' ','\n','\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            List<decimal> totalSum = new List<decimal>();

            decimal result = 0;
            var textNum = "";
            int count = 1;

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i, count);

                count++;
            }

            for (int i = 0; i < text.Length; i++)
            {
                char firstLetter = text[i].First();

                textNum = string.Join("", text[i].Where(char.IsDigit));

                    if (firstLetter == char.ToUpper(firstLetter))
                    {
                        foreach (var letter in alphabet)
                        {
                            if (letter.Key == char.ToLower(firstLetter))
                            {
                                result += decimal.Parse(textNum) / letter.Value;
                            break;
                            }
                        }
                    }
                    else
                    {
                        foreach (var letter in alphabet)
                        {
                            if (letter.Key == char.ToLower(firstLetter))
                            {
                                result += decimal.Parse(textNum) * letter.Value;
                            break;
                            }
                        }
                    }

                char last = text[i].Last();

                if (last == char.ToUpper(last))
                {
                    foreach (var letter in alphabet)
                    {
                        if (letter.Key == char.ToLower(last))
                        {
                            result -= letter.Value;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var letter in alphabet)
                    {
                        if (letter.Key == char.ToLower(last))
                        {
                            result += letter.Value;
                            break;
                        }
                    }
                }

                totalSum.Add(result);
                result = 0;
                    }
                        Console.WriteLine("{0:f2}", totalSum.Sum());
        }
            }
        }
