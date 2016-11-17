using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            Lake lake = new Lake(stones);

            List<int> orderedStones = new List<int>();

            foreach (var stone in lake)
            {
                orderedStones.Add(stone);
            }

            Console.WriteLine(string.Join(", ", orderedStones));
        }
    }
}
