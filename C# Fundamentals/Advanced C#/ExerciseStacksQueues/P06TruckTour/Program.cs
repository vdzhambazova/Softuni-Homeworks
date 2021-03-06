﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();
            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amountOfGas = int.Parse(pumpInfo[0]);
                GasPump pump = new GasPump(distanceToNext, amountOfGas, i);
                pumps.Enqueue(pump);
            }

            GasPump starterPump = null;
            bool completedJourney = false;
            while (true)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                starterPump = currentPump;
                int gasInTank = currentPump.amountOfGas;

                while (gasInTank>= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == starterPump)
                    {
                        completedJourney = true;
                        break;
                    }

                    gasInTank += currentPump.amountOfGas;
                }

                if (completedJourney)
                {
                    Console.WriteLine(starterPump.indexOfPump);
                    break;
                }
            }
        }

        public class GasPump
        {
            public int distanceToNext;
            public int amountOfGas;
            public int indexOfPump;

            public GasPump(int distanceToNext, int amountOfGass, int indexOfPump)
            {
                this.distanceToNext = distanceToNext;
                this.amountOfGas = amountOfGass;
                this.indexOfPump = indexOfPump;
            }
        }
    }
}
