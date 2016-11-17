using System;
using P03WildFarm.Animals.Mammals;
using P03WildFarm.Animals.Mammals.Feline;
using P03WildFarm.Food;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] animalDetails = input.Split();

            switch (animalDetails[0])
            {
                case "Cat":
                    Animal cat = new Cat(animalDetails[0], animalDetails[1], double.Parse(animalDetails[2]), animalDetails[3], animalDetails[4]);
                    cat.MakeSound();
                    AddFood(cat);
                    Console.WriteLine(cat);
                    break;
                case "Tiger":
                    Animal tiger = new Tiger(animalDetails[0], animalDetails[1], double.Parse(animalDetails[2]), animalDetails[3]);
                    tiger.MakeSound();
                    AddFood(tiger);
                    Console.WriteLine(tiger);          
                    break;
                case "Mouse":
                    Animal mouse = new Mouse(animalDetails[0], animalDetails[1], double.Parse(animalDetails[2]), animalDetails[3]);
                    mouse.MakeSound();
                    AddFood(mouse);
                    Console.WriteLine(mouse);
                    break;
                case "Zebra":
                    Animal zebra = new Zebra(animalDetails[0], animalDetails[1], double.Parse(animalDetails[2]), animalDetails[3]);
                    zebra.MakeSound();
                    AddFood(zebra);
                    Console.WriteLine(zebra);
                    break;
            }

            input = Console.ReadLine();
        }
    }

    private static void AddFood(Animal animal)
    {
        string[] foodDetails = Console.ReadLine().Split();

        try
        {
            if (foodDetails[0] == "Vegetable")
            {
                Food vegetable = new Vegetable(int.Parse(foodDetails[1]));
                animal.AddFood(vegetable);
            }
            else
            {
                Food meat = new Meat(int.Parse(foodDetails[1]));
                animal.AddFood(meat);
            }
        }
        catch (InvalidOperationException ioex)
        {
            Console.WriteLine(ioex.Message);
        }
    }
}

