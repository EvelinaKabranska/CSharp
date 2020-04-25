using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            var grup = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string[] names = Console.ReadLine()
                .Split(" ")
                .ToArray();

                string name = names[0];
                double grade = double.Parse(names[1]);

                if (!grup.ContainsKey(name))
                {
                    grup.Add(name, new List<double>());
                }
                grup[name].Add(grade);
            }

            foreach (var item in grup)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ",item.Value.Select(x=>x.ToString("f2")))} (avg: {item.Value.OrderByDescending(x=>x).Average():f2})");
            }
        } 
        
    }
}
