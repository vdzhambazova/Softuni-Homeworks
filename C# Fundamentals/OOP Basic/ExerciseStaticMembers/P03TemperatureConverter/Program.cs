using System;

public class Program
{
    public class Temperature
    {
        public static double ConvertCelsiusToFarenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        public static double ConvertFarenheitToCelsium(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }

    public static void Main()
    {
        string temperatureInput = Console.ReadLine();

        while (temperatureInput != "End")
        {
            string[] temperatureDetails = temperatureInput.Split();
            double temperature = int.Parse(temperatureDetails[0]);
            string unit = temperatureDetails[1];
            string output = string.Empty;

            if (unit == "Celsius")
            {
                output = $"{Temperature.ConvertCelsiusToFarenheit(temperature):0.00} Fahrenheit";
            }
            else  // Farenheit
            {
                output = $"{Temperature.ConvertFarenheitToCelsium(temperature):0.00} Celsius";
            }

            Console.WriteLine(output);

            temperatureInput = Console.ReadLine();
        }
    }
}

