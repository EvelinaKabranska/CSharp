using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bordrs = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[bordrs[0], bordrs[1]];
            int maxsum = int.MinValue;
            int maxrow = 0;
            int maxcow = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int curentSum = 0;
                    curentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (curentSum > maxsum)
                    {
                        maxsum = curentSum;
                        maxrow = i;
                        maxcow = j;
                    }


                }
            }
            for (int i = maxrow; i < maxrow + 2; i++)
            {
                for (int j = maxcow; j < maxcow + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxsum);
        }
    }
}
