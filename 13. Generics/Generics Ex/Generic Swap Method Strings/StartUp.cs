using System;
using System.Linq;
using System.Collections.Generic;

namespace Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                box.Values.Add(command);
            }

            int[] swapNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = swapNumbers[0];
            int b = swapNumbers[1];
            box.Swap(a, b);

            Console.WriteLine(box.ToString());
        }
    }
}

