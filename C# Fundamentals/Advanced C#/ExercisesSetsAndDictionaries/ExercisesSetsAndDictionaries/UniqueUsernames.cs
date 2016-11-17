using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01UniqueUsernames
{
    public class UniqueUsernames
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
