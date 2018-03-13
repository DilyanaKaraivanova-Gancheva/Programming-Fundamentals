using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> users = new Dictionary<string, string>();
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            bool isTrue = false;

            while (true)
            {
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    var commands = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    string forceSide = commands[0].Trim();
                    string forceUser = commands[1].Trim();

                    if (!(users.ContainsKey(forceUser)))
                    {
                        users[forceUser] = forceSide;

                        if (!forces.ContainsKey(forceSide))
                        {
                            forces[forceSide] = new List<string>();
                        }
                        forces[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    var commands = input.Split(new[] { "->"}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string forceSide = commands[1].Trim();
                    string forceUser = commands[0].Trim();

                    if (!(users.ContainsKey(forceUser)))
                    {
                        users[forceUser] = forceSide;

                        if (!forces.ContainsKey(forceSide))
                        {
                            forces[forceSide] = new List<string>();
                        }
                        forces[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (users[forceUser] != forceSide)
                        {
                            forces[users[forceUser]].Remove(forceUser);

                            if (!forces.ContainsKey(forceSide))
                            {
                                forces[forceSide] = new List<string>();
                            }

                            forces[forceSide].Add(forceUser);
                            users[forceUser] = forceSide;
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }

                }
                input = Console.ReadLine();
            }
            forces = forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in forces)
            {

                if (kvp.Value.Count == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    kvp.Value.Sort();

                    foreach (var value in kvp.Value)
                    {
                        Console.WriteLine($"! {value}");
                    }
                }

            }
        }
    }
}
