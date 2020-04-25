using System;
using System.Linq;
using System.Collections.Generic;

namespace Simboll
{
    class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());
            char[,] matrix = new char[border, border];

            for (int i = 0; i < border; i++)
            {
                char[] rows = Console.ReadLine()
                    .ToCharArray();

                for (int j = 0; j < border; j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            char simbol = Convert.ToChar(Console.ReadLine());
            bool apear = false;
            
            int row = 0;
            int cow = 0;

            for (int i = 0; i < border; i++)
            {
                for (int j = 0; j < border; j++)
                {
                    char sim = matrix[i, j];
                    if (sim == simbol)
                    {
                        apear = true;
                       
                        cow = j;
                        row = i;
                    }
                    if (apear)
                    {
                        break;
                    }
                }
            }
            if (apear)
            {
                Console.WriteLine($"({row}, {cow})");

            }
            else
            {
                Console.WriteLine($"{simbol} does not occur in the matrix");
            }

        }
    }
}
