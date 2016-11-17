using System;
using System.Collections.Generic;
using System.Linq;

namespace P12LegendaryFarming
{
    public class LegendaryFarming
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> legendaryFarmingKey = new Dictionary<string, int>();
            string shards = "shards";
            string fragments = "fragments";
            string motes = "motes";
            legendaryFarmingKey[fragments] = 0;
            legendaryFarmingKey[shards] = 0;
            legendaryFarmingKey[motes] = 0;

            Dictionary<string, int> legendaryFarmingNonKey = new Dictionary<string, int>();

            while (input != string.Empty)
            {
                string[] inputArgs = input.Split();
                for (int i = 1; i < inputArgs.Length; i++)
                {
                    string item = inputArgs[i].ToLower();
                    bool areKeyMaterials = item == shards || item == fragments ||
                                           item == motes;
                    if (i % 2 != 0)
                    {
                        if (areKeyMaterials)
                        {
                            legendaryFarmingKey[item] += int.Parse(inputArgs[i - 1]);
                            CheckIfItemObtained(legendaryFarmingKey, shards, legendaryFarmingNonKey);
                            CheckIfItemObtained(legendaryFarmingKey, fragments, legendaryFarmingNonKey);
                            CheckIfItemObtained(legendaryFarmingKey,motes, legendaryFarmingNonKey);
                        }
                        else
                        {
                            if (!legendaryFarmingNonKey.ContainsKey(item))
                            {
                                legendaryFarmingNonKey[item] = int.Parse(inputArgs[i - 1]);
                            }
                            else
                            {
                                legendaryFarmingNonKey[item] += int.Parse(inputArgs[i - 1]);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static void CheckIfItemObtained(Dictionary<string, int> legendaryFarmingKey, string material,
            Dictionary<string, int> legendaryFarmingNonKey)
        {
            if (legendaryFarmingKey.ContainsKey(material))
            {
                if (legendaryFarmingKey[material] > 250)
                {
                    switch (material)
                    {
                        case "fragments":
                            Console.WriteLine("Valanyr obtained!");
                            break;
                        case "motes":
                            Console.WriteLine("Dragonwrath obrained!");
                            break;
                        case "shards":
                            Console.WriteLine("Shadowmourne obtained!");
                            break;
                    }

                    legendaryFarmingKey[material] -= 250;
                    foreach (var entry in legendaryFarmingKey.OrderByDescending(e => e.Value).ThenBy(e => e.Key))
                    {
                        Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
                    }

                    foreach (var entry in legendaryFarmingNonKey.OrderBy(e => e.Key))
                    {
                        Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
                    }
                }
            }
        }
    }
}
