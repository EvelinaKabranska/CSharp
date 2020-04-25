using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOprations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            if (queue.Count != nums[0])
            {
                return;
            }
            for (int i = 0; i < nums[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
