using System;
using System.Collections.Generic;
using System.Linq;
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

            int[] swapIndices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapStrings(strings, swapIndices[0], swapIndices[1]);

            foreach (var box in strings)
            {
                Console.WriteLine(box.ToString());
            }
        }

        public static void SwapStrings<T>(List<Box<T>> strings, int firstSwapIndex, int secondSwapIndex)
        {
            Box<T> temp = strings[firstSwapIndex];
            strings[firstSwapIndex] = strings[secondSwapIndex];
            strings[secondSwapIndex] = temp;
        }
    }
}
