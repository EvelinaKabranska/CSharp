using System;
using System.Linq;
using System.Collections.Generic;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,numbers.Select(x=>$"{x*1.20:f2}")));
        }
    }
}
