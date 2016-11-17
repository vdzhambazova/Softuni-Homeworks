using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P09CollectionHierarchy.Collections;

namespace P09CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elementsToAdd = Console.ReadLine().Split();
            int numberOfRemoves = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (var element in elementsToAdd)
            {
                Console.Write($"{addCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write($"{addRemoveCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write($"{myList.Add(element)} ");
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfRemoves; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfRemoves; i++)
            {
                Console.Write($"{myList.Remove()} ");
            }

            Console.WriteLine();
        }
    }
}
