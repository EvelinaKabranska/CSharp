using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long[][] triagngle = new long[number][];

            for (int i = 0; i < number; i++)
            {
                triagngle[i] = new long[i + 1];
                triagngle[i][0] = 1;
                triagngle[i][triagngle[i].Length - 1] = 1;
                for (int j = 1; j < triagngle[i].Length - 1; j++)
                {
                    triagngle[i][j] =
                        triagngle[i - 1][j] +
                        triagngle[i - 1][j - 1];
                }
            }
            foreach (var item in triagngle)
            {
                foreach (var num in item)
                {
                    Console.Write(num + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
