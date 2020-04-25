﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var item in text)
            {
                stack.Push(item);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
