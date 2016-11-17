using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02MatchPhoneNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            while (phoneNumber != "end")
            {
                Match match = Regex.Match(phoneNumber, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
                phoneNumber = Console.ReadLine();
            }
        }
    }
}
