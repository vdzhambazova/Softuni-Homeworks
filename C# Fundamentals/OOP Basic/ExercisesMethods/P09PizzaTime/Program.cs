using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P09PizzaTime
{
    public class Pizza
    {
        //private string name;
        //private string group;

        public Pizza(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }

        public int Group { get; set; }

        public string Name { get; set; }

        public SortedDictionary<int, List<string>> GetSortedPizzas(params string[] names)
        {
            SortedDictionary<int, List<string>> sortedPizzas = new SortedDictionary<int, List<string>>();
            sortedPizzas[this.Group] = new List<string>();
            sortedPizzas[this.Group].Add(this.Name);

            return sortedPizzas;
        }
    }

    class Program
    {
        static void Main()
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            string input = Console.ReadLine()

        }
    }
}
