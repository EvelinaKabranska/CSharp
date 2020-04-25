using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            var stack = new Stack<string>(values.Reverse());
            int result = 0;
            while (stack.Count>0)
            {
                string element = stack.Pop();
                if (element=="+")
                {
                    int number = int.Parse(stack.Pop());
                    result += number;
                }
               else if (element == "-")
                {
                    int number = int.Parse(stack.Pop());
                    result -= number;
                }
                else
                {
                    result = int.Parse(element);
                }

            }
            Console.WriteLine(result);
        }
    }
}
