﻿using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool istrue = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i]<=numbers[j])
                    {
                        istrue = false;
                    }
                    
                }
                if (istrue)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
