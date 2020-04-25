using System;
using System.Linq;
using System.Collections.Generic;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> sir = x => Console.WriteLine($"Sir {x}");

            line.ToList().ForEach(x=>sir(x));
        }
    }
}
