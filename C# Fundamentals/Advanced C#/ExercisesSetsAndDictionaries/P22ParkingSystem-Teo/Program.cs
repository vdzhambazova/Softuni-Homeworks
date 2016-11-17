using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22ParkingSystem_Teo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }

            int[] inputParamaters = input.Split(' ').Select(int.Parse).ToArray();
            int entryRow = inputParamaters[0];
            int desiredParkingRow = inputParamaters[1];
            int desiredParkingColumn = inputParamaters[2];
            int travelledCells = 0;
            bool successfulParking = false;

            for (int c = desiredParkingColumn; c > 0; c--)
            {
                if (parkingLot[desiredParkingRow, c] == 0)
                {
                    parkingLot[desiredParkingRow, c] = 1;
                    desiredParkingColumn = c;
                    successfulParking = true;
                    break;
                }
            }

            if (!successfulParking)
            {
                for (int c = desiredParkingColumn; c < parkingColumns; c++)
                {
                    if (parkingLot[desiredParkingRow, c] == 0)
                    {
                        parkingLot[desiredParkingRow, c] = 1;
                        desiredParkingColumn = c;
                        successfulParking = true;
                        break;
                    }
                }
            }

            if (successfulParking)
            {
                travelledCells = desiredParkingColumn + Math.Abs(entryRow - desiredParkingRow) + 1;
                Console.WriteLine(travelledCells);
            }
            else
            {
                Console.WriteLine(string.Format("Row {0} full", desiredParkingRow));
            }
        }
    }
}
}
        }
    }
}
