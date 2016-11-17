using System;
using System.Collections.Generic;
using System.Security.Permissions;

public class Person
{
    private string name;
    private decimal money;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public List<Product> Bag { get; set; }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public void AddProductToBag(Product product)
    {
        if (CheckIfPersonCanBuyProduct(product))
        {
            throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
        }
        else
        {
            this.Money -= product.Cost;
            this.Bag.Add(product);
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }

    }

    private bool CheckIfPersonCanBuyProduct(Product product)
    {
        return product.Cost > this.Money;
    }
}

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Cost
    {
        get { return this.cost; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        string peopleLine = Console.ReadLine();
        string productsLine = Console.ReadLine();
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        string[] personAndMoney = peopleLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < personAndMoney.Length; i++)
        {
            string[] personSplit = personAndMoney[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            string personName = personSplit[0];
            decimal personMoney = decimal.Parse(personSplit[1]);
            try
            {
                Person person = new Person(personName, personMoney);
                people.Add(person);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        string[] productAndCost = productsLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < productAndCost.Length; i++)
        {
            string[] productSplit = productAndCost[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            string productName = productSplit[0];
            decimal productCost = decimal.Parse(productSplit[1]);
            try
            {
                Product product = new Product(productName, productCost);
                products.Add(product);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        string buyLine = Console.ReadLine();

        while (buyLine != "END")
        {
            string[] buyDetails = buyLine.Split();
            string personName = buyDetails[0];
            string productName = buyDetails[1];
            Person person = people.Find(p => p.Name == personName);
            try
            {
                person.AddProductToBag(products.Find(pr => pr.Name == productName));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            buyLine = Console.ReadLine();
        }

        foreach (var person in people)
        {
            List<string> productNames = new List<string>();
            foreach (var product in person.Bag)
            {
                productNames.Add(product.Name);
            }

            string listOfProductsString = string.Join(", ", productNames);
            if (listOfProductsString == String.Empty)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {listOfProductsString}");
            }

        }
    }
}

