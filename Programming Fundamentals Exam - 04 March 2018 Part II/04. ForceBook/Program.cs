using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
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

                    if (!(users.ContainsKey(forceSide)))
                    {
                        if (users.Values.Count > 0)
                        {
                            foreach (var kvp in users)
                            {
                                if (!(kvp.Value.Contains(forceUser)))
                                {
                                    isTrue = true;
                                }
                            }
                            if (isTrue)
                            {
                                users[forceSide] = new List<string>();
                                users[forceSide].Add(forceUser);
                            }
                        }
                        else
                        {
                            users[forceSide] = new List<string>();
                            users[forceSide].Add(forceUser);
                        }
                    }
                    else
                    {
                        foreach (var kvp in users)
                        {
                            if (!(kvp.Value.Contains(forceUser)))
                            {
                                isTrue = true;
                            }
                        }
                        if (isTrue)
                        {
                            users[forceSide].Add(forceUser);
                        }
                    }
                }
                else
                {
                    var commands = input.Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string forceSide = commands[1].Trim();
                    string forceUser = commands[0].Trim();

                    if (!(users.ContainsKey(forceSide)))
                    {

                        users[forceSide] = new List<string>();

                        foreach (var kvp in users)
                        {
                            if (kvp.Value.Contains(forceUser))
                            {
                                kvp.Value.Remove(forceUser);
                            }
                        }
                        users[forceSide].Add(forceUser);

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var kvp in users)
                        {
                            if (kvp.Value.Contains(forceUser))
                            {
                                kvp.Value.Remove(forceUser);
                            }
                        }
                        users[forceSide].Add(forceUser);

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                input = Console.ReadLine();
            }

            users = users.OrderByDescending(x => users.Values.Count).ThenBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
           
            foreach (var kvp in users)
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
