using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "search")
            {
                string[] inputArgs = input.Split('-');
                string name = inputArgs[0];
                string phoneNumber = inputArgs[1];
                phonebook[name] = phoneNumber;
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "stop")
            {
                if (phonebook.ContainsKey(input))
                {
                    foreach (var entry in phonebook)
                    {
                        if (input.Equals(entry.Key))
                        {
                            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
