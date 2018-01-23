using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int pipeCountEnergy = currentEnergy;
            int dottCountEnergy = maxEnergy - currentEnergy;

            int pipeCountHealth = currentHealth;
            int dottCountHealth = maxHealth - currentHealth;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|",new string('|',pipeCountHealth), new string('.',dottCountHealth));
            Console.WriteLine("Energy: |{0}{1}|",new string('|',pipeCountEnergy), new string('.', dottCountEnergy));
        }
    }
}
