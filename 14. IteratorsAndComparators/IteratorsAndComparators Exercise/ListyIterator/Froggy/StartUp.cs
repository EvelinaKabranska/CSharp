using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(numbers);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
