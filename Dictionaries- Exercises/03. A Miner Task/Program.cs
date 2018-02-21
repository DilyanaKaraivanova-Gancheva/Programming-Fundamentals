using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			var resourcesQuantities = new Dictionary<string,decimal>();
			
			var resource = Console.ReadLine();
			
			while (resource != "stop")
			{
				var quatity = decimal.Parse(Console.ReadLine());

				if (!resourcesQuantities.ContainsKey(resource))
				{
					resourcesQuantities[resource] = 0;
				}
				resourcesQuantities[resource] += quatity;
				
				resource= Console.ReadLine();
			}

			foreach (var resourceQuantity in resourcesQuantities)
			{
				Console.WriteLine($"{resourceQuantity.Key} -> {resourceQuantity.Value}");
			}



		}
	}
}
