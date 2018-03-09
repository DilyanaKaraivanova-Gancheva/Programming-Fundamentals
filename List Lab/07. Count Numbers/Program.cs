using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)  //  100/100
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            numbers.Sort();

            int counter = 1;
            int currentNum = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                //currentNum = numbers[i];

                if (currentNum == numbers[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNum} -> {counter}");
                    counter = 1;
                    currentNum = numbers[i];
                    
                }  
            }
            Console.WriteLine($"{currentNum} -> {counter}");
        }
    }
}
