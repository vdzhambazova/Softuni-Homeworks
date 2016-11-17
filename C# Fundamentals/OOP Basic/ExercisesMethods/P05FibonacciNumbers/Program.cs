using System;
using System.Collections.Generic;

public class Program
{
    public class FibonacciNumbers
    {
        private List<int> fibonacciNumbers;

        public FibonacciNumbers()
        {
            this.fibonacciNumbers = new List<int>();
        }

        public List<int> FibNumbers => this.fibonacciNumbers;

        public void FillFibonacciList(int endPosition)
        {
            
            int a = 0, b = 1, c = 0;
            FibNumbers.Add(a);
            FibNumbers.Add(b);

            for (int i = 2; i < endPosition; i++)
            {
                c = a + b;
                FibNumbers.Add(c);
                a = b;
                b = c;
            }
        }

        public List<int> GetFibonacciNumbers(int startPosition, int endPosition)
        {
            List<int> fibonacciInRange = new List<int>();
            for (int i = startPosition; i < endPosition; i++)
            {
                fibonacciInRange.Add(this.FibNumbers[i]);
            }

            return fibonacciInRange;
        }
    }

    public static void Main()
    {
        int startPosition = int.Parse(Console.ReadLine());
        int endPosition = int.Parse(Console.ReadLine());

        FibonacciNumbers fibonacciList = new FibonacciNumbers();

        fibonacciList.FillFibonacciList(endPosition);

        List<int> fibonacciInRange = fibonacciList.GetFibonacciNumbers(startPosition, endPosition);

        Console.WriteLine(string.Join(", ", fibonacciInRange));
    }
}

