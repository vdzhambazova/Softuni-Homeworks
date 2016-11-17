using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P05ExtractEmails
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?:^|\s)([a-zA-Z0-9]+[\.\-_]*?\w+)@\w+([\.\-_]+\w+)+";
            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(input);

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i].Value);
            }
        }
    }
}
