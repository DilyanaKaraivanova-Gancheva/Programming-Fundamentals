using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            SortedDictionary<string, Dictionary<string,int>> userIpMessages = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string[] ipInput = input[0].Split('=');
                //string[] messageInput = input[1].Split('=');
                string[] userInput = input[2].Split('=');

                string ip = ipInput[1];
                //string message = messageInput[1];
                string user = userInput[1];

                if (!(userIpMessages.ContainsKey(user)))
                {
                        userIpMessages[user] = new Dictionary<string, int>();
                    userIpMessages[user][ip] = 1;
                }
                else
                {
                    if (userIpMessages[user].ContainsKey(ip))
                    {
                        userIpMessages[user][ip] ++;
                    }
                    else
                    {
                        userIpMessages[user][ip] = 1;
                    }
                }

                input = Console.ReadLine().Split();
            }
            foreach (var user in userIpMessages)
            {
                Console.WriteLine($"{user.Key}: ");

                int counter = 0;

                foreach (var value in user.Value)
                {
                    Console.Write("{0} => {1}{2}", value.Key, value.Value, (counter == userIpMessages[user.Key].Count-1) ? "." : ", ");
                    counter++;
                }
                Console.WriteLine();
               // Console.WriteLine(userIpMessages[user.Key].Count);

            }
            Console.WriteLine();
        }
    }
}
