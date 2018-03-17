using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long daysOfMarathon = long.Parse(Console.ReadLine());
            long numberOfParticipants = long.Parse(Console.ReadLine());
            long numberOfLapsPerParticipant = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            double amauntOfMoney = double.Parse(Console.ReadLine());

            long maxRunners = Math.Min(numberOfParticipants, capacityOfTrack * daysOfMarathon);
            long totalMeters = maxRunners * numberOfLapsPerParticipant * lengthOfTrack;
            long totalKilometers = totalMeters / 1000;

            double raisedMoney = amauntOfMoney * totalKilometers;

            Console.WriteLine("Money raised: {0:f2}",raisedMoney);

        }
    }
}
