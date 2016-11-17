using System;
using System.Text;

public class Program
{
    public class MathUtils
    {
        public static string Sum(double firstNumber, double secondNumber)
        {

            double result = firstNumber + secondNumber;
            return $"{result:F2}";
        }

        public static string Substract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return $"{result:F2}";
        }

        public static string Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return $"{result:F2}";
        }

        public static string Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return $"{result:F2}";
        }

        public static string Persentage(double firstNumber, double secondNumber)
        {

            double result = firstNumber * secondNumber / 100;
            return $"{result:F2}";
        }
    }

    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        while (input != "End")
        {
            string[] mathDetails = input.Split();
            string operation = mathDetails[0];
            double firstNumber = double.Parse(mathDetails[1]);
            double secondNumber = double.Parse(mathDetails[2]);
            
            switch (operation)
            {
                case "Sum":
                    string sum = MathUtils.Sum(firstNumber, secondNumber);
                    sb.AppendLine(sum);
                    break;
                case "Subtract":
                    string substract = MathUtils.Substract(firstNumber, secondNumber);
                    sb.AppendLine(substract);
                    break;
                case "Multiply":
                    string multiply = MathUtils.Multiply(firstNumber, secondNumber);
                    sb.AppendLine(multiply);
                    break;
                case "Divide":
                    string divide = MathUtils.Divide(firstNumber, secondNumber);
                    sb.AppendLine(divide);
                    break;
                case "Percentage":
                    string persentage = MathUtils.Persentage(firstNumber, secondNumber);
                    sb.AppendLine(persentage);
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(sb.ToString());
    }
}

