using System;
using System.Collections.Generic;
using P08MilitaryElite.Factories;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new List<ISolder>();

            var input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                try
                {
                    soldiers.Add(SoldierFactory.Soldier(input));
                }
                catch (Exception)
                {

                }

                input = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.Write(soldier);
            }
        }
    }
}

