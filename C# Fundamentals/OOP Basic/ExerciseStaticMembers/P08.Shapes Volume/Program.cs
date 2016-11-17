using System;
using System.Text;

public class Program
{
    public class TriangularPrism
    {
        public double baseSide;
        public double heightFromBaseSize;
        public double length;

        public TriangularPrism(double baseSide, double heightFromBaseSize, double length)
        {
            this.baseSide = baseSide;
            this.heightFromBaseSize = heightFromBaseSize;
            this.length = length;
        }
    }

    public class Cylinder
    {
        public double radius;
        public double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
    }

    public class Cube
    {
        public double sideLength;

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }
    }

    public class VolumeCalculator
    {
        public static string CalculateTrianglePrismVolume(TriangularPrism prism)
        {
            double prismVolume = 0.5 * prism.baseSide * prism.heightFromBaseSize * prism.length;
            return $"{prismVolume:0.000}";
        }

        public static string CalculateCubeVolume(Cube cube)
        {
            double cubeVolume = Math.Pow(cube.sideLength, 3);
            return $"{cubeVolume:0.000}";
        }

        public static string CalculateCylinderVolume(Cylinder cylinder)
        {
            double cylinderVolume = Math.PI * Math.Pow(cylinder.radius, 2) * cylinder.height;
            return $"{cylinderVolume:0.000}";
        }
    }

    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        while (input != "End")
        {
            string[] shapeDetails = input.Split();
            string shape = shapeDetails[0];

            switch (shape)
            {
                case "TrianglePrism":
                    TriangularPrism prism = new TriangularPrism(
                        double.Parse(shapeDetails[1]), double.Parse(shapeDetails[2]), double.Parse(shapeDetails[3]));
                    string prismString = VolumeCalculator.CalculateTrianglePrismVolume(prism);
                    sb.AppendLine(prismString);
                    break;
                case "Cube":
                    Cube cube = new Cube(double.Parse(shapeDetails[1]));
                    string cubeString = VolumeCalculator.CalculateCubeVolume(cube);
                    sb.AppendLine(cubeString);
                    break;
                case "Cylinder":
                    Cylinder cylinder = new Cylinder(double.Parse(shapeDetails[1]), double.Parse(shapeDetails[2]));
                    string cylinderString = VolumeCalculator.CalculateCylinderVolume(cylinder);
                    sb.AppendLine(cylinderString);
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(sb.ToString());
    }
}