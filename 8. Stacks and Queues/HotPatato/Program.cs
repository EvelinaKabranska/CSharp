using System;
using System.Linq;
using System.Collections.Generic;

namespace HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string[] game = names.Split(" ");
            int num = int.Parse(Console.ReadLine());
            var clue = new Queue<string>(game);
            while (clue.Count>1)
            {
                for (int i = 1; i < num; i++)
                {
                    clue.Enqueue(clue.Dequeue());
                }
                Console.WriteLine($"Removed {clue.Dequeue()}");
            }
            Console.WriteLine($"Last is {clue.Dequeue()}");
        }

    }
}
