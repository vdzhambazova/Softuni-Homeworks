using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P14DragonArmy
{
    public class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, SortedDictionary<string, List<int>>> dragonArmy =
                new Dictionary<string, SortedDictionary<string, List<int>>>();

            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string type = inputArgs[0];
                string name = inputArgs[1];
                int damage;
                bool isDamageInt = int.TryParse(inputArgs[2], out damage);
                if (!isDamageInt)
                {
                    damage = 45;
                }

                int health;
                bool isHealthInt = int.TryParse(inputArgs[3], out health);
                if (!isHealthInt)
                {
                    health = 250;
                }

                int armor;
                bool isArmorInt = int.TryParse(inputArgs[4], out armor);
                if (!isArmorInt)
                {
                    armor = 10;
                }

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy[type] = new SortedDictionary<string, List<int>>();
                }

                dragonArmy[type][name] = new List<int>();

                dragonArmy[type][name].Add(damage);
                dragonArmy[type][name].Add(health);
                dragonArmy[type][name].Add(armor);
            }



            foreach (var entry in dragonArmy)
            {
                double[] average = CalculateAverage(entry.Value);
                Console.WriteLine("{0}::({1:0.00}/{2:0.00}/{3:0.00})", entry.Key, average[0], average[1], average[2]);

                foreach (var dragon in entry.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
        }

        private static double[] CalculateAverage(SortedDictionary<string, List<int>> entry)
        {
            int totalEntries = entry.Count;
            double totalDamage = 0;
            double totalHealth = 0;
            double totalArmor = 0;

            foreach (var dragon in entry)
            {
                totalDamage += dragon.Value[0];
                totalHealth += dragon.Value[1];
                totalArmor += dragon.Value[2];
            }

            return new double[]
            {
                totalDamage/totalEntries,
                totalHealth/totalEntries,
                totalArmor/totalEntries
            };
        }
    }
}
