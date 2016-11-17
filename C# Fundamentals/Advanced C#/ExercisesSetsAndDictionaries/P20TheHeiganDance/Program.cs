using System;
using System.Linq;

namespace P20TheHeiganDance
{
    public class Program
    {
        static void Main(string[] args)
        {
            double damageDoneToHeigan = double.Parse(Console.ReadLine());
            double playerHitPoints = 18500;
            double heiganHitPoints = 3000000;
            int plagueCloudDamage = 3500;
            int eruptionDamage = 6000;

            string input = Console.ReadLine();
            int rows = 15;
            int cols = 15;
            int playerRowPosition = 7;
            int playerColPosition = 7;
            int[,] heiganDanceMatrix = new int[rows, cols];
            int cloudRecuring = 0;
            FillMatrix(heiganDanceMatrix);

            while (true)
            {

                string[] inputArgs = input.Split().ToArray();
                
                string spell = inputArgs[0];
                int spellRow = int.Parse(inputArgs[1]);
                int spellCol = int.Parse(inputArgs[2]);


                heiganHitPoints -= damageDoneToHeigan;
                if (heiganHitPoints <= 0)
                {
                    Console.WriteLine("Heigan: Defeated!");
                    Console.WriteLine("Player: {0}", playerHitPoints);
                    Console.WriteLine("Final position: {0}, {1}", playerRowPosition, playerColPosition);
                    break;
                }

                FillMatrix(heiganDanceMatrix);
                CastSpell(heiganDanceMatrix, spellRow, spellCol);

                if (heiganDanceMatrix[playerRowPosition, playerColPosition] == 0)
                {
                    if (IsInMatrix(heiganDanceMatrix, playerRowPosition - 1, playerColPosition) &&
                heiganDanceMatrix[playerRowPosition - 1, playerColPosition] != 0)
                    {
                        playerRowPosition--;
                    }
                    else if (IsInMatrix(heiganDanceMatrix, playerRowPosition, playerColPosition - 1) &&
                        heiganDanceMatrix[playerRowPosition, playerColPosition - 1] != 0)
                    {
                        playerColPosition--;
                    }
                    else if (IsInMatrix(heiganDanceMatrix, playerRowPosition + 1, playerColPosition) &&
                        heiganDanceMatrix[playerRowPosition + 1, playerColPosition] != 0)
                    {
                        playerRowPosition++;
                    }
                    else if (IsInMatrix(heiganDanceMatrix, playerRowPosition, playerColPosition + 1) &&
                             heiganDanceMatrix[playerRowPosition, playerColPosition + 1] != 0)
                    {
                        playerColPosition++;
                    }
                    else
                    {
                        if (cloudRecuring > 0)
                        {
                            playerHitPoints = PerformHit(heiganHitPoints, playerHitPoints, plagueCloudDamage, spell, playerColPosition, playerRowPosition);
                            if (playerHitPoints <= 0)
                            {
                                spell = "Cloud";
                                string spellName = string.Empty;
                                if (spell == "Cloud")
                                {
                                    spellName = "Plague Cloud";
                                }
                                else
                                {
                                    spellName = "Eruption";
                                }

                                Console.WriteLine("Heigan: {0:0.00}", heiganHitPoints);
                                Console.WriteLine("Player: Killed by {0}", spellName);
                                Console.WriteLine("Final position: {0}, {1}", playerRowPosition, playerColPosition);
                                return;
                            }

                            cloudRecuring--;
                        }

                        if (spell == "Cloud")
                        {
                            playerHitPoints = PerformHit(heiganHitPoints, playerHitPoints, plagueCloudDamage, spell, playerColPosition, playerRowPosition);
                            if (playerHitPoints <= 0)
                            {

                                string spellName = string.Empty;
                                if (spell == "Cloud")
                                {
                                    spellName = "Plague Cloud";
                                }
                                else
                                {
                                    spellName = "Eruption";
                                }

                                Console.WriteLine("Heigan: {0:0.00}", heiganHitPoints);
                                Console.WriteLine("Player: Killed by {0}", spellName);
                                Console.WriteLine("Final position: {0}, {1}", playerRowPosition, playerColPosition);
                                return;
                            }

                            cloudRecuring++;
                        }
                        else //eruption
                        {
                            playerHitPoints = PerformHit(heiganHitPoints,playerHitPoints, eruptionDamage, spell, playerColPosition, playerRowPosition);
                            if (playerHitPoints <= 0)
                            {
                                string spellName = string.Empty;
                                if (spell == "Cloud")
                                {
                                    spellName = "Plague Cloud";
                                }
                                else
                                {
                                    spellName = "Eruption";
                                }

                                Console.WriteLine("Heigan: {0:0.00}", heiganHitPoints);
                                Console.WriteLine("Player: Killed by {0}", spellName);
                                Console.WriteLine("Final position: {0}, {1}", playerRowPosition, playerColPosition);
                                return;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static double PerformHit(double heiganHitPoints, double playerHitPoints, int damage, string spell, int row, int col)
        {
            return playerHitPoints -= damage;
        }


        private static void CastSpell(int[,] heiganDanceMatrix, int spellRow, int spellCol)
        {
            if (IsInMatrix(heiganDanceMatrix, spellRow, spellCol))
            {
                heiganDanceMatrix[spellRow, spellCol] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow - 1, spellCol - 1))
            {
                heiganDanceMatrix[spellRow - 1, spellCol - 1] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow - 1, spellCol))
            {
                heiganDanceMatrix[spellRow - 1, spellCol] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow - 1, spellCol + 1))
            {
                heiganDanceMatrix[spellRow - 1, spellCol + 1] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow, spellCol - 1))
            {
                heiganDanceMatrix[spellRow, spellCol - 1] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow, spellCol + 1))
            {
                heiganDanceMatrix[spellRow, spellCol + 1] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow + 1, spellCol - 1))
            {
                heiganDanceMatrix[spellRow + 1, spellCol - 1] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow + 1, spellCol))
            {
                heiganDanceMatrix[spellRow + 1, spellCol] = 0;
            }

            if (IsInMatrix(heiganDanceMatrix, spellRow + 1, spellCol + 1))
            {
                heiganDanceMatrix[spellRow + 1, spellCol + 1] = 0;
            }
        }

        private static bool IsInMatrix(int[,] heiganMatrix, int givenRow, int givenCol)
        {
            bool result = givenRow >= 0
                          && givenRow < heiganMatrix.GetLength(0)
                          && givenCol < heiganMatrix.GetLength(1)
                          && givenCol >= 0;
            return result;
        }

        private static void FillMatrix(int[,] heiganDanceMatrix)
        {
            int filler = 1;

            for (int i = 0; i < heiganDanceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < heiganDanceMatrix.GetLength(1); j++)
                {
                    heiganDanceMatrix[i, j] = filler;
                }
            }
        }
    }
}
