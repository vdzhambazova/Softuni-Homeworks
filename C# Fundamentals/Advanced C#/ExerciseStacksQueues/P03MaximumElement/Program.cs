using System;
using System.Collections.Generic;
using System.Linq;

namespace P03MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxElement = int.MinValue;
            for (int i = 0; i < inputCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split().ToArray();
                string command = commandArgs[0];
                if (command == "1")
                {
                    int numberToPush = int.Parse(commandArgs[1]);
                    numbers.Push(numberToPush);
                    if (numberToPush >= maxElement)
                    {
                        maxElement = numberToPush;
                        maxNumbers.Push(maxElement);
                    }
                }
                else if (command == "2")
                {
                    int topElement = numbers.Pop();
                    int currentMaxNumber = maxNumbers.Peek();
                    if (topElement == currentMaxNumber)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxElement = maxNumbers.Peek();
                        }
                        else
                        {
                            maxElement = int.MinValue;
                        }
                    }
                }
                else // command == 3
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
