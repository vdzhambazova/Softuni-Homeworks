using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05CalculateSequenceWithQueue
{
    public class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long firstElement = long.Parse(Console.ReadLine());
            long dequeueCount = 50;
            Queue<long> result = new Queue<long>();

            result.Enqueue(firstElement);

            for (long i = 0; i < dequeueCount; i++)
            {
                long head = result.Dequeue();
                Console.Write(head + " ");
                result.Enqueue(head + 1);
                result.Enqueue(2 * head + 1);
                result.Enqueue(head + 2);
            }
        }
    }
}
