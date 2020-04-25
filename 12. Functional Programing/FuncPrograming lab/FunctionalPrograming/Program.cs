using System;
using System.Linq;
using System.Collections.Generic;

namespace FunctionalPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ",numbers.Where(x=>x%2==0).OrderBy(x=>x)));
        }
    }
}
