using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07FixEmails
{
    public class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailByName = new Dictionary<string, string>();
            string input = Console.ReadLine();
            string name = string.Empty;
            
            int controller = 0;
            while (input != "stop")
            {
                string email = string.Empty;
                if (controller % 2 == 0)
                {
                    name = input;
                }
                else //controller % 2 == 1
                {
                    email = input;
                }


                if (email != string.Empty)
                {
                    string emailDomainEnd = email.Substring(Math.Max(0, email.Length - 2));
                    bool isDomainValid = emailDomainEnd != "uk" && emailDomainEnd != "us";
                    if (isDomainValid)
                    {
                        if (!emailByName.ContainsKey(name))
                        {
                            emailByName[name] = String.Empty;
                        }

                        emailByName[name] = email;
                    }                 
                }

                controller++;
                input = Console.ReadLine();
            }

            foreach (var entry in emailByName)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
