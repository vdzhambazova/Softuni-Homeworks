using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Palindromes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new []{',', ' ', '.', '?', '!'}
                , StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder reversedWord = new StringBuilder();
                for (int j = words[i].Length-1; j >= 0; j--)
                {
                    reversedWord.Append(words[i][j]);
                }
                if (words[i] == reversedWord.ToString())
                {
                    palindromes.Add(words[i]);
                }
            }

            string output = string.Join(", ", palindromes);

            Console.WriteLine("[{0}]", output);
        }
    }
}
