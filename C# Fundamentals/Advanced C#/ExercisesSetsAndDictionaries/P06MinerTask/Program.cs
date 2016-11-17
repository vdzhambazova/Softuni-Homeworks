using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityByResource = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int quantity = 0;
            string resource = String.Empty;

            while (input != "stop")
            {
                
                if (int.TryParse(input, out quantity))
                {
                    quantity = int.Parse(input);
                }
                else
                {
                    resource = input;
                }

                if (!quantityByResource.ContainsKey(resource))
                {
                    quantityByResource[resource] = 0;
                }

                quantityByResource[resource] = quantity;

                input = Console.ReadLine();
            }

            foreach (var entry in quantityByResource)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
