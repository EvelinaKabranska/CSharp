using System;
using System.Collections.Generic;
using System.Linq;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] borders = Console.ReadLine()
                  .Split(", ")
                  .Select(int.Parse)
                  .ToArray();
            int row = borders[0];
            int cow = borders[1];
            int sum = 0;
            int[,] matrix = new int[row, cow];

            for (int i = 0; i < row; i++)
            {
                int[] rows = Console.ReadLine()
                      .Split(", ")
                      .Select(int.Parse)
                      .ToArray();

                for (int j = 0; j < cow; j++)
                {
                    int cur = rows[j];
                    sum += cur;
                    matrix[i, j] = cur;
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(cow);
            Console.WriteLine(sum);
        }
    }
}
