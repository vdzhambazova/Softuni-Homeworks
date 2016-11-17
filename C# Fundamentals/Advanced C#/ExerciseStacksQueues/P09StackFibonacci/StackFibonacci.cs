using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09StackFibonacci
{
    public class StackFibonacci
    {
        static void Main(string[] args)
        {
            long index = long.Parse(Console.ReadLine());
            Stack<long> fibonacci = new Stack<long>();
            fibonacci.Push(1);
            fibonacci.Push(1);
            GetFibonacci(index, fibonacci);
        }

        private static void GetFibonacci(long index, Stack<long> fibonacci)
        {
            for (long i = 2; i < index; i++)
            {
                long top = fibonacci.Pop();
                long topMinusOne = fibonacci.Peek();
                long next = top + topMinusOne;
                fibonacci.Push(top);
                fibonacci.Push(next);
            }

            long nthFibonacciNumber = fibonacci.Peek();
            Console.WriteLine(nthFibonacciNumber);
        }
    }
}
