using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < number.Length-1; i++)
            {
                for (int j = i+1;  j < number.Length; j++)
                {
                    int curSum = 0;
                    curSum = number[i] + number[j];
                    if(curSum==sum)
                    {
                        Console.WriteLine(number[i]+" "+number[j]);
                    }
                }
            }
        }
    }
}
