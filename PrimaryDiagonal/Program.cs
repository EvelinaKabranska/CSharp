using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());
            int[,] matrix = new int[border, border];

            for (int i = 0; i < border; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < border; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < border; i++)
            {
                for (int j = 0; j < border; j++)
                {
                    sum += matrix[j, i];
                    i++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
