using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02StringLength
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(20);
            if (input.Length >= sb.Capacity)
            {
                for (int i = 0; i < sb.Capacity; i++)
                {
                    sb.Append(input[i]);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append(input[i]);
                }
                for (int i = input.Length; i < sb.Capacity; i++)
                {
                    sb.Append("*");
                }
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}
