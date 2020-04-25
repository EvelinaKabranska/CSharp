using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var fill = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    fill.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",fill));
        }
    }
}
