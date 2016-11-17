using System;
using System.Collections.Generic;
using System.Linq;

namespace P02KnightsOfHonor
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Action<string> outputAction = (x) => Console.WriteLine("Sir {0}", x);
            input.ForEach(outputAction);
        }
    }
}
