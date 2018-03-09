using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int baseN = int.Parse(input[0]);
            int base10 = int.Parse(input[1]);

            List<int> numbers = new List<int>();

            while (base10 != 0)
            {
                int num = (int)base10 % baseN;
                base10 = base10 / baseN;
                numbers.Add(num);

            }

            numbers.Reverse();
            Console.WriteLine(string.Join("",numbers));
        }
    }
}
