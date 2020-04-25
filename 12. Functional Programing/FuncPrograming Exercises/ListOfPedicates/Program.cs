using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfPedicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var num1 = new List<int>();

            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().ToList();

            for (int i = 1; i <= num; i++)
            {
                bool a = true;
                foreach (var item in numbers)
                {
                    Predicate<int> sss = x => { return x % item == 0; };
                    if (!sss(i))
                    {
                        a = false;
                        break;
                    }
                }
                if ( a)
                {
                    num1.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",num1));
        }
    }
}
