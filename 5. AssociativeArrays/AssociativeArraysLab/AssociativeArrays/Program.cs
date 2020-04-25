using System;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var counts = new SortedDictionary<int, int>();

            foreach (var item in numbers)
            {

                if (!counts.ContainsKey(item))
                {
                    counts.Add(item,0);
                }

                counts[item]=counts[item]+1;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
