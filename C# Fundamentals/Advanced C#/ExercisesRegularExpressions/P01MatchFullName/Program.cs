using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P01MatchFullName
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            while (name != "end")
            {
                Match match = Regex.Match(name, pattern);
                if (match.Success)
                {
                    Console.WriteLine(name);
                }
                name = Console.ReadLine();
            }
        }
    }
}
