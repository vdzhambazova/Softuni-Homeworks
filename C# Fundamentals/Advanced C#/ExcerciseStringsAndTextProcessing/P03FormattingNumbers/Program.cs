using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03FormattingNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int firstNumber = int.Parse(input[0]);
            decimal secondNumber = decimal.Parse(input[1]);
            decimal thirdNumber = decimal.Parse(input[2]);
            Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:0.00}|{3,-10:0.000}|", firstNumber, Convert.ToString(firstNumber,2).PadLeft(10, '0'), secondNumber, thirdNumber);

        }
    }
}
