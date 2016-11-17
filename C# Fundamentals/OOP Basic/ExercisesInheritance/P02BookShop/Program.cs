using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            Book book = new Book(author, title, price);
            GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

            Console.WriteLine(book);
            Console.WriteLine(goldenEditionBook);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
}

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string author, string title, double price) : base(author, title, price)
    {

    }

    public override double Price
    {
        get { return base.Price * 1.3; }
    }
}

public class Book
{
    private string author;
    private string title;
    private double price;

    public Book(string author, string title, double price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get { return this.author; }
        set
        {
            int num = 0;
            if (CheckIfAuthorHasSurname(value))
            {
                if (int.TryParse(GetAuthorSurname(value).Substring(0, 1), out num) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }
    }

    private bool CheckIfAuthorHasSurname(string value)
    {
        string[] name = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return name.Length == 2;
    }

    private string GetAuthorSurname(string value)
    {

        string[] nameArgs = value.Split();
        return nameArgs[1];
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public virtual double Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append("Price: ").Append($"{this.Price:F1}")
                .Append(Environment.NewLine);

        return sb.ToString();
    }

}
