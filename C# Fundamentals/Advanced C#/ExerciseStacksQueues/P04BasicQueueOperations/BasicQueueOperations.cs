using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] inputInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToPush = inputInts[0];
            int elementsToPop = inputInts[1];
            int elementToCheck = inputInts[2];

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < inputNums.Length; i++)
            {
                numbers.Enqueue(inputNums[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minInt = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minInt)
                    {
                        minInt = number;
                    }
                }

                Console.WriteLine(minInt);
            }
        }
    }
}
