using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Telephony
{
    public class Smartphone : IBrowsable, ICallable
    {
        public Smartphone()
        {

        }

        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (number.Any(char.IsLetter))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }
    }

    public interface IBrowsable
    {
        string Browse(string url);
    }

    public interface ICallable
    {
        string Call(string number);
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            var smartphone = new Smartphone();

            try
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine(smartphone.Call(number));
                }

                foreach (var url in urls)
                {
                    Console.WriteLine(smartphone.Browse(url));                    
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
