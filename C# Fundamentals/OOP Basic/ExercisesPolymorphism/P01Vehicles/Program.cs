using System;

public abstract class Vehicle
{
    //fuel quantity, fuel consumption in liters per km and can be driven given distance and refueled 
    // with given liters

    private double fuelQuantity;
    private double fuelConsumptionInLiterPerKm;
    private static double AdditionalConsumption = 0;

    //private double tankCapacity;

    protected Vehicle(string name, double fuelQuantity, double fuelConsumptionInLiterPerKm, double tankCapacity)
    {
        this.Name = name;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionInLiterPerKm = fuelConsumptionInLiterPerKm;
        this.TankCapacity = tankCapacity;
    }

    public double TankCapacity { get; set; }

    public string Name { get; set; }

    public double FuelConsumptionInLiterPerKm { get; set; }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.fuelQuantity = value;
        }
    }

    public void DriveDistance(double distance)
    {
        double distanceVehicleCanTravel = this.FuelQuantity / this.FuelConsumptionInLiterPerKm;

        if (distanceVehicleCanTravel < distance)
        {
            throw new InvalidOperationException($"{this.Name} needs refueling");
        }
        else
        {
            distanceVehicleCanTravel -= distance;
            this.FuelQuantity = distanceVehicleCanTravel * this.FuelConsumptionInLiterPerKm;
            Console.WriteLine($"{this.Name} travelled {distance} km");
        }
    }

    public virtual void DriveDistanceWithAdditionalConsumption(double distance)
    {

        double distanceVehicleCanTravel = this.FuelQuantity / this.FuelConsumptionInLiterPerKm;

        if (distanceVehicleCanTravel < distance)
        {
            throw new InvalidOperationException($"{this.Name} needs refueling");
        }
        else
        {
            distanceVehicleCanTravel -= distance;
            this.FuelQuantity = distanceVehicleCanTravel * this.FuelConsumptionInLiterPerKm;
            Console.WriteLine($"{this.Name} travelled {distance} km");
        }
    }

    public virtual void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{this.Name}: {this.FuelQuantity:F2}";
    }
}

public class Car : Vehicle
{
    private static double AddedConsumption = 0.9;

    public Car(string name, double fuelQuantity, double fuelConsumptionInLiterPerKm, double tankCapacity)
        : base(name, fuelQuantity, fuelConsumptionInLiterPerKm + AddedConsumption, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
        if (this.FuelQuantity + liters > this.TankCapacity)
        {
            throw new InvalidOperationException("Cannot fit fuel in tank");
        }
        else
        {
            base.Refuel(liters);
        }
    }
}

public class Truck : Vehicle
{
    private static double AddedConsumption = 1.6;

    public Truck(string name, double fuelQuantity, double fuelConsumptionInLiterPerKm, double tankCapacity)
        : base(name, fuelQuantity, fuelConsumptionInLiterPerKm + AddedConsumption, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
        base.Refuel(liters * 0.95);
    }
}

public class Bus : Vehicle
{
    private const double AdditionalConsumption = 1.4;

    public Bus(string name, double fuelQuantity, double fuelConsumptionInLiterPerKm, double tankCapacity)
        : base(name, fuelQuantity, fuelConsumptionInLiterPerKm, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
        if (this.FuelQuantity + liters > this.TankCapacity)
        {
            throw new InvalidOperationException("Cannot fit fuel in tank");
        }
        else
        {
            base.Refuel(liters);
        }
    }

    public override void DriveDistanceWithAdditionalConsumption(double distance)
    {
        this.FuelConsumptionInLiterPerKm += Bus.AdditionalConsumption;

        base.DriveDistanceWithAdditionalConsumption(distance);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        string[] carDetails = Console.ReadLine().Split();
        string[] truckDetails = Console.ReadLine().Split();
        string[] busDetails = Console.ReadLine().Split();


        Vehicle car = new Car(carDetails[0], double.Parse(carDetails[1]), double.Parse(carDetails[2]), double.Parse(carDetails[3]));
        Vehicle truck = new Truck(truckDetails[0], double.Parse(truckDetails[1]), double.Parse(truckDetails[2]), double.Parse(truckDetails[3]));
        Vehicle bus = new Bus(busDetails[0], double.Parse(busDetails[1]), double.Parse(busDetails[2]), double.Parse(busDetails[3]));
        int numberOfInput = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInput; i++)
        {
            string[] input = Console.ReadLine().Split();

            if (input[0] == "Drive")
            {
                try
                {
                    if (input[1] == "Car")
                    {
                        car.DriveDistance(double.Parse(input[2]));
                    }
                    else if (input[1] == "Bus")
                    {
                        bus.DriveDistanceWithAdditionalConsumption(double.Parse(input[2]));
                    }
                    else
                    {
                        truck.DriveDistance(double.Parse(input[2]));
                    }
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input[0] == "DriveEmpty")
            {
                try
                {
                    bus.DriveDistance(double.Parse(input[2]));
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
                
            }
            else
            {
                try
                {
                    if (input[1] == "Car")
                    {
                        car.Refuel(double.Parse(input[2]));
                    }
                    else if (input[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(input[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(input[2]));
                    }
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}


