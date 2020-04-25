using System;
using System.Collections.Generic;
using System.Linq;
namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var someTxt = Console.ReadLine();
            var fill = new SortedDictionary<char, int>();
            foreach (var item in someTxt)
            {

                if(!fill.ContainsKey(item))
                {
                    fill.Add(item, 0);
                }
                fill[item]++;
            }
            foreach (var item in fill)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
