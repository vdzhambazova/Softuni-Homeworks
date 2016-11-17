using System;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());


        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            Box box = new Box(length, width, height);

            double surfaceArea = box.CalculateBoxSurfaceArea();
            double lateralSurfaceArea = box.CalculateLateralBoxSurfaceArea();
            double volume = box.CalculateBoxVolume();

            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
            Console.WriteLine($"Volume - {volume:F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}

public class Box
{
    private double lenght;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double Lenght
    {
        get { return this.lenght; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            {
                this.lenght = value;
            }
        }
    }

    public double Width
    {
        get { return this.width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            {
                this.width = value;
            }
        }
    }

    public double Height
    {
        get { return this.height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            {
                this.height = value;
            }
        }
    }

    public double CalculateBoxSurfaceArea()
    {
        double boxSurfaceArea = 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        return boxSurfaceArea;
    }

    public double CalculateLateralBoxSurfaceArea()
    {
        double lateralBoxSurfaceArea = 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        return lateralBoxSurfaceArea;
    }

    public double CalculateBoxVolume()
    {
        double volume = this.Lenght * this.Width * this.Height;
        return volume;
    }
}