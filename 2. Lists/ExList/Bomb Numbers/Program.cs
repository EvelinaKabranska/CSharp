using System;
using System.Linq;
using System.Collections.Generic;
namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] special = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (special[0] == numbers[i])
                {
                    
                    int start = i - special[1];
                    if(start<0)
                    {
                        start = 0;
                    }

                    int finish = i + special[1];
                    if(finish>numbers.Count-1)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j <= finish; j++)
                    {
                        numbers[j] = 0;
                    }
                }
                
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
