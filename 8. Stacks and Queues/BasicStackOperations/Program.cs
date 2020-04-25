using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] param = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
           
            var stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            if(stack.Count!=param[0])
            {
                return;
            }
            for (int i = 0; i < param[1]; i++)
            {
                stack.Pop();
            }
            if(stack.Contains(param[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
           

        }
    }
}