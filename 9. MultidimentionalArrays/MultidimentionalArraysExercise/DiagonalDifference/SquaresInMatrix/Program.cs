using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bordrs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[bordrs[0], bordrs[1]];
            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var rows  = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            int count = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i,j + 1] &&
                                            matrix[i,j] == matrix[i + 1,j] &&
                                            matrix[i,j] == matrix[i + 1,j + 1])
                    {
                        count++;
                    }

                }
            }
            
          
            Console.WriteLine(count);
            
        }
    }
}
