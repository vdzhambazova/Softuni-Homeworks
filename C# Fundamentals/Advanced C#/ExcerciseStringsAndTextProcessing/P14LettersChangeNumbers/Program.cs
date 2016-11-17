using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14LettersChangeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < inputArgs.Length; i++)
            {
                double currentNumber = 0;
                char firstChar = inputArgs[i][0];
                char lastChar = inputArgs[i][inputArgs[i].Length - 1];
                int number = int.Parse(inputArgs[i].Substring(1, inputArgs[i].Length - 2));
                bool isFirstLetterLower = CheckIfLower(firstChar);
                if (isFirstLetterLower)
                {
                    currentNumber = (firstChar-96)*number;
                }
                else
                {
                    currentNumber = (double)number/(firstChar-64);
                }

                bool isLastLetterLower = CheckIfLower(lastChar);
                if (isLastLetterLower)
                {
                    totalSum += currentNumber + (lastChar-96);
                }
                else
                {
                    totalSum += currentNumber - (lastChar-64);
                }
            }

            Console.WriteLine("{0:0.00}",totalSum);
        }

        private static bool CheckIfLower(char letter)
        {
            if (letter>=97 && letter<=122)
            {
                return true;
            }

            return false;
        }
    }
}
