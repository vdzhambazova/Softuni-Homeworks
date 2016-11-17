using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                string[] elementArgs = Console.ReadLine().Split();
                foreach (var element in elementArgs)
                {
                    chemicalElements.Add(element);
                }
            }

            Console.Write(string.Join(" ", chemicalElements));
        }
    }
}
