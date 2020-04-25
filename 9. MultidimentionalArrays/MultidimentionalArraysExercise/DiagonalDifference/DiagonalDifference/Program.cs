using System;
using System.Linq;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {

            int border = int.Parse(Console.ReadLine());

            int[,] matrix = new int[border, border];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = row[j];
                }
             }
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum1 += matrix[i, j];
                    i++;
                }
            }
            for (int i = matrix.GetLength(0)-1; i > 0; i--)
            {
                for (int j = 0; j <matrix.GetLength(0); j++)
                {
                    sum2 += matrix[i, j];
                    i--;
                }
            }

            if(sum1>sum2)
            {
                Console.WriteLine(Math.Abs((sum1) - (sum2)));
            }
            else
            {
                Console.WriteLine(Math.Abs((sum2) - (sum1)));
            }
            

        }
    }
}
