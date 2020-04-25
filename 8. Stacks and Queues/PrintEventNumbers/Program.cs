using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEventNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var nums = new List<int>();

            var fin = new Queue<int>();

            for (int i = 0; i < num.Length; i++)
            {
                fin.Enqueue(num[i]);
            }

            while (fin.Count!=0)
            {
                int a = fin.Dequeue();
                if(a % 2==0)
                {
                    nums.Add(a); 
                }
            }

            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
