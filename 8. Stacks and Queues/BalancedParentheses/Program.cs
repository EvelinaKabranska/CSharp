namespace Parentheses
{
    using System;
    using System.Collections.Generic;

    class Parentheses
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        break;
                    default:
                        if ((c == ')' || c == '}' || c == ']') && stack.Count > 0)
                        {
                            if (stack.Peek() == '(' && c == ')' || stack.Peek() == '{' && c == '}' || stack.Peek() == '[' && c == ']')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");

        }
    }
}