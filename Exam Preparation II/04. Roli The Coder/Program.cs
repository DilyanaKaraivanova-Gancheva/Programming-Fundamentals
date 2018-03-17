using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> idEventName = new Dictionary<int, string>();
            Dictionary<string, List<string>> eventNameParticipants = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                int id = 0;
                if (!int.TryParse(tokens[0], out id))
                {
                    continue;
                }
                string eventName = tokens[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }

                eventName = eventName.Trim('#');

                List<string> participants = new List<string>();
                var ignoreParticipants = false;

                    for (int i = 2; i < tokens.Length; i++)
                    {
                    if (!tokens[i].StartsWith("@"))
                    {
                        ignoreParticipants = true;
                        break;
                    }
                    else
                    {
                        participants.Add(tokens[i]);
                    }
                       
                    }
                if (ignoreParticipants)
                {
                    continue;
                }

                participants = participants.Distinct().ToList();

                if (!idEventName.ContainsKey(id))
                {
                    idEventName[id] = eventName;
                    eventNameParticipants[eventName] = new List<string>(participants);
                }
                else
                {
                    if (idEventName[id] == eventName)
                    {
                        if (eventNameParticipants.ContainsKey(eventName))
                        {
                            eventNameParticipants[eventName].AddRange(participants);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            eventNameParticipants = eventNameParticipants.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in eventNameParticipants)
            {
                 var distincted = kvp.Value.Distinct().ToList();

                Console.WriteLine($"{kvp.Key} - {distincted.Count}");

                distincted.Sort();
                foreach (var value in distincted)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
