using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] rotatedArr = new int[arr.Length];

            int countRotate = int.Parse(Console.ReadLine());

            
            int lastElement = 0;

            for (int i = 0; i < countRotate; i++)
            {
                lastElement = arr[arr.Length - 1];

                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                    rotatedArr[j] += arr[j];
                }

                arr[0] = lastElement;
                rotatedArr[0] += arr[0];  
            }
            Console.WriteLine(String.Join(" ", rotatedArr));
        }
    }
}
