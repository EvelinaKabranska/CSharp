using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var fill = new Dictionary<int,int>();
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!fill.ContainsKey(number))
                {
                    fill.Add(number,0);
                }
                fill[number]++;
            }
            foreach (var item in fill)
            {
                if(item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
