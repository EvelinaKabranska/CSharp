using System;
using System.Linq;
using System.Collections.Generic;
namespace CitiesByContinentAndCountry
{
   
    class Program
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
            var cataloge = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < num; i++)
            {
                string[] line = Console.ReadLine().Split(" ").ToArray();
                if (!cataloge.ContainsKey(line[0]))
                {
                    cataloge.Add(line[0],new Dictionary<string, List<string>>());
                }
               
                if (!cataloge[line[0]].ContainsKey(line[1]))
                {
                    cataloge[line[0]].Add(line[1], new List<string>());
                }
                
                cataloge[line[0]][line[1]].Add(line[2]);
            }

            foreach(var continent in cataloge)
            {
                Console.WriteLine(continent.Key + ":");
                var continentPrint = continent.Value;
                foreach (var i in continentPrint)
                {
                    Console.WriteLine($"  {i.Key} -> {string.Join(", ",i.Value)}");
                }
            }
        }
    }
}
