using System;
using System.Collections.Generic;
using System.Linq;

namespace P06RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tire[] tires;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }

    public class Engine
    {
        public int speed;
        public int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }

    public class Tire
    {
        public double pressure;
        public int age;

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
    }

    public class Cargo
    {
        public double weight;
        public string type;

        public Cargo(double weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carDetails =
                Console.ReadLine().Split();
                string carModel = carDetails[0];
                int engineSpeed = int.Parse(carDetails[1]);
                int enginePower = int.Parse(carDetails[2]);
                double cargoWeight = double.Parse(carDetails[3]);
                string cargoType = carDetails[4];
                double tire1Pressure = double.Parse(carDetails[5]);
                int tire1Age = int.Parse(carDetails[6]);
                double tire2Pressure = double.Parse(carDetails[7]);
                int tire2Age = int.Parse(carDetails[8]);
                double tire3Pressure = double.Parse(carDetails[9]);
                int tire3Age = int.Parse(carDetails[10]);
                double tire4Pressure = double.Parse(carDetails[11]);
                int tire4Age = int.Parse(carDetails[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4];
                tires[0] = new Tire(tire1Pressure, tire1Age);
                tires[1] = new Tire(tire2Pressure, tire2Age);
                tires[2] = new Tire(tire3Pressure, tire3Age);
                tires[3] = new Tire(tire4Pressure, tire4Age);

                Car car = new Car(carModel, engine, cargo, tires);
                cars.Add(car);
            }

            string cargoTypeToPrine = Console.ReadLine();
            List<Car> sortedCars = new List<Car>();

            if (cargoTypeToPrine == "fragile")
            {
                sortedCars = cars.Where(c => c.cargo.type == "fragile" && c.tires.Any(t => t.pressure < 1)).ToList();
            }
            else
            {
                sortedCars = cars.Where(c => c.cargo.type == "flamable" && c.engine.power > 250).ToList();
            }

            foreach (var car in sortedCars)
            {
                Console.WriteLine(car.model);
            }
        }
    }
}
