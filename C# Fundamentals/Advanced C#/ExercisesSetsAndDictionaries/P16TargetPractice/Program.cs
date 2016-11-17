using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P16TargetPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimentions[0];
            int cols = matrixDimentions[1];
            char[,] snakeMatrix = new char[rows, cols];

            string word = Console.ReadLine();
            int[] shotParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotRow = shotParameters[0];
            int shotCol = shotParameters[1];
            int shotRadius = shotParameters[2];

            FillMatrix(snakeMatrix, word);
            FireAShot(snakeMatrix, shotRow, shotCol, shotRadius);

            for (int col = 0; col < snakeMatrix.GetLength(1); col++)
            {
                RunGravity(snakeMatrix, col);
            }

            for (int i = 0; i < snakeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < snakeMatrix.GetLength(1); j++)
                {
                    Console.Write(snakeMatrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static void RunGravity(char[,] snakeMatrix, int col)
        {
            while (true)
            {
                bool hasCellFallen = false;

                for (int r = 1; r < snakeMatrix.GetLength(0); r++)
                {
                    char currentChar = snakeMatrix[r, col];
                    char topChar = snakeMatrix[r - 1, col];

                    if (currentChar == ' ' && topChar != ' ')
                    {
                        snakeMatrix[r, col] = topChar;
                        snakeMatrix[r - 1, col] = currentChar;
                        hasCellFallen = true;
                    }
                }

                if (!hasCellFallen)
                {
                    break;
                }
            }
        }

        private static void FireAShot(char[,] snakeMatrix, int shotRow, int shotCol, int shotRadius)
        {
            for (int r = 0; r < snakeMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < snakeMatrix.GetLength(1); c++)
                {
                    if (Math.Sqrt(Math.Pow((c - shotCol), 2) + Math.Pow((r - shotRow), 2)) <= shotRadius)
                    {
                        snakeMatrix[r, c] = ' ';
                    }
                }
            }
        }

        private static void FillMatrix(char[,] snakeMatrix, string word)
        {
            int letterCount = 0;
            for (int row = snakeMatrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (row % 2 == 0)
                {
                    for (int col = snakeMatrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        snakeMatrix[row, col] = word[letterCount % word.Length];
                        letterCount++;
                    }
                }
                else
                {
                    for (int col = 0; col < snakeMatrix.GetLength(1); col++)
                    {
                        snakeMatrix[row, col] = word[letterCount % word.Length];
                        letterCount++;
                    }
                }

            }
        }
    }
}
