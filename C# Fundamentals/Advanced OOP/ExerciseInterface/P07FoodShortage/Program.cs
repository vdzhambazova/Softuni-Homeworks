using System;
using System.Collections.Generic;

using P07FoodShortage.Interfaces;
using P07FoodShortage.Models;

namespace P07FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int numberOfInput = int.Parse(Console.ReadLine());
            int food = 0;
            for (int i = 0; i < numberOfInput; i++)
            {
                string[] entrantDetails = Console.ReadLine().Split();

                if (entrantDetails.Length > 3)
                {
                    Citizen citizen =
                            new Citizen(entrantDetails[0], int.Parse(entrantDetails[1]),
                        entrantDetails[2], entrantDetails[3]);
                    buyers.Add(entrantDetails[0], citizen);
                }
                else
                {
                    Rebel rebel =
                           new Rebel(entrantDetails[0], int.Parse(entrantDetails[1]), entrantDetails[2]);
                    buyers.Add(entrantDetails[0], rebel);
                }
            }

            string nameOfBuyer = Console.ReadLine();

            while (nameOfBuyer != "End")
            {
                if (buyers.ContainsKey(nameOfBuyer))
                {
                    buyers[nameOfBuyer].BuyFood();
                }

                nameOfBuyer = Console.ReadLine();
            }

            Console.WriteLine(CalculateFood(buyers, food)); 
        }

        private static int CalculateFood(Dictionary<string, IBuyer> buyers, int food)
        {
            foreach (var buyer in buyers)
            {
                food += buyer.Value.Food;
            }

            return food;
        }
    }
}
