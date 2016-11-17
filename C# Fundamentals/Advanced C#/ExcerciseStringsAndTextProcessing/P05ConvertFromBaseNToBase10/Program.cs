using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P05ConvertFromBaseNToBase10
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split();

            int baseNumber = int.Parse(arguments[0]);
            BigInteger number = BigInteger.Parse(arguments[1]);
            string stringNumber = number.ToString();
            double result = 0;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                result += double.Parse(stringNumber[i].ToString()) * Math.Pow(baseNumber, i);
            }

            Console.WriteLine(result);
        }
    }
}
