using System;
using System.Linq;
using System.Collections.Generic;
namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            int oreginal = numbers.Count;

            for (int i = 0; i < oreginal / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.Write(string.Join(" ", numbers));
        }
    }
}
