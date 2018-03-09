using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> namesEmails = new Dictionary<string, string>();

            while (true)
            {
                if (input == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (!(namesEmails.ContainsKey(input)))
                {
                    if (!(email.EndsWith("us") || email.EndsWith("uk")))
                    {
                        namesEmails.Add(input, email);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var pair in namesEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
