using System;

public class Program
{
    public class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int NumberInt => this.number;

        public string GetLastDigitAsWord()
        {
            int lastNum = NumberInt % 10;
            string lastDigitAsWord = String.Empty;
            switch (lastNum)
            {
                case 0:
                    lastDigitAsWord = "zero";
                    break;
                case 1:
                    lastDigitAsWord = "one";
                    break;
                case 2:
                    lastDigitAsWord = "two";
                    break;
                case 3:
                    lastDigitAsWord = "three";
                    break;
                case 4:
                    lastDigitAsWord = "four";
                    break;
                case 5:
                    lastDigitAsWord = "five";
                    break;
                case 6:
                    lastDigitAsWord = "six";
                    break;
                case 7:
                    lastDigitAsWord = "seven";
                    break;
                case 8:
                    lastDigitAsWord = "eight";
                    break;
                case 9:
                    lastDigitAsWord = "nine";
                    break;
            }

            return lastDigitAsWord;
        }
    }

    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Number num = new Number(number);

        string lastDigtWord = num.GetLastDigitAsWord();

        Console.WriteLine(lastDigtWord);
    }
}

