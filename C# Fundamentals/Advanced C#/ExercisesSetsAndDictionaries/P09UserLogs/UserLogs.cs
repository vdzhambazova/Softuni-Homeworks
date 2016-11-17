using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09UserLogs
{
    public class UserLogs
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> logsByUser =
                new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] logInfo = input.Split(' ', '=');

                string IP = logInfo[1];
                string username = logInfo[5];

                if (!logsByUser.ContainsKey(username))
                {
                    logsByUser[username] = new Dictionary<string, int>();
                    logsByUser[username].Add(IP, 0);
                }
                else if (!logsByUser[username].ContainsKey(IP))
                {
                    logsByUser[username].Add(IP, 0);
                }

                logsByUser[username][IP]++;

                input = Console.ReadLine();
            }

            foreach (var outerPair in logsByUser)
            {
                Console.WriteLine("{0}:", outerPair.Key);
                Console.WriteLine("{0}.", string.Join(", ", outerPair.Value.Select(kv => string.Format("{0} => {1}", kv.Key, kv.Value))));
                //foreach (var innerPair in outerPair.Value)
                //{
                //    Console.Write("{0} => {1}", innerPair.Key, innerPair.Value);
                //}
            }
        }
    }
}
