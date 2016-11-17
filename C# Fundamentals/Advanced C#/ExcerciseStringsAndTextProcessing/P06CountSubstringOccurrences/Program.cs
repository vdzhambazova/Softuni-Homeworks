using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06CountSubstringOccurrences
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int occurancesCounter = 0;
            int indexOfOccurence = text.IndexOf(substring);

            while (indexOfOccurence != -1)
            {
                occurancesCounter++;
                indexOfOccurence = text.IndexOf(substring, indexOfOccurence + 1);
            }

            Console.WriteLine(occurancesCounter);
        }
    }
}
