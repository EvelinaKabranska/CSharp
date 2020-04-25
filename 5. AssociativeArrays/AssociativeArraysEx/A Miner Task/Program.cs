using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = "";
            var total = new Dictionary<string, int>();

            while ((comand = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(Console.ReadLine());
                if (!total.ContainsKey(comand))
                {
                    total.Add(comand, 0);
                }
                total[comand] += num;

            }
            foreach (var item in total)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

