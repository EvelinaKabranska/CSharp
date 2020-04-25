using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace AppliedArithmetics
{
    public 
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => y - 1).ToList();
            Func<List<int>, string> stringify = x => String.Join(" ", x);

            var list = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        list = add(list);
                        break;
                    case "multiply":
                        list = multiply(list);
                        break;
                    case "subtract":
                        list = subtract(list);
                        break;
                    case "print":
                        Console.WriteLine(stringify(list));
                        break;
                }
            }
        }
    }
}
