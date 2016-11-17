using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17LegoBlocks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            List<List<int>> firstList = new List<List<int>>();
            List<List<int>> secondList = new List<List<int>>();

            FillList(firstList, numOfRows);
            FillList(secondList, numOfRows);
            FillBigList(firstList, secondList, numOfRows);
            bool areEqual = CheckIfListsAreEqualSize(firstList, numOfRows);

            if (areEqual)
            {
                for (int i = 0; i < numOfRows; i++)
                {
                    string output = string.Join(", ", firstList[i]);
                    Console.WriteLine("[{0}]", output);
                }
            }
            else
            {
                int numOfCells = 0;
                for (int i = 0; i < numOfRows; i++)
                {
                    numOfCells += firstList[i].Count;
                }

                Console.WriteLine("The total number of cells is: {0}", numOfCells);
            }
        }

        private static bool CheckIfListsAreEqualSize(List<List<int>> firstList, int numOfRows)
        {
            List<bool> areEqual = new List<bool>();
            for (int i = 0; i < numOfRows - 1; i++)
            {
                if (firstList[i].Count == firstList[i + 1].Count)
                {
                    areEqual.Add(true);
                }
                else
                {
                    areEqual.Add(false);
                }
            }

            if (areEqual.Contains(false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void FillBigList(List<List<int>> firstList, List<List<int>> secondList, int numOfRows)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                secondList[i].Reverse();
                firstList[i].AddRange(secondList[i]);
            }
        }

        private static void FillList(List<List<int>> jaggedArr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                List<int> row = Console.ReadLine().Split().Select(int.Parse).ToList();
                jaggedArr.Add(row);
            }
        }
    }
}

