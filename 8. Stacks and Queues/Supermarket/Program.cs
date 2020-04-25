using System;
using System.Linq;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = " ";
            var opaska = new Queue<string>();
            while ((names=Console.ReadLine())!="End")
            {
                if (names == "Paid")
                {
                    foreach (var item in opaska)
                    {
                        Console.WriteLine(item);
                    }
                    opaska.Clear();
                }
                else
                {
                    opaska.Enqueue(names);
                }
            }
            int num = opaska.Count();
            Console.WriteLine($"{num} people remaining.");
        }
    }
}
