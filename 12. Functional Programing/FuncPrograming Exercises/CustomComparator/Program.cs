using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var even1 = new List<int>();
            var odd1 = new List<int>();

            Predicate<int> even = x => { return x % 2 == 0; };
            Predicate<int> odd = x => { return x % 2 != 0; };
            Func<List<int>, string> print = x => string.Join(" ", x);
            even1 = numbers.FindAll(even).OrderBy(x => x).ToList();
            odd1 = numbers.FindAll(odd).OrderBy(x => x).ToList();
            Console.Write($"{print(even1)} {print(odd1)}");


        }
    }
}
