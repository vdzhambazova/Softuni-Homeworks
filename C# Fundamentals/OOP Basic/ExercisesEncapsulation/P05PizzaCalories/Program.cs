using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

public class Dough
{
    private string doughType;
    private string bakingTechnique;
    private int weightInGrams;
    private const int CaloriesPerGram = 2;
    private const int MaxDoughWeight = 200;
    private const int MinDoughWeight = 1;

    private static readonly Dictionary<string, double> ModifierByDough = new Dictionary<string, double>()
    {
        {"white", 1.5},
        {"wholegrain", 1},
        {"crispy", 0.9},
        {"chewy", 1.1},
        {"homemade", 1.0}
    };

    public Dough(string doughType, string bakingTechnique, int weightInGrams)
    {
        this.DoughType = doughType;
        this.BakingTechnique = bakingTechnique;
        this.WeightInGrams = weightInGrams;
    }

    private string DoughType
    {
        get { return this.doughType; }
        set
        {
            if (!ModifierByDough.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.doughType = value;
        }
    }

    private string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (!ModifierByDough.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    private int WeightInGrams
    {
        get { return this.weightInGrams; }
        set
        {
            if (value < MinDoughWeight || value > MaxDoughWeight)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weightInGrams = value;
        }
    }

    public static int CaloriesPerGramDough => Dough.CaloriesPerGram;

    public double CalculateCaloriesInDough()
    {
        double caloriesInDough = this.WeightInGrams * Dough.CaloriesPerGram *
            ModifierByDough[DoughType.ToLower()] * ModifierByDough[BakingTechnique.ToLower()];
        return caloriesInDough;
    }

}

public class Topping
{
    private string toppingType;
    private int weightInGrams;

    private const int CaloriesPerGram = 2;
    private const int MaxToppingWeight = 50;
    private const int MinToppingWeight = 1;

    private static readonly Dictionary<string, double> ModifierByTopping = new Dictionary<string, double>()
    {
        {"meat", 1.2},
        {"veggies", 0.8},
        {"cheese", 1.1},
        {"sauce", 0.9},
    };

    public Topping(string toppingType, int weightInGrams)
    {
        this.ToppingType = toppingType;
        this.WeightInGrams = weightInGrams;
    }

    private string ToppingType
    {
        get { return this.toppingType; }
        set
        {
            if (!ModifierByTopping.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.toppingType = value;
        }
    }

    private int WeightInGrams
    {
        get { return this.weightInGrams; }
        set
        {
            if (value < MinToppingWeight || value > MaxToppingWeight)
            {
                throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
            }
            this.weightInGrams = value;
        }
    }

    public static int CaloriesPerGramDough => Topping.CaloriesPerGram;

    public double CalculateToppingCalories()
    {
        double toppingCalories = this.WeightInGrams * Topping.CaloriesPerGram *
            ModifierByTopping[ToppingType];
        return toppingCalories;
    }
}

public class Pizza
{
    private string name;
    private List<Topping> toppings;
    private int numberOfToppings;

    private const int MaxPizzaNameLength = 15;
    private const int MaxToppingsCount = 10;

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.Toppings = new List<Topping>();
    }

    public Pizza() : this(String.Empty, 0)
    {

    }

    public int NumberOfToppings
    {
        get { return this.numberOfToppings; }
        set
        {
            if (value > MaxToppingsCount)
            {
                throw new ArgumentException("Number of toppings should be in range[0..10].");
            }
            this.numberOfToppings = value;
        }
    }

    public Dough Dough { get; set; }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > MaxPizzaNameLength)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public List<Topping> Toppings
    {
        get { return this.toppings; }
        set
        {
            this.toppings = value;
        }
    }

    public double CalculatePizzaCalories()
    {
        double totalCalories = 0;
        for (int i = 0; i < this.Toppings.Count; i++)
        {
            totalCalories += Toppings[i].CalculateToppingCalories();
        }

        totalCalories += this.Dough.CalculateCaloriesInDough();

        return totalCalories;
    }

}

public class ProgramdoughDetails
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Pizza pizza = new Pizza();
        while (input != "END")
        {
            string[] pizzaDetails = input.Split();
            
            string ingredient = pizzaDetails[0].ToLower();

            if (ingredient == "pizza")
            {
                try
                {
                    pizza.Name = pizzaDetails[1];
                    pizza.NumberOfToppings = int.Parse(pizzaDetails[2]);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (ingredient == "dough")
            {
                try
                {
                    Dough dough = new Dough(pizzaDetails[1], pizzaDetails[2], int.Parse(pizzaDetails[3]));
                    pizza.Dough = dough;
                    Console.WriteLine($"{dough.CalculateCaloriesInDough():F2}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (ingredient == "topping")
            {
                try
                {
                    Topping topping = new Topping(pizzaDetails[1], int.Parse(pizzaDetails[2]));
                    pizza.Toppings.Add(topping);
                    Console.WriteLine($"{topping.CalculateToppingCalories():F2}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            input = Console.ReadLine();
        }

        if (!string.IsNullOrEmpty(pizza.Name))
        {
            Console.WriteLine("{0} – {1:f2} Calories.", pizza.Name, pizza.CalculatePizzaCalories());
        }
    }
}

