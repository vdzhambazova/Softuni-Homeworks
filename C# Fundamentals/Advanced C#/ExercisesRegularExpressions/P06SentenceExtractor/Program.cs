using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P06SentenceExtractor
{
    public class Program
    {
        static void Main(string[] args)
        {
            string wordToFind = Console.ReadLine();
            string text = Console.ReadLine();

            StringBuilder pattern = new StringBuilder();
            pattern.Append(@"\b(\w+ )*");
            pattern.Append(wordToFind);
            pattern.Append(@"( \w+)*[\.|!|?]");
            Regex regex = new Regex(pattern.ToString());
            MatchCollection collection = regex.Matches(text);

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i].Value);
            }
        }
    }
}
