using System;
using System.Linq;

public class Program
{
    public class Car
    {
        public decimal speed;
        public decimal fuel;
        public decimal fuelEconomy;
        public decimal travelledDistance;
        public decimal time;

        public Car(decimal speed, decimal fuel, decimal fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
        }

        public void Travel(decimal distance)
        {
            if (distance >= this.fuelEconomy / 100 * this.fuel)
            {
                this.travelledDistance += distance;
                this.fuel -= distance * this.fuelEconomy / 100;
            }
            else
            {
                this.travelledDistance += fuelEconomy / 100 * fuel;
                this.fuel = 0;
            }


        }

        public void Refuel(decimal fuel)
        {
            this.fuel += fuel;
        }

        public string CalculateDistance()
        {
            string distanceTraveled = $"Total distance: {this.travelledDistance:F1} kilometers";
            return distanceTraveled;
        }

        public string CalculateTime()
        {
            decimal hours = Math.Floor(this.travelledDistance / this.speed);
            decimal mintes = Math.Floor(this.travelledDistance%this.speed);
            string timeTraveled = $"Total time: {hours} hours and {mintes} minutes";
            return timeTraveled;
        }

        public string CalculateFuelLeft()
        {
            string fuelLeft = $"Fuel left: {this.fuel:F1} liters";
            return fuelLeft;
        }
    }

    public static void Main()
    {
        decimal[] carDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

        Car car = new Car(carDetails[0], carDetails[1], carDetails[2]);

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] carCommands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (carCommands[0])
            {
                case "Travel":
                    decimal distance = decimal.Parse(carCommands[1]);
                    car.Travel(distance);
                    break;
                case "Refuel":
                    decimal fuel = decimal.Parse(carCommands[1]);
                    car.Refuel(fuel);
                    break;
                case "Distance":
                    string prdecimalDistance = car.CalculateDistance();
                    Console.WriteLine(prdecimalDistance);
                    break;
                case "Time":
                    string prdecimalTime = car.CalculateTime();
                    Console.WriteLine(prdecimalTime);
                    break;
                case "Fuel":
                    string printFuelLeft = car.CalculateFuelLeft();
                    Console.WriteLine(printFuelLeft);
                    break;
            }

            input = Console.ReadLine();
        }
    }
}
