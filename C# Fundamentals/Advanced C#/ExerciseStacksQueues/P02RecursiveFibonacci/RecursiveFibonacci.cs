using System;

namespace P08RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            long index = long.Parse(Console.ReadLine());
            long fibonacciNumber = GetFibonacci(index);
            Console.WriteLine(fibonacciNumber);
        }


        private static long GetFibonacci(long index)
        {
            if (index == 0)
                return 0;

            if (index == 1)
                return 1;

            return GetFibonacci(index - 1) + GetFibonacci(index - 2);
        }
    }
}