using System;
using System.Linq;
using System.Collections.Generic;
namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<string> final = new List<string>();
            for (int i = 0; i < a; i++)
            {
                string message = Console.ReadLine();
                string[] messageSplited = message.Split();
                if (messageSplited.Length == 3)
                {
                    if (final.Contains(messageSplited[0]))
                    {
                        Console.WriteLine($"{messageSplited[0]} is already in the list!");
                    }
                    else
                    {
                        final.Add(messageSplited[0]);
                    }
                }

                else if (messageSplited.Length == 4)
                {
                    if (final.Contains(messageSplited[0]))
                    {
                        final.Remove(messageSplited[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{messageSplited[0]} is not in the list!");
                    }
                }
            }
            foreach (var person in final)
            {
                Console.WriteLine(person);
            }
        }
    }
}
