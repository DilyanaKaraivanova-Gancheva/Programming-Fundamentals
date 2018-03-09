using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";

            MatchCollection matches = Regex.Matches(names, pattern);

            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
