using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseStacksQueues
{
    public class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbersArr = input.Split().ToArray();
            Stack<string> numbers = new Stack<string>();
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbers.Push(numbersArr[i]);
            }

            while (numbers.Count > 0)
            {
                string poppedElement = numbers.Pop();
                Console.Write(poppedElement + " ");
            }
        }
    }
}
