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
                .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[bordrs[0], bordrs[1]];
            int maxsum = int.MinValue;
            int maxrow = 0;
            int maxcow = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int curentSum = 0;
                    curentSum = matrix[i, j] + matrix[i, j + 1]+ matrix[i, j + 2] + 
                                matrix[i + 1, j] + matrix[i + 1, j + 1]+matrix[i + 1, j + 2]+
                                matrix[i + 2, j]+matrix[i + 2, j + 1]+matrix[i + 2, j + 2];
                    if (curentSum > maxsum)
                    {
                        maxsum = curentSum;
                        maxrow = i;
                        maxcow = j;
                    }


                }
            }
            Console.WriteLine($"Sum = {maxsum}");

            for (int i = maxrow; i <= maxrow + 2; i++)
            {
                for (int j = maxcow; j <= maxcow + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            
        }
    }
}
