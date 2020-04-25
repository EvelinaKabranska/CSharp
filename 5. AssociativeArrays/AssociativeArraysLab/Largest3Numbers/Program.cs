using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            if (numbers.Length < 3)
            {
                for (int i = 0; i < numbers.Length; i++)
                {

                    Console.Write(string.Join("", sorted[i]));
                    Console.Write(" ");
                }
            }
            else
            {

                for (int i = 0; i < 3; i++)
                {

                    Console.Write(string.Join("", sorted[i]));
                    Console.Write(" ");
                }

            }
        }
    }
}
