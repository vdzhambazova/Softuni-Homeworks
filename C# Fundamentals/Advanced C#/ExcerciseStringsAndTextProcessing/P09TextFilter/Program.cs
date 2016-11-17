using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace P09TextFilter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToFillter = Console.ReadLine().Split(new []{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            foreach (var word in wordsToFillter)
            {
                input = FillterInput(word, input);
            }

            Console.WriteLine(input);
        }

        private static string FillterInput(string word, string input)
        {
            input = input.Replace(word, new string('*', word.Length));
            return input;
        }
    }
}
