using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01GenericBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInput; i++)
            {
                string input = Console.ReadLine();
                Box<string> stringBox = new Box<string>(input);
                Console.WriteLine(stringBox);
            }
        }
}
}
