using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03SeriesOfLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(.)\1+";
            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}
