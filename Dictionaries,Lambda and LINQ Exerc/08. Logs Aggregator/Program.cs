using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] tokens = new string[n];

            SortedDictionary<string, SortedDictionary<string, int>> logsAggregator = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                tokens = Console.ReadLine().Split();
                string ip = tokens[0];
                string name = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (!(logsAggregator.ContainsKey(name)))
                {
                    logsAggregator[name] = new SortedDictionary<string, int>();
                    logsAggregator[name][ip] = duration;
                }
                else
                {
                    if (logsAggregator[name].ContainsKey(ip))
                    {
                        logsAggregator[name][ip] += duration;
                    }
                    else
                    {
                        logsAggregator[name][ip] = duration;
                    }
                    
                }
            }
            foreach (var user in logsAggregator)
            {
                Console.Write("{0}: {1} [", user.Key, user.Value.Values.Sum());
                int count = 0;
                foreach (var log in user.Value)
                {
                    Console.Write("{2}{3}",user.Key, user.Value.Values.Sum(), log.Key, count == user.Value.Values.Count-1 ? "]":", ");
                    count++;
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
