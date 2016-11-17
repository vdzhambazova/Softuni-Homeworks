using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SumBigNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            long firstBigNumber = long.Parse(Console.ReadLine());
            long secondBigNumber = long.Parse(Console.ReadLine());
            long sum = firstBigNumber+secondBigNumber;

            Console.WriteLine(sum);
        }
    }
}
