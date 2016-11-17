using System;
using System.Linq;

public class Program
{
    public class BeerCounter
    {
        private static int beerInStock;
        private static int beersDrankCount;

        public static int BeerInStock
        {
            get { return BeerCounter.beerInStock; }
            set { BeerCounter.beerInStock = value; }
        }

        public static int BeersDrankCount
        {
            get { return BeerCounter.beersDrankCount; }
            set { BeerCounter.beersDrankCount = value; }
        }

        public static void BuyBeer(int bottlesCount)
        {
            BeerCounter.beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            BeerCounter.BeersDrankCount += bottlesCount;
            BeerCounter.BeerInStock -= bottlesCount;
        }
    }
    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            int[] beerInfo = input.Split().Select(int.Parse).ToArray();
            int beersBought = beerInfo[0];
            int beerDrank = beerInfo[1];

            BeerCounter.BuyBeer(beersBought);
            BeerCounter.DrinkBeer(beerDrank);

            input = Console.ReadLine();
        }
    
        Console.WriteLine($"{BeerCounter.BeerInStock} {BeerCounter.BeersDrankCount}");
    }
}

