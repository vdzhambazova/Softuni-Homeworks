using System;
using System.Numerics;

namespace P04ConvertFromBase10ToBaseN
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split();

            int toBase = int.Parse(arguments[0]);
            BigInteger number = BigInteger.Parse(arguments[1]);
            string result = string.Empty;

            do
            {
                result += number%toBase;
                number /= toBase;
            } while (number > 0);


            char[] reversedSB = result.ToCharArray();
            Array.Reverse(reversedSB);

            Console.WriteLine(string.Join("", reversedSB));
        }
    }
}
