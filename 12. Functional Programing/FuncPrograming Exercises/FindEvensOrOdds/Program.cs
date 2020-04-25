using System;
using System.Linq;
using System.Collections.Generic;
namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] part = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            int min = part.Min();
            int max = part.Max();

            List<int> list = new List<int>();

            for(int i=min; i<=max; i++)
            {
                list.Add(i);
            }

            Predicate<int> even = x => { return x % 2 == 0; };
            Predicate<int> odd= x=>{ return x % 2 != 0; };

            List<int> final = new List<int>();
            if (command == "odd")
            {
                final = list.FindAll(odd);
            }
            else
            {
                final = list.FindAll(even);
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}
