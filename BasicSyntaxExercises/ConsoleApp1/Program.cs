using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double killometers = miles * 1.60934;

            Console.WriteLine($"{killometers:F2}");
        }
    }
}
