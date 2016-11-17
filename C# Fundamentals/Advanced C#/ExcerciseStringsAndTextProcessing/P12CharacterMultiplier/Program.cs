using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12CharacterMultiplier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int totalSum = 0;
            int smallerWord = Math.Min(words[0].Length, words[1].Length);
            for (int i = 0; i < smallerWord; i++)
            {
                totalSum += words[0][i] * words[1][i];
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > smallerWord)
                {
                    for (int j = smallerWord; j < words[i].Length; j++)
                    {
                        totalSum += words[i][j];
                    }
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
