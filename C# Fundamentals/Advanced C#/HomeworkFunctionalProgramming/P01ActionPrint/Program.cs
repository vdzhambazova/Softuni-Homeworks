using System;
using System.Collections.Generic;
using System.Linq;

namespace P01ActionPrint
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Action<string> outputAction = (x) => Console.WriteLine(x);
            input.ForEach(outputAction);
        }
    }
}
