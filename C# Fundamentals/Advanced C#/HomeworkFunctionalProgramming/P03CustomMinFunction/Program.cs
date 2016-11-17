using System;
using System.Collections.Generic;
using System.Linq;

namespace P03CustomMinFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> minNum = FindMinNumber;
            Console.WriteLine(minNum(numbers));
        }

        private static int FindMinNumber(List<int> numbers)
        {
            int minNumber = numbers.Min();
            return minNumber;
        }
    }
}
