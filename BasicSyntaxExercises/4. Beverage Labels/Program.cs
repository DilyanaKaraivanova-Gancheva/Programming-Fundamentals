using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyContentPer100 = double.Parse(Console.ReadLine());
            double sugarContentPer100 = double.Parse(Console.ReadLine());

            double energyContent = (energyContentPer100 / 100) * volume;
            double sugarContent = (sugarContentPer100 / 100) * volume;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");

        }
    }
}
