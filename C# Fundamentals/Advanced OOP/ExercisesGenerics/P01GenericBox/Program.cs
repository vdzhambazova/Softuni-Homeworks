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
            Box<int> intBox = new Box<int>(123123);
            Box<string> stringBox = new Box<string>("life in a box");

            Console.WriteLine(intBox);
            Console.WriteLine(stringBox);
        }
    }
}
