using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsAndDictionariesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var fill = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                string names = Console.ReadLine();
                fill.Add(names);

            }
            foreach (var item in fill)
            {
                Console.WriteLine(item);
            }
        }
    }
}
