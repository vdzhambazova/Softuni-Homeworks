using System.Collections.Generic;
using System.Linq;

namespace P05SpeedRacing
{
    using System;

    public class Car
    {
        public string model;
        public double fuel;
        public double fuelConsumption;
        public double distanceTraveled;

        public Car(string model, double fuel, double fuelConsumption)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelConsumption = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public void Drive(int amountOfKilometers)
        {
            if (amountOfKilometers <= this.fuel / this.fuelConsumption)
            {
                this.distanceTraveled += amountOfKilometers;
                this.fuel -= this.fuelConsumption * amountOfKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] inputCarArgs = Console.ReadLine().Split();
                string model = inputCarArgs[0];
                double fuel = double.Parse(inputCarArgs[1]);
                double fuelConsumption = double.Parse(inputCarArgs[2]);


                Car car = new Car(model, fuel, fuelConsumption);
                cars.Add(car);
            }

            string driveInput = Console.ReadLine();
            while (driveInput != "End")
            {
                string[] driveInputArgs = driveInput.Split();
                string carModel = driveInputArgs[1];
                int amountOfKm = int.Parse(driveInputArgs[2]);

                Car carToDrive = cars.First(c => c.model == carModel);
                carToDrive.Drive(amountOfKm);

                driveInput = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:f2} {2}", car.model, car.fuel, car.distanceTraveled);
            }
        }
    }
}
