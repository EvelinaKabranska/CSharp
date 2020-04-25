using System;
using System.Linq;
using System.Collections.Generic;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bordrs = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            char[,] matrix = new char[bordrs[0], bordrs[1]];

            int number = bordrs[0] * bordrs[1];

            var help = new char[number];

            string comand = Console.ReadLine();

            for (int i = 0; i < help.Length; i++)
            {
                help[i] = comand[i-(comand.Length*(i/comand.Length))];
            }

            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = help[count];
                    count++;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if(i%2==0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);

                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(matrix[i, j]);

                    }
                    Console.WriteLine();
                }
                
            }

        }
        
    }
}
