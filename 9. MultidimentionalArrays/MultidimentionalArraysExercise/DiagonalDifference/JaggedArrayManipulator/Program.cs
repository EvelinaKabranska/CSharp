using System;
using System.Linq; 
namespace JaggedArrayManipulator
{
    class Program
    {
        static double[][] MadeMatrix(int n)
        {
            
            var matrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[row] = new double[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            if (rows == 0)
            {
                return;
            }

            var matrix =  MadeMatrix(rows);

           

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] * 2;
                        }
                    }
                }
                else
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] * 0.5;
                        }
                    }
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }
                string[] commandParts = command
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParts.Length != 4)
                {
                    break;
                }

                string commandArgs = commandParts[0];
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                double value = double.Parse(commandParts[3]);

                if (commandArgs.ToLower() == "add")
                {
                    if (row < 0 || row >= rows || col < 0 || col >= matrix[row].Length)
                    {
                        break;  
                    }
                    else
                    {
                        matrix[row][col] += value;
                    }
                    
                }
                else if (commandArgs.ToLower() == "subtract")
                {
                    if (row < 0 || row >= rows || col < 0 || col >= matrix[row].Length)
                    {
                        break;
                    }
                    else
                    {
                        matrix[row][col] -= value;
                    }
                   
                }

            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
