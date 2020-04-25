using System;
using System.Linq;
using System.Collections.Generic;

namespace Zig_Zag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] sec = new int[n];

 
            for (int i = 1; i <= n; i++)
            {
                string[] numbes = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                if(i%2==0)
                {
                    first[i-1] = int.Parse(numbes[1]);
                    sec[i-1] = int.Parse(numbes[0]);

                }
                else
                {
                    first[i-1] = int.Parse(numbes[0]);
                    sec[i-1] = int.Parse(numbes[1]);
                }
                   
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", sec));
        }
    }
}
