using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10UnicodeCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder unicodeBuilder = new StringBuilder();
            foreach (char letter in input)
            {
                unicodeBuilder.AppendFormat("\\u{0:X4}", (int)letter);
            }

            Console.WriteLine(unicodeBuilder.ToString().ToLower());
        }
    }
}
