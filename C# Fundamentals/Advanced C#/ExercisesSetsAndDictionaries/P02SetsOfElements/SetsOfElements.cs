using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02SetsOfElements
{
    public class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();

            for (int i = 0; i < numbers[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstNumbers.Add(input);
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondNumbers.Add(input);
            }

            IEnumerable<int> intersection = firstNumbers.Intersect(secondNumbers);

            Console.WriteLine(String.Join(" ", intersection));
        }
    }
}
