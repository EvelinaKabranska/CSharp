using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= end; i++)
            {
                Print(1, i);
            }
            for (int i = end - 1; i >= 1; i--)
            {
                Print(1, i);
            }
        }
        static void Print(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
