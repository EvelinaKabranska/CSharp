using System;
using System.Linq;
using System.Collections.Generic;

namespace ScanBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char sim = input[i];
                if (sim == '(')
                {
                    stack.Push(i);
                }
                else if (sim == ')')
                {
                    int left = stack.Pop();
                    string exp = input.Substring(left, i - left + 1);
                    Console.WriteLine(exp);
                }
            }
        }
    }
}
