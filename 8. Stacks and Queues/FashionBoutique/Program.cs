using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(numbers);
            int sum = 0;
            int count = 1;
            int current = 0;

            while (stack.Count > 0)
            {
                    current = stack.Peek();
                    sum += current;
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    count++;
                    sum = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
