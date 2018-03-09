using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            long countOfStudents = long.Parse(Console.ReadLine());
            double priceOflightsabers = double.Parse(Console.ReadLine());
            double priceOfrobes = double.Parse(Console.ReadLine());
            double priceOfbelts = double.Parse(Console.ReadLine());

            double totalPriceOfBelts = priceOfbelts;
            double moreCountOfStudents = countOfStudents + (Math.Ceiling(countOfStudents * 0.1));
            double neededMoney = 0;

            // + 0.1;

            if (countOfStudents / 6 > 0)
            {
                 long lessCountOfStudents = countOfStudents - (countOfStudents / 6);

               neededMoney = (priceOflightsabers * moreCountOfStudents) + (lessCountOfStudents * priceOfbelts) +(countOfStudents * priceOfrobes);
            }
            else
            {
                neededMoney = (priceOflightsabers * moreCountOfStudents) + (countOfStudents * (priceOfrobes + priceOfbelts));
            }

            if (money >= neededMoney)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.", neededMoney);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.", neededMoney - money);
            }
        }
    }
}
