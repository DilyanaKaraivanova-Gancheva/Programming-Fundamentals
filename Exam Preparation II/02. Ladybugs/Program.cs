using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split(new[] {' ','\n','\t'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] ladyBugs = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i))
                {
                    ladyBugs[i] = 1;
                }
                else
                {
                    ladyBugs[i] = 0;
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                if (commands[0] == "end")
                {
                    break;
                }

                int currentIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if (currentIndex < 0 || currentIndex >= size)
                {
                    continue;
                }
                if (ladyBugs[currentIndex] == 0)
                {
                    continue;
                }

                ladyBugs[currentIndex] = 0;
                while (true)
                {
                    if (direction == "right")
                    {
                        currentIndex += flyLength;
                    }
                    else
                    {
                        currentIndex -= flyLength;
                    }
                    if (currentIndex < 0 || currentIndex >= size)
                    {
                        break;
                    }
                    if (ladyBugs[currentIndex] == 0)
                    {
                        ladyBugs[currentIndex] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",ladyBugs));
        }
    }
}
