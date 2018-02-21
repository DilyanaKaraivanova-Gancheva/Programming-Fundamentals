using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();

			var phonebook = new Dictionary<string, string>();

			while (input[0] != "END")
			{
				//var name = input[1];

				if (input[0]=="A")
				{
					var name = input[1];
					var phone = input[2];
					phonebook[name]=phone;
				}
				else if (input[0]=="S")
				{
					var name = input[1];
					if (phonebook.ContainsKey(name))
					{
						Console.WriteLine($"{name} -> {phonebook[name]}");
					}
					else
					{
						Console.WriteLine($"Contact {name} does not exist.");
					}
				}
				//else if (input[0]=="END")
				//{
				//	break;
				//}
				input = Console.ReadLine().Split();
			}
		}
	}
}
