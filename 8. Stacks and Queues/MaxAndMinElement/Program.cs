using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
           
            for (int i = 0; i < n; i++)
            {
                int[] comands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int com = comands[0];
                
                switch (com)
                {
                    case 1:
                        {
                            stack.Push(comands[1]);
                            break;
                        }
                    case 2:
                        {
                            if(stack.Count>0)
                            {
                                stack.Pop();
                                break;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Max());
                                break;
                            }
                            break;
                            
                        }
                    case 4:
                        {
                            if(stack.Count>0)
                            {
                                Console.WriteLine(stack.Min());
                                break;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join( ", ",stack));
           
        }
    }
}
