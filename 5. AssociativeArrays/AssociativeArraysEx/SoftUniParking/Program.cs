using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var DataBase = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string comand = input[0];
                string name = input[1];


                if (comand == "register")
                {
                    if (!DataBase.ContainsKey(name))
                    {
                        DataBase.Add(name, input[2]);
                        Console.WriteLine($"{name} registered {input[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                }
                else if (comand == "unregister")
                {
                    if (!DataBase.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        DataBase.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }

            }
            foreach (var item in DataBase)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
