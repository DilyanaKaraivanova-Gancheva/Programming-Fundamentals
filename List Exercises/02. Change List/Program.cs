using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> inputs = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while (inputs[0] != "Odd" && inputs[0] != "Even")
            {
 
                if (inputs[0] == "Delete")
                {
                    int number = int.Parse(inputs[1]);
                    numbers.RemoveAll(num => num == number);
                }
                else 
                {
                    int number = int.Parse(inputs[1]);
                    int numberPos = int.Parse(inputs[2]);

                    numbers.Insert(numberPos, number);
                }

                inputs = Console.ReadLine().Split().ToList();
            }

            foreach (var num in numbers)
            {
                if (inputs[0] == "Odd")
                {
                    if (num % 2 == 1)
                    {
                        Console.Write($"{num} ");
                    } 
                }
                else
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            Console.WriteLine();


        }
    }
}
