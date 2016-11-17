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
            List<Box<double>> strings = new List<Box<double>>();
            for (int i = 0; i < numOfInput; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> stringBox = new Box<double>(input);
                strings.Add(stringBox);
            }

            double valueToCompare = double.Parse(Console.ReadLine());

            Box<double> stringBoxValue = new Box<double>(valueToCompare);

            Console.WriteLine(CountGreaterElements(strings, stringBoxValue));
        }

        static int CountGreaterElements<T>(List<Box<T>> elements, Box<T> comparableElement)
    where T : IComparable
        {
            return elements.Count(e => e.Value.CompareTo(comparableElement.Value) > 0);
        }
    }
}
