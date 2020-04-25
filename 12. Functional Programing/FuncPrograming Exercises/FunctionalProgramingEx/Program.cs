using System;
using System.Linq;
using System.Collections.Generic;

namespace FunctionalProgramingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] line = Console.ReadLine().Split(" ");

            Action<string> printNames = x => Console.WriteLine(x);

            line.ToList().ForEach(x=>printNames(x));
        }
    }
}
