using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P07ValidUsernames
{
    public class Program
    {
        static void Main(string[] args)
        {
            string usernamesInput = Console.ReadLine();
            string splitPattern = @"[\s+\/\\\(\)]";

            string[] usernames = Regex.Split(usernamesInput, splitPattern).Where(x => x != String.Empty).ToArray();

            string validPattern = @"\b[A-Za-z][\w]{2,24}\b";
            Regex regex = new Regex(validPattern);
            List<string> validUsernames = new List<string>();
            MatchCollection matchCollection = regex.Matches(string.Join(", ", usernames));

            foreach (Match match in matchCollection)
            {
                validUsernames.Add(match.Value);
            }

            int maxLength = int.MinValue;
            int indexOfFirstLongestUsername = int.MinValue;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if (validUsernames[i].Length + validUsernames[i + 1].Length > maxLength)
                {
                    maxLength = validUsernames[i].Length + validUsernames[i + 1].Length;
                    indexOfFirstLongestUsername = i;
                }
            }

            Console.WriteLine(validUsernames[indexOfFirstLongestUsername]);
            Console.WriteLine(validUsernames[indexOfFirstLongestUsername + 1]);

        }
    }
}
