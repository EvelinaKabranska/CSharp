using System;
using System.Collections.Generic;
using System.Linq;
namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> sec = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(first.Count, sec.Count); i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < sec.Count)
                {
                    result.Add(sec[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
