using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21ParkingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] parkingLot = new int[matrixDimentions[0], matrixDimentions[1]];

            string input = Console.ReadLine();
            while (input != "stop")
            {
                int[] inputArgs = input.Split().Select(int.Parse).ToArray();
                int entryRow = inputArgs[0];
                int entryCol = 0;
                int desiredRow = inputArgs[1];
                int desiredCol = inputArgs[2];
                int moves = 1;

                bool successfulParking = false;

                for (int i = desiredCol; i > 0; i--)
                {
                    if (parkingLot[desiredRow, i] == 0)
                    {
                        parkingLot[desiredRow, i] = 1;
                        successfulParking = true;
                        desiredCol = i;
                        break;
                    }
                }

                if (!successfulParking)
                {
                    for (int i = desiredCol; i < parkingLot.GetLength(1); i++)
                    {
                        if (parkingLot[desiredRow, i] == 0)
                        {
                            parkingLot[desiredRow, i] = 1;
                            successfulParking = true;
                            desiredCol = i;
                            break;
                        }
                    }
                }

                if (successfulParking)
                {
                    moves = desiredCol + Math.Abs(entryRow - desiredRow) + 1;
                    Console.WriteLine(moves);
                }
                else
                {
                    Console.WriteLine("Row {0} full", desiredRow);
                }

                input = Console.ReadLine();
            }
        }
    }
}

