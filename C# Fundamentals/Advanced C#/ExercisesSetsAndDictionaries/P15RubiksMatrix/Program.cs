using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimentions[0];
            int cols = matrixDimentions[1];
            int[,] rubiksMatrixs = new int[rows, cols];
            int numberOfMoves = int.Parse(Console.ReadLine());

            FillMatrix(rubiksMatrixs);
            int[,] rubiksMatrixModified = (int[,])rubiksMatrixs.Clone();

            for (int i = 0; i < numberOfMoves; i++)
            {
                string[] movesArgs = Console.ReadLine().Split();
                int element = int.Parse(movesArgs[0]);
                string direction = movesArgs[1];
                int moves = int.Parse(movesArgs[2]);

                if (direction == "left")
                {
                    ShuffleRowToTheLeft(rubiksMatrixModified, element, moves);
                }
                else if (direction == "right")
                {
                    ShuffleRowToTheRight(rubiksMatrixModified, element, moves);
                }
                else if (direction == "up")
                {
                    ShuffleColumnUp(rubiksMatrixModified, element, moves);
                }
                else
                {
                    ShuffleColumnDown(rubiksMatrixModified, element, moves);
                }
            }

            //for (int i = 0; i < rubiksMatrixModified.GetLength(0); i++)
            //{
            //    for (int j = 0; j < rubiksMatrixModified.GetLength(1); j++)
            //    {
            //        Console.Write(rubiksMatrixModified[i,j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            CompareMatrices(rubiksMatrixs, rubiksMatrixModified);
        }

        private static void CompareMatrices(int[,] rubiksMatrixs, int[,] rubiksMatrixModified)
        {
            for (int i = 0; i < rubiksMatrixs.GetLength(0); i++)
            {
                for (int j = 0; j < rubiksMatrixs.GetLength(1); j++)
                {
                    if (rubiksMatrixs[i,j] == rubiksMatrixModified[i,j])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int rIndex = 0;
                        int cIndex = 0;
                        for (int k = 0; k < rubiksMatrixs.GetLength(0); k++)
                        {
                            for (int l = 0; l < rubiksMatrixs.GetLength(1); l++)
                            {
                                if (rubiksMatrixModified[k,l] == rubiksMatrixs[i,j])
                                {
                                    rIndex = k;
                                    cIndex = l;
                                }
                            }
                        }
                        
                        Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", i ,j, rIndex, cIndex );
                        int buffer = rubiksMatrixModified[i, j];
                        rubiksMatrixModified[i, j] = rubiksMatrixs[i, j];
                        rubiksMatrixModified[rIndex, cIndex] = buffer;
                    }   
                }
            }
        }

        private static void ShuffleColumnDown(int[,] rubiksMatrixModified, int col, int moves)
        {
            Queue<int> rowQueue = new Queue<int>();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rowQueue.Enqueue(rubiksMatrixModified[i, col]);
            }

            rowQueue = new Queue<int>(rowQueue.Reverse());
            for (int i = 0; i < moves; i++)
            {
                int buffer = rowQueue.Dequeue();
                rowQueue.Enqueue(buffer);
            }

            rowQueue = new Queue<int>(rowQueue.Reverse());
            int[] rowArr = rowQueue.ToArray();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rubiksMatrixModified[i, col] = rowArr[i];
            }
        }

        private static void ShuffleColumnUp(int[,] rubiksMatrixModified, int col, int moves)
        {
            Queue<int> rowQueue = new Queue<int>();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rowQueue.Enqueue(rubiksMatrixModified[i, col]);
            }

            for (int i = 0; i < moves; i++)
            {
                int buffer = rowQueue.Dequeue();
                rowQueue.Enqueue(buffer);
            }

            int[] rowArr = rowQueue.ToArray();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rubiksMatrixModified[i, col] = rowArr[i];
            }
        }

        private static void ShuffleRowToTheRight(int[,] rubiksMatrixModified, int row, int moves)
        {
            Queue<int> rowQueue = new Queue<int>();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rowQueue.Enqueue(rubiksMatrixModified[row, i]);
            }

            rowQueue = new Queue<int>(rowQueue.Reverse());
            for (int i = 0; i < moves; i++)
            {
                int buffer = rowQueue.Dequeue();
                rowQueue.Enqueue(buffer);
            }

            rowQueue = new Queue<int>(rowQueue.Reverse());
            int[] rowArr = rowQueue.ToArray();
            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rubiksMatrixModified[row, i] = rowArr[i];
            }

        }

        private static void ShuffleRowToTheLeft(int[,] rubiksMatrixModified, int row, int moves)
        {
            Queue<int> rowQueue = new Queue<int>();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rowQueue.Enqueue(rubiksMatrixModified[row, i]);
            }

            for (int i = 0; i < moves; i++)
            {
                int buffer = rowQueue.Dequeue();
                rowQueue.Enqueue(buffer);
            }

            int[] rowArr = rowQueue.ToArray();

            for (int i = 0; i < rubiksMatrixModified.GetLength(1); i++)
            {
                rubiksMatrixModified[row, i] = rowArr[i];
            }
        }

        private static void FillMatrix(int[,] rubiksMatrixs)
        {
            int currentCell = 1;
            for (int row = 0; row < rubiksMatrixs.GetLength(0); row++)
            {
                for (int col = 0; col < rubiksMatrixs.GetLength(1); col++)
                {
                    rubiksMatrixs[row, col] = currentCell;
                    currentCell++;
                }
            }
        }
    }
}
