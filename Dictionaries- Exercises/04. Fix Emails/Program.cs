using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
	class Program
	{
		static void Main(string[] args)
		{
			var namesEmails = new Dictionary<string, string>();
			var input = Console.ReadLine();

			while (input!="stop")
			{
				var name = input;
				var email = Console.ReadLine();
				namesEmails[name] = email;

				input = Console.ReadLine();
			}
				var fixedEmails= namesEmails.Where(v => !(v.Value.EndsWith("us") || 
				v.Value.EndsWith("uk"))).
					ToDictionary(kpv=>kpv.Key,kpv=>kpv.Value);

			foreach (var nameEmail in fixedEmails)
			{
				var name = nameEmail.Key;
				var emails= nameEmail.Value;
				Console.WriteLine($"{name} -> {emails}");
			}
		}
	}
}
