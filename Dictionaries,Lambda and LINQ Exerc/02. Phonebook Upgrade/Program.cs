using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string phoneNumber = input[2];

                    if (phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = phoneNumber;
                    }
                    else
                    {
                        phoneBook.Add(name, phoneNumber);
                    }
                }
                else if (input[0] == "S")
                {
                    string name = input[1];
                    if (!(phoneBook.ContainsKey(name)))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        foreach (var pair in phoneBook)
                        {
                            if (name == pair.Key)
                            {
                                Console.WriteLine($"{pair.Key} -> {pair.Value}");
                            }
                        }
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var pair in phoneBook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
