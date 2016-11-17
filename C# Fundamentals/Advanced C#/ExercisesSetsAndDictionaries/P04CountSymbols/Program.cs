using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (var symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols[symbol] = 0;
                }
                    symbols[symbol] ++;
            }

            foreach (var entry in symbols)
            {
                Console.WriteLine("{0}: {1} time/s", entry.Key, entry.Value);
            }
        }
    }
}
