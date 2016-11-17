using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public class Calculation
    {
        public const double PlanckConst = 6.62606896e-34;
        public const double PI = 3.14159;

        public static double CalculateReducedPlancConstant()
        {
            double result = PlanckConst / (2 * PI);
            return result;
        }
    }

    public static void Main()
    {
        Console.WriteLine(Calculation.CalculateReducedPlancConstant());
    }
}

