using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            var queue = new Queue<string>(songs);
            string comand = string.Empty;
            while (queue.Count > 0)
            {
                comand = Console.ReadLine();
                if (comand == "Play")
                {
                    queue.Dequeue();
                }
                else if (comand.StartsWith("Add"))
                {
                    string[] comandSplited = comand.Split(" ", 2);
                    if (queue.Contains(comandSplited[1]))
                    {
                        Console.WriteLine($"{comandSplited[1]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(comandSplited[1]);
                    }
                }
                else if (comand == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
