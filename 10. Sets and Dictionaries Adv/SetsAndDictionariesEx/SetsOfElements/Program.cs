using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var grups = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = grups[0] + grups[1];
            var first = new HashSet<int>();
            var sec = new HashSet<int>();
            var fin = new List<int>();

            for (int i = 0; i < grups[0]; i++)
            {
                int a = int.Parse(Console.ReadLine());
                first.Add(a);
            }
            for (int i = 0; i < grups[1]; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sec.Add(a);
            }
            foreach (var item in first)
            {
                if (sec.Contains(item))
                {
                    fin.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",fin));
        }
    }
}
