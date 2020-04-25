using System;
using System.Linq;
using System.Collections.Generic;
namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bordrs = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string[,] matrix = new string[bordrs[0], bordrs[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] rows = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] splittedCom = comand.Split(" ").ToArray();
                if (splittedCom[0] == "swap" && splittedCom.Length==5)
                {
                    string current = string.Empty;
                    int num1 = int.Parse(splittedCom[1]);
                    int num2 = int.Parse(splittedCom[2]);
                    int num3 = int.Parse(splittedCom[3]);
                    int num4 = int.Parse(splittedCom[4]);

                    if (num1 < bordrs[0]&& num1>=0 && num3<bordrs[0]&& num3>=0 && num2<bordrs[1]&& num2>=0 && num4 < bordrs[1] && num4>=0)
                    {
                        current = matrix[num1, num2] ;
                        matrix[num1, num2] = matrix[num3, num4];
                        matrix[num3, num4] = current;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
