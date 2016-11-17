using System;
using System.Collections.Generic;

namespace P13MagicExchangeableWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split();
            string firstWord = inputArgs[0];
            string secondWord = inputArgs[1];

            HashSet<char> uniqueLettersInFirstWord = new HashSet<char>();
            HashSet<char> uniqueLettersInSecondWord = new HashSet<char>();

            AddSymbolsToSets(firstWord, uniqueLettersInFirstWord);
            AddSymbolsToSets(secondWord, uniqueLettersInSecondWord);

            bool exchangable = uniqueLettersInFirstWord.Count == uniqueLettersInSecondWord.Count;
            if (exchangable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void AddSymbolsToSets(string firstWord, HashSet<char> uniqueLettersInFirstWord)
        {
            foreach (var letter in firstWord)
            {
                uniqueLettersInFirstWord.Add(letter);
            }
        }
    }
}
