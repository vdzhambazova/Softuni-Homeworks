using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Logs_Aggregator
{
    public class LogsAggregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> durationByUser =
                new SortedDictionary<string, int>();
            SortedDictionary<string, SortedSet<string>> IPByUser = new SortedDictionary<string, SortedSet<string>>();

            int inputCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            for (int i = 0; i < inputCount; i++)
            {
                string[] inputArgs = input.Split();
                string IP = inputArgs[0];
                string user = inputArgs[1];
                int duration = int.Parse(inputArgs[2]);

                if (!durationByUser.ContainsKey(user))
                {
                    durationByUser[user] = 0;
                }

                durationByUser[user] += duration;

                if (!IPByUser.ContainsKey(user))
                {
                    IPByUser[user] = new SortedSet<string>();
                }

                IPByUser[user].Add(IP);

                input = Console.ReadLine();
            }

            foreach (var entry in durationByUser)
            {
                string user = entry.Key;
                int duration = entry.Value;
                SortedSet<string> IPs = IPByUser[user];
                Console.WriteLine("{0}: {1} [{2}]", user, duration, string.Join(", ", IPs));
            }
        }
    }
}
