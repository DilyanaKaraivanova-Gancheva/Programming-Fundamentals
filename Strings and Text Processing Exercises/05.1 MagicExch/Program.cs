using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1_MagicExch
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().Select(a => a.ToCharArray().Distinct().ToArray()).ToArray();

            int firstLength = input.First().Length;

            Console.WriteLine(input.All( x => x.Length == firstLength).ToString().ToLower());
        }
    }
}
