using System;
using System.Collections.Generic;
using System.Linq;

namespace P05AppliedArithmetics
{
    public static class Functions
    {
        public static void Print(List<int> collection, Action<int> lastElementAct)
        {
            for (int i = 0; i < collection.Count-1; i++)
            {
                lastElementAct(collection[i]);
            }
            lastElementAct(collection[collection.Count - 1]);
        }

        public static List<int> ApplyFunc(this List<int> collection, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in collection)
            {
                result.Add(func(item));
            }

            return result;
        }
    } 

    public class Program
    {
       

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        break;
                    case "substract":
                        break;
                    case "multiply":
                        break;
                    case "print":
                        Functions.Print(numbers,));
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
