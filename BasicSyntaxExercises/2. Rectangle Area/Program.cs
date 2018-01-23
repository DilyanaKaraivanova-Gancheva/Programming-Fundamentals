using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double witdth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double areaTriangle = witdth * height;

            Console.WriteLine($"{areaTriangle:F2}");
        }
    }
}
