
using System;

public class Program
{
    public class DecimalNumbers
    {
        private decimal number;

        public DecimalNumbers(decimal number)
        {
            this.number = number;
        }

        public decimal Number => this.number;

        public decimal ReverseNumber()
        {
            char[] numberArray = Number.ToString().ToCharArray();
            Array.Reverse(numberArray);
            decimal reversedNumber = decimal.Parse(string.Join("", numberArray));

            return reversedNumber;
        }
    }


    public static void Main()
    {
        decimal decimalNumber = decimal.Parse(Console.ReadLine());
    
        DecimalNumbers num = new DecimalNumbers(decimalNumber);

        Console.WriteLine(num.ReverseNumber());
    }
}

