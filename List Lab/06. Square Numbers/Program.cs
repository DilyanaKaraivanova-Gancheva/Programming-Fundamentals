using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> squaredNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squaredNums.Add(numbers[i]);
                }
            }

            squaredNums.Sort((num1,num2) => num2.CompareTo(num1));

            Console.WriteLine(string.Join(" ", squaredNums));
        }
    }
}
