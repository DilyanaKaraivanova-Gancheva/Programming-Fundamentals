using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}";

            MatchCollection matches = Regex.Matches(text, pattern);

            var phoneMatches = matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",phoneMatches));
        }
    }
}
