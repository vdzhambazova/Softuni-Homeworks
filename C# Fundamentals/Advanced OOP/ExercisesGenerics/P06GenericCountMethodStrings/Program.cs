using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using P01GenericBox;

namespace P04GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());
            List<Box<string>> strings = new List<Box<string>>();
            for (int i = 0; i < numOfInput; i++)
            {
                string input = Console.ReadLine();
                Box<string> stringBox = new Box<string>(input);
                strings.Add(stringBox);
            }

            string valueToCompare = Console.ReadLine();

            Box<string> stringBoxValue = new Box<string>(valueToCompare);

            Console.WriteLine(CountGreaterElements(strings, stringBoxValue));

        }

        static int CountGreaterElements<T>(List<Box<T>> elements, Box<T> comparableElement)
    where T : IComparable
        {
            return elements.Count(e => e.Value.CompareTo(comparableElement.Value) > 0);
        }
    }
}
