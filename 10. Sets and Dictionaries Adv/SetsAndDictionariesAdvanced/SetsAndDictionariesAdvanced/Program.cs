using System;
using System.Collections.Generic;
using System.Linq;


namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] names = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            var grups = new Dictionary<double,int>();

            for (int i = 0; i < names.Length; i++)
            {
                if(!grups.ContainsKey(names[i]))
                {
                    grups.Add(names[i],0);
                }
                grups[names[i]]++;
            }

            foreach (var item in grups)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
