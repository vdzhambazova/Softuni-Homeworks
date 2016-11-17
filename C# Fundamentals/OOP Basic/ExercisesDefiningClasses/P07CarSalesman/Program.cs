using System;
using System.Collections.Generic;
using System.Linq;

namespace P07CarSalesman
{
    public class Car
    {
        public string model;
        public Engine engine;
        public int weight;
        public string color;

        public Car(string model, Engine engine, int weight)
            : this(model, engine, weight, @"n/a")
        {

        }

        public Car(string model, Engine engine, string color)
            : this(model, engine, -1, color)
        {

        }

        public Car(string model, Engine engine)
            : this(model, engine, -1, @"n/a")
        {

        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

    }

    public class Engine
    {
        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power)
            : this(model, power, -1, @"n/a")
        {

        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, @"n/a")
        {

        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, -1, efficiency)
        {

        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int engineNumber = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < engineNumber; i++)
            {
                string[] engineDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineDetails[0];
                int enginePower = int.Parse(engineDetails[1]);
                int engineDisplacement = 0;
                string engineEfficiency = string.Empty;

                Engine engine = new Engine(engineModel, enginePower);

                if (engineDetails.Length == 3)
                {
                    if (int.TryParse(engineDetails[2], out engineDisplacement))
                    {
                        engineDisplacement = int.Parse(engineDetails[2]);
                        engine.displacement = engineDisplacement;
                    }
                    else
                    {
                        engineEfficiency = engineDetails[2];
                        engine.efficiency = engineEfficiency;
                    }
                }

                if (engineDetails.Length == 4)
                {
                    engineDisplacement = int.Parse(engineDetails[2]);
                    engineEfficiency = engineDetails[3];
                    engine.displacement = engineDisplacement;
                    engine.efficiency = engineEfficiency;
                }

                engines.Add(engine);
            }

            int carsNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsNumber; i++)
            {
                string[] carDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = carDetails[0];
                string engineName = carDetails[1];
                int weight = 0;

                Engine engine = CheckForEngine(engineName, engines);
                Car car = new Car(carModel, engine);

                if (carDetails.Length == 3)
                {
                    if (int.TryParse(carDetails[2], out weight))
                    {
                        weight = int.Parse(carDetails[2]);
                        car.weight = weight;
                    }
                    else
                    {
                        car.color = carDetails[2];
                    }
                }

                if (carDetails.Length == 4)
                {
                    car.weight = int.Parse(carDetails[2]);
                    car.color = carDetails[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.model}:");
                Console.WriteLine($"    Power: {car.engine.power}");
                if (car.engine.displacement == -1)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.engine.displacement}");
                }

                Console.WriteLine($"    Efficiency: {car.engine.efficiency}");
                if (car.weight == -1)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.weight}");
                }
                Console.WriteLine($"  Color: {car.color}");
            }
        }

        private static Engine CheckForEngine(string engineName, List<Engine> engines)
        {
            Engine engine = engines.First(e => e.model == engineName);

            return engine;
        }


    }
}
