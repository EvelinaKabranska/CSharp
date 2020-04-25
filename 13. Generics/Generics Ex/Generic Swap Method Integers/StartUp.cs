using System;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
 public   class StartUp
    {
      public  static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                box.Values.Add(number);
            }

            int[] swapNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = swapNumbers[0];
            int b = swapNumbers[1];
            box.Swap(a, b);

            Console.WriteLine(box.ToString());
        }
    }
}
