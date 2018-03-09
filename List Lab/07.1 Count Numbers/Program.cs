using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)  // 100/100
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            numbers.Sort();

            int counter = 1;
            int currentNum = numbers[0];
            numbers.RemoveAt(0);

            foreach (var num in numbers)
            {
                if (num == currentNum)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNum} -> {counter}");
                    counter = 1;
                    currentNum = num;
                }
            }
            Console.WriteLine($"{currentNum} -> {counter}");
        }
    }
}
